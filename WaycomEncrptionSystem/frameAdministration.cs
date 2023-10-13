using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaycomEncrptionSystem
{
    public partial class frameAdministration : Form
    {
        public frameAdministration()
        {
            InitializeComponent();
        }

        private void frameAdmission_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void button_Close_Window_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you ready to log out?", "LOGOUT", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                FormLogin form = new FormLogin();
                form.Show();
            }
        }

        private void button_Home_Click(object sender, EventArgs e)
        {
            panel_home.Visible = true;
            frameEncryptAndDecrypt1.Visible = false;
            frameUserProfile1.Visible = false;
        }

        private void button_Profile_Click(object sender, EventArgs e)
        {
            FrameUserProfile frame = new FrameUserProfile();
            
            // Set the currentUser property of the FrameUserProfile
            this.Controls.Add(frame);
            

            panel_home.Visible = false;
            frameEncryptAndDecrypt1.Visible = false;
            frameUserProfile1.Visible = true;
        }

        private void button_Data_Encrypt_Decrypt_Click(object sender, EventArgs e)
        {
            panel_home.Visible = false;
            frameUserProfile1.Visible = false;
            frameEncryptAndDecrypt1.Visible = true;

        }
    }
}
