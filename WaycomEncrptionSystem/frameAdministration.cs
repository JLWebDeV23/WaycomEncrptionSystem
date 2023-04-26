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
            this.Close();            
        }        

        private void button_Maximise_Window_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            button_Maximise_Window.Visible = false;
            button_Maximised_Window.Location = button_Maximise_Window.Location;
            button_Maximised_Window.Visible = true;
        }

        private void button_Minimise_Window_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_Maximised_Window_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            button_Maximised_Window.Visible = false;
            button_Maximise_Window.Visible = true;
        }

        private void button_Home_Click(object sender, EventArgs e)
        {
            frameRegistration1.Visible = false;
            profile1.Visible = false;
            frameEncryptAndDecrypt1.Visible = false;

        }

        private void button_Registration_Click(object sender, EventArgs e)
        {
            frameRegistration1.Visible = true;
            profile1.Visible = false;
            frameEncryptAndDecrypt1.Visible = false;
        }

        private void button_Profile_Click(object sender, EventArgs e)
        {
            profile1.Visible = true;
            frameRegistration1.Visible = false;
            frameEncryptAndDecrypt1.Visible = false;

        }

        
        private void button_Data_Encrypt_Decrypt_Click(object sender, EventArgs e)
        {
            frameEncryptAndDecrypt1.Visible = true;
            frameRegistration1.Visible = false;
            profile1.Visible = false;           

        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NSR5BOG\SQLEXPRESS;Initial Catalog=Waycomdb;Integrated Security=True");

        private void button_login_Click(object sender, EventArgs e)
        {
            String username, user_password;

            username = txt_username.Text;
            user_password = txt_password.Text;

            conn.Open();
            try
            {
                string querry = "SELECT * FROM Login_new WHERE username = '" + txt_username.Text + "' AND password = '" + txt_password.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = txt_username.Text;
                    user_password = txt_password.Text;

                    // Page that needed to be load next
                    /*Menuform form2 = new Menuform();
                    form2.Show();
                    this.Hide();*/
                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_password.Clear();
                    txt_username.Clear();

                    // to focus username
                    txt_username.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
            txt_username.Focus();
        }

        private void profile1_Load(object sender, EventArgs e)
        {

        }
    }
}
