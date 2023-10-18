using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaycomEncrptionSystem
{
    public partial class FormCompareDoc : Form
    {
        DocFile doc = FormDecryptFiles.CurrentDoc;

        public FormCompareDoc()
        {
            InitializeComponent();
        }

        private void button_Close_Window_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Do you want to close", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                /*textBox_PDF1.Visible = false;
                textBox_PDF2.Visible = false;*/
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void LoadData()
        {
            if (doc.Type == ".pdf" || doc.Type == "pdf")
            {
                textBox_PDF1.Visible = true;
                textBox_PDF2.Visible = true;
            }
            else
            {
                MemoryStream ms = new MemoryStream(doc.DocOriginal!);
                pictureBox_Original.Image = Image.FromStream(ms);
                pictureBox_Decrypted.Image = doc.DecryptedImage;
            }
            richTextBox_Original.Text = doc.ByteToString(doc.DocOriginal!);
            richTextBox_Decrypted.Text = doc.ByteToString(doc.DocDecyptedCipher!);

        }

        private void FormCompareDoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button_Export_Click(object sender, EventArgs e)
        {
            string extension = doc.Type!;
            SaveFileDialog file = new SaveFileDialog();
            file.FileName = doc.Name;

            if (extension == "pdf" || extension == ".pdf")
            {
                file.Filter = "PDF(*PDF)|*.pdf";
            }
            else if (extension == "png" || extension == ".png")
            {
                file.Filter = "PNG(*PNG)|*.png";
            }
            else if (extension == "jpg" || extension == ".jpg")
            {
                file.Filter = "JPG(*JPG)|*.jpg";
            }
            else if (extension == "gif" || extension == ".gif")
            {
                file.Filter = "GIF(*GIF)|*.gif";
            }
            else if (extension == "bnp" || extension == ".bmp")
            {
                file.Filter = "BMP(*BMP)|*.bmp";
            }

            

            if (file.ShowDialog() == DialogResult.OK)
            {
                if (extension == "pdf" || extension == ".pdf")
                {
                    File.WriteAllBytes(file.FileName!, doc.DocDecyptedCipher!);
                }
                else
                {
                    doc.DecryptedImage!.Save(file.FileName!);
                }
            }
        }
    }
}
