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
    public partial class frameEncryptAndDecrypt : UserControl
    {
        public frameEncryptAndDecrypt()
        {
            InitializeComponent();
        }

        private void button_Import_Click(object sender, EventArgs e)
        {
            FormImportFile frm = new FormImportFile();
            frm.Show();
        }

        private void button_Export_Click(object sender, EventArgs e)
        {
            FormDecryptFiles frm = new FormDecryptFiles();
            frm.Show();
        }
    }
}
