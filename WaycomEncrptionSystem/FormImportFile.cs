using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WaycomEncrptionSystem
{
    public partial class FormImportFile : Form
    {
        public FormImportFile()
        {
            InitializeComponent();
        }

        private void button_Import_File_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            long fileSize;


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;

                FileInfo fileInfo = new FileInfo(filePath);
                fileSize = fileInfo.Length;

                var fileStream = openFileDialog1.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();                   

                }

                MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);

                textBox_fileName.Text = Path.GetFileName(filePath);
                textBox_fileType.Text = Path.GetExtension(filePath);
                textBox_fileSize.Text = fileSize.ToString();
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
