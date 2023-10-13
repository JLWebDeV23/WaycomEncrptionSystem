using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaycomEncrptionSystem
{
    public partial class FormLogin : Form
    {
        // Fields
        SqlConnection conn = DatabaseConnection.db_Connect();
        public User currentUser;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void linkLabel_Register_Account_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister form = new FormRegister();
            form.ShowDialog();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if (textBox_Username.Text == "")
            {
                MessageBox.Show("Enter the Username");
            } 
            else if (textBox_Password.Text == "")
            {
                MessageBox.Show("Enter the Password");
            }
            else
            {
                try
                {
                    // Open Connection 
                    conn.Open();
                    string queryLogin = "SELECT * FROM tb_user_info WHERE user_code = @user_code and password = @password";
                    SqlCommand cmd = new SqlCommand(queryLogin, conn);
                    cmd.Parameters.AddWithValue("@user_code", textBox_Username.Text);
                    cmd.Parameters.AddWithValue("@password", textBox_Password.Text);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        // Passing public key
                        currentUser = new User(textBox_Username.Text, true);
                        FrameUserProfile.CurrentUser = currentUser;
                        
                        // Admin Form
                        frameAdministration frame = new frameAdministration();
                        frame.Show();                        
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox_Username.Clear();
                        textBox_Password.Clear();

                        // to focus username
                        textBox_Username.Focus();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                finally
                {
                    conn.Close();
                }
            }            
        }

        
    }
}
