using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using WaycomEncrptionSystem.Encryption;
using System.Buffers.Text;
using System.Diagnostics.Eventing.Reader;
using ImageMagick;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Bcpg.OpenPgp;
using WaycomEncrytionsystem;
using System.Diagnostics;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Security;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.ComponentModel.Design;

namespace WaycomEncrptionSystem
{
    public partial class FormImportFile : Form
    {
        Bitmap image;
        Image img;
        static SqlConnection conn = DatabaseConnection.db_Connect();
        private List<DocFile> docFiles = new List<DocFile>();
        private int page = 0;

        public FormImportFile()
        {
            InitializeComponent();
            pictureBox_Img.AllowDrop = true;
        }

        private void ImportFile()
        {
            try
            {
                docFiles.Clear();

                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.BMP; *.JPG; *.PNG)|*.BMP;*.JPG;*.PNG|PDF Documents (*.pdf)|*.pdf";
                dialog.ValidateNames = true;
                dialog.CheckFileExists = true;
                dialog.Multiselect = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string filePath in dialog.FileNames)
                    {
                        DocFile docFile = new DocFile(filePath);
                        if (docFile.Type == ".pdf")
                        {
                            textBox_PDF.Visible = true;
                        }
                        docFiles.Add(docFile);
                    }
                    DisplayImportFields(page);
                }


                if (docFiles.Count != 1)
                {
                    button_nextPage.Visible = true;
                }
                else
                {
                    button_prevPage.Visible = false;
                    button_nextPage.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        private void DisplayImportFields(int index)
        {
            try
            {
                textBox_fileName.Text = docFiles[index].Name;
                textBox_fileSize.Text = docFiles[index].Size;
                textBox_fileType.Text = docFiles[index].Type;

                comboBox_encryptionMethods.Text = docFiles[index].EncryptionType;
                if (docFiles[index].EncryptedImage != null)
                {
                    pictureBox_Img.Image = docFiles[index].EncryptedImage;
                    richTextBox1.Text = ConvertByteToString(docFiles[index].DocCipher);

                }
                else
                {
                    pictureBox_Img.Image = docFiles[index].OrignialImage;
                    richTextBox1.Text = ConvertByteToString(docFiles[index].DocOriginal);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        private void button_Import_File_Click(object sender, EventArgs e)
        {
            ClearAll();
            ImportFile();
            if (pictureBox_Img.Image != null || richTextBox1.Text != null)
            {
                button_Encrypt.Visible = true;
                button_Clear.Visible = true;
            }
        }

        /** 
         * Clear current the image and its information 
         */
        private void button_Clear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            richTextBox1.Text = string.Empty;
            pictureBox_Img.Image = null;
            textBox_fileName.Text = string.Empty;
            textBox_fileType.Text = string.Empty;
            textBox_fileSize.Text = string.Empty;
            comboBox_encryptionMethods.SelectedItem = null;
            page = 0;
            button_nextPage.Visible = false;
            button_prevPage.Visible = false;
            textBox_PDF.Visible = false;

        }

        private void button_Encrypt_Click(object sender, EventArgs e)
        {
            try
            {
                bool active = false;
                byte[] encryptedData;
                SaveEncryptionType(comboBox_encryptionMethods.Text);
                foreach (DocFile file in docFiles)
                {
                    if (file.EncryptionType.Length > 0)
                    {
                        active = true;
                    }
                    else
                    {
                        active = false;
                    }
                }

                if (active)
                {

                    foreach (DocFile docFile in docFiles)
                    {
                        encryptedData = DocEncryption(docFile.DocOriginal, docFile.EncryptionType, docFile);
                        docFile.DocCipher = encryptedData;
                        img = docFile.ByteArrayToImage(encryptedData);
                        docFile.EncryptedImage = img;

                        // Rewrite current interface to a new interface with encrypted data and image 
                        richTextBox1.Text = ConvertByteToString(docFile.DocCipher);
                        pictureBox_Img.Image = docFile.EncryptedImage;
                    }
                    button_Upload.Visible = true;
                }
                else
                {
                    MessageBox.Show("Please select a method to encrypt");
                    comboBox_encryptionMethods.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }


        }

        private byte[] DocEncryption(byte[] originalText, string encryptionType, DocFile docFile)
        {
            string method = encryptionType;

            AES AES = new AES();
            RSAAlogrithm myRSA = new RSAAlogrithm();
            BlowFish myBlowFish = new BlowFish();
            Twofish myTwoFish = new Twofish();
            Camellia myCamellia = new Camellia();
            Serpent mySerpent = new Serpent();
            TripleDESAlgo myTripleDES = new TripleDESAlgo();
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            byte[] iv = null;
            byte[] key = null;
            AsymmetricCipherKeyPair keyRSA;
            string imageToString;
            byte[] encryptedData = null;


            imageToString = ConvertByteToString(originalText);
            if (method == "AES")
            {
                key = AES.GenerateRandomKey();
                iv = AES.GenerateRandomIV();
                encryptedData = AES.EcryptStringToByte(imageToString, key, iv);
            }
            /*else if (method == "RSA")
            {
                keyRSA = myRSA.keyGenerator();
                encryptedData = myRSA.Encrypt(imageToString, keyRSA);
            }*/
            else if (method == "Blowfish")
            {
                key = myBlowFish.GenerateBlowfishKey();
                encryptedData = myBlowFish.Encrypt(imageToString, key);
            }
            else if (method == "Twofish")
            {
                key = myBlowFish.GenerateBlowfishKey();
                encryptedData = myTwoFish.Encrypt(imageToString, key);
            }
            else if (method == "Camellia")
            {
                key = myCamellia.GenerateRandomKey(256); // 256-bit key for Camellia
                iv = myCamellia.GenerateRandomIV(128);   // 128-bit IV for Camellia
                encryptedData = myCamellia.Encrypt(originalText, key, iv);
            }
            else if (method == "Serpent")
            {
                key = mySerpent.GenerateRandomKey(256 / 8);
                encryptedData = mySerpent.Encrypt(originalText, key);
            }
            else if (method == "TripleDES")
            {
                string base64 = Convert.ToBase64String(originalText);
                byte[] bytes = Encoding.UTF8.GetBytes(base64);
                key = myTripleDES.GenerateValidTripleDESKey();
                encryptedData = myTripleDES.Encrypt(bytes, key);
            }
            else
            {
                MessageBox.Show("Please make a selection.");
            }

            if (iv != null)
            {
                docFile.Iv = iv;
            }
            else
            {
                docFile.Iv = null;
            }

            if (key != null)
            {
                docFile.Key = key;
            }
            else
            {
                docFile.Key = null;
            }

            key = null;
            iv = null;

            return encryptedData;
        }

        private static string ConvertByteToString(byte[] byteArray)
        {
            return Convert.ToBase64String(byteArray);
        }


        private void pictureBox_Img_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox_Img_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string pic in ((string[])e.Data.GetData(DataFormats.FileDrop)))
            {
                img = Image.FromFile(pic);
                image = new Bitmap(img);
                pictureBox_Img.Image = image;
                // fix when import an image, the detail field is also updated 
            }
        }

        private void button_Upload_Click(object sender, EventArgs e)
        {
            if (comboBox_encryptionMethods.SelectedItem != null)
            {
                conn.Open();
                string query = "INSERT INTO tb_doc_sand_box_e (user_code, doc_type, doc_size, doc_name, encryption_type, encryption_key, encryption_iv, doc_cipher, doc_original, date_time_added) VALUES (@user_code, @doc_type, @doc_size, @doc_name, @encryption_type, @encryption_key, @encryption_iv, @doc_cipher, @doc_original, @date_time_added)";

                foreach (DocFile docFile in docFiles)
                {
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@user_code", FrameUserProfile.CurrentUser.userName);
                    cmd.Parameters.AddWithValue("@doc_type", docFile.Type);
                    cmd.Parameters.AddWithValue("@doc_size", docFile.Size);
                    cmd.Parameters.AddWithValue("@doc_name", docFile.Name);
                    cmd.Parameters.AddWithValue("@encryption_type", docFile.EncryptionType);
                    cmd.Parameters.AddWithValue("@encryption_key", docFile.Key);
                    if (docFile.Iv != null)
                    {
                        cmd.Parameters.AddWithValue("@encryption_iv", docFile.Iv);
                    }
                    else
                    {
                        cmd.Parameters.Add("@encryption_iv", SqlDbType.VarBinary).Value = DBNull.Value;
                    }
                    cmd.Parameters.AddWithValue("@doc_cipher", docFile.DocCipher);
                    cmd.Parameters.AddWithValue("@doc_original", docFile.DocOriginal);
                    cmd.Parameters.AddWithValue("@date_time_added", DateTime.Now.ToString());
                    cmd.ExecuteNonQuery();
                }

                conn.Close();

                MessageBox.Show("Saved");
                ClearAll();
            }
            else
            {
                MessageBox.Show("Please select a method to encrypt");
            }

        }

        private void button_Close_Window_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Do you want to close", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ClearAll();
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void button_prevPage_Click(object sender, EventArgs e)
        {
            SaveEncryptionType(comboBox_encryptionMethods.SelectedItem);

            if (page > 0 && page < docFiles.Count)
            {
                //MessageBox.Show(comboBox_encryptionMethods.Text);
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
            SaveEncryptionType(comboBox_encryptionMethods.SelectedItem);

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

        private void SaveEncryptionType(object selectedItem)
        {
            try
            {
                selectedItem = comboBox_encryptionMethods.SelectedItem;
                string selectedText = comboBox_encryptionMethods.GetItemText(selectedItem);
                docFiles[page].EncryptionType = selectedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}
