using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Paddings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaycomEncrptionSystem.Encryption;
using WaycomEncrytionsystem;

namespace WaycomEncrptionSystem
{
    public partial class FormDecryptFiles : Form
    {
        SqlConnection conn = DatabaseConnection.db_Connect();
        private List<DocFile> docFiles = new List<DocFile>();
        private int page = 0;
        private static DocFile currentDoc;

        internal static DocFile CurrentDoc
        {
            get { return currentDoc; }
            set { currentDoc = value; }
        }


        public FormDecryptFiles()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM tb_doc_sand_box_e WHERE user_code=@user_code";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user_code", FrameUserProfile.CurrentUser.userName);
                //Read value and save into docFile
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DocFile file = new DocFile();

                    file.Name = reader["doc_name"].ToString();
                    file.Size = reader["doc_size"].ToString();
                    file.Type = reader["doc_type"].ToString();
                    file.Key = (byte[])reader["encryption_key"];
                    if (reader["encryption_iv"] != DBNull.Value)
                    {
                        file.Iv = (byte[])reader["encryption_iv"];
                    }
                    else
                    {
                        file.Iv = null;
                    }
                    file.EncryptionType = reader["encryption_type"].ToString();
                    file.DocOriginal = (byte[])reader["doc_original"];
                    file.DocCipher = (byte[])reader["doc_cipher"];
                    file.userName = reader["user_code"].ToString();
                    file.EncryptedImage = file.ByteArrayToImage(file.DocCipher);
                    file.OrignialImage = file.ByteArrayToImage(file.DocOriginal);

                    docFiles.Add(file);
                }
                reader.Close();
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void FormDecryptFiles_Load(object sender, EventArgs e)
        {
            DocFile doc = new DocFile();
            LoadData();
            DisplayImportFields(page);
        }

        private void button_Close_Window_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Do you want to close", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void DisplayImportFields(int index)
        {
            DocFile doc = new DocFile();
            try
            {
                textBox_fileName.Text = docFiles[index].Name;
                textBox_fileSize.Text = docFiles[index].Size;
                textBox_fileType.Text = docFiles[index].Type;
                textBox_Encryption_Method.Text = docFiles[index].EncryptionType;
                if (docFiles[index].EncryptedImage != null)
                {
                    if (textBox_fileType.Text == ".pdf")
                    {
                        pictureBox_Img.Image = null;
                        textBox_PDF.Visible = true;
                    }
                    else
                    {
                        textBox_PDF.Visible = false;
                        pictureBox_Img.Image = docFiles[index].EncryptedImage;
                        richTextBox1.Text = doc.ByteToString(docFiles[index].DocCipher);
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        private void button_prevPage_Click(object sender, EventArgs e)
        {
            if (page > 0 && page < docFiles.Count)
            {
                button_nextPage.Visible = true;
                page--;
                DisplayImportFields(page);
                if (page == 0)
                {
                    button_prevPage.Visible = false;
                }
            }
        }

        private void button_nextPage_Click(object sender, EventArgs e)
        {
            if (page >= 0 && page <= docFiles.Count - 1)
            {
                button_prevPage.Visible = true;
                page++;
                DisplayImportFields(page);
                if (page == docFiles.Count - 1)
                {
                    button_nextPage.Visible = false;
                }
            }
        }

        private void button_Decrypt_Click_1(object sender, EventArgs e)
        {
            DecryptFile(docFiles[page]);
            FormCompareDoc form = new FormCompareDoc();
            form.Show();
        }

        private void DecryptFile(DocFile doc)
        {
            AES AES = new AES();
            RSAAlogrithm myRSA = new RSAAlogrithm();
            BlowFish myBlowFish = new BlowFish();
            Twofish myTwoFish = new Twofish();
            Camellia myCamellia = new Camellia();
            Serpent mySerpent = new Serpent();
            TripleDESAlgo myTripleDES = new TripleDESAlgo();
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();

            // Key and Initialisation Vector
            byte[] iv = null;
            byte[] key = null;
            AsymmetricCipherKeyPair keyRSA;

            string imageToString;

            // Encryption Method
            string method = doc.EncryptionType;

            byte[] cipher = doc.DocCipher;
            string decryptedData = null;
            if (method == "AES")
            {
                key = doc.Key;
                iv = doc.Iv;
                decryptedData = AES.DecryptStringFromByte(cipher, key, iv);
            }
            else if (method == "Blowfish")
            {
                key = doc.Key;
                decryptedData = myBlowFish.Decrypt(cipher, key);
            }
            else if (method == "Twofish")
            {
                key = doc.Key;
                decryptedData = myTwoFish.Decrypt(cipher, key);
            }
            else if (method == "Camellia")
            {
                key = doc.Key;
                iv = doc.Iv;
                decryptedData = Convert.ToBase64String(myCamellia.Decrypt(cipher, key, iv));
            }
            else if (method == "Serpent")
            {
                key = doc.Key;
                decryptedData = Convert.ToBase64String(mySerpent.Decrypt(cipher, key));
            }
            else if (method == "TripleDES")
            {
                key = doc.Key;
                decryptedData = myTripleDES.Decrypt(cipher, key);
            }
            else
            {
                MessageBox.Show("Please make a selection");
            }

            byte[] byteArr = Convert.FromBase64String(decryptedData);
            doc.DocDecyptedCipher = byteArr;

            // only draw image if the file is pdf extension
            if (doc.Type == ".pdf" || doc.Type == "pdf")
            {

            }
            else
            {
                MemoryStream ms = new MemoryStream(byteArr);
                doc.DecryptedImage = Image.FromStream(ms);
            }
            currentDoc = doc;
        }

    }
}
