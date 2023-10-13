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
            DocFile doc = FormDecryptFiles.CurrentDoc;
            if (doc.Type == ".pdf" || doc.Type == "pdf")
            {
                textBox_PDF1.Visible = true;
                textBox_PDF2.Visible = true;
            }
            else
            {
                MemoryStream ms = new MemoryStream(doc.DocOriginal);
                pictureBox_Original.Image = Image.FromStream(ms);
                pictureBox_Decrypted.Image = doc.DecryptedImage;
            }
            richTextBox_Original.Text = doc.ByteToString(doc.DocOriginal);
            richTextBox_Decrypted.Text = doc.ByteToString(doc.DocDecyptedCipher);

        }

        private void FormCompareDoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
