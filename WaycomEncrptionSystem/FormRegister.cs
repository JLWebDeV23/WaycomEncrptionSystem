using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Org.BouncyCastle.Bcpg.OpenPgp;

namespace WaycomEncrptionSystem
{
    public partial class FormRegister : Form
    {
        static SqlConnection conn = DatabaseConnection.db_Connect();
        public FormRegister()
        {
            InitializeComponent();
        }

        private void button_Close_Window_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            if (textBox_FirstName.Text == "")
            {
                MessageBox.Show("Field missing.");
                textBox_FirstName.Focus();
            }
            else if (textBox_Organisation.Text == "")
            {
                MessageBox.Show("Field missing.");
                textBox_Organisation.Focus();
            }
            else if (textBox_Username.Text == "")
            {
                MessageBox.Show("Field missing.");
                textBox_Username.Focus();
            }
            else if (textBox_Password.Text == "")
            {
                MessageBox.Show("Field missing.");
                textBox_Password.Focus();
            }
            else if (textBox_Password_Confirmation.Text != textBox_Password.Text)
            {
                MessageBox.Show("Confirm your Passwords.");
                textBox_Password_Confirmation.Focus();
            }
            else if (textBox_Email.Text == "")
            {
                MessageBox.Show("Field missing.");
                textBox_Email.Focus();
            }
            else if (textBox_Email_Confirmation.Text != textBox_Email.Text)
            {
                MessageBox.Show("Confirm your emails.");
                textBox_Email_Confirmation.Focus();
            }
            else if (textBox_Address_1.Text == "")
            {
                MessageBox.Show("Field missing.");
                textBox_Address_1.Focus();
            }
            else if (textBox_Address_City.Text == "")
            {
                MessageBox.Show("Field missing.");
                textBox_Address_City.Focus();
            }
            else if (textBox_Address_Postcode.Text == "")
            {
                MessageBox.Show("Field missing.");
                textBox_Address_Postcode.Focus();
            }
            else if (textBox_Address_State.Text == "")
            {
                MessageBox.Show("Field missing.");
                textBox_Address_State.Focus();
            }
            else if (textBox_Address_Country.Text == "")
            {
                MessageBox.Show("Field missing.");
                textBox_Address_Country.Focus();
            }
            else
            {
                // Insert data to the table
                try
                {
                    string queryUser = "INSERT INTO tb_user_info (user_code_p, name_first, password, name_organisation, date_time_added) VALUES (@user_code_p, @name_first, @password, @name_organisation, @date_time_added)";
                    string queryEmail= "INSERT INTO tb_email_address (user_code, email_address, date_time_added) VALUES (@user_code, @email_address, @date_time_added)";
                    string queryAddress = "INSERT INTO tb_address (user_code, address_1, address_2, city, postcode, state, country, date_time_added) VALUES (@user_code, @address_1, @address_2, @city, @postcode, @state, @country, @date_time_added)";
                    SqlCommand cmdUser = new SqlCommand(queryUser, conn);
                    SqlCommand cmdAddress = new SqlCommand(queryAddress, conn);
                    SqlCommand cmdEmail = new SqlCommand(queryEmail, conn);

                    cmdUser.Parameters.AddWithValue("@user_code_p", textBox_Username.Text);
                    cmdUser.Parameters.AddWithValue("@name_first", textBox_FirstName.Text);
                    cmdUser.Parameters.AddWithValue("@password", textBox_Password.Text);
                    cmdUser.Parameters.AddWithValue("@name_organisation", textBox_Organisation.Text);
                    cmdUser.Parameters.AddWithValue("@date_time_added", DateTime.Now.ToString());
                    cmdEmail.Parameters.AddWithValue("@user_code", textBox_Username.Text);
                    cmdEmail.Parameters.AddWithValue("@email_address", textBox_Email.Text);
                    cmdEmail.Parameters.AddWithValue("@date_time_added", DateTime.Now.ToString());
                    cmdAddress.Parameters.AddWithValue("@user_code", textBox_Username.Text);
                    cmdAddress.Parameters.AddWithValue("@address_1", textBox_Address_1.Text);
                    cmdAddress.Parameters.AddWithValue("@address_2", textBox_Address_2.Text);
                    cmdAddress.Parameters.AddWithValue("@city", textBox_Address_City.Text);
                    cmdAddress.Parameters.AddWithValue("@postcode", textBox_Address_Postcode.Text);
                    cmdAddress.Parameters.AddWithValue("@state", textBox_Address_State.Text);
                    cmdAddress.Parameters.AddWithValue("@country", textBox_Address_Country.Text);
                    cmdAddress.Parameters.AddWithValue("@date_time_added", DateTime.Now.ToString());
                    conn.Open();


                    int i = cmdUser.ExecuteNonQuery();
                    i += cmdAddress.ExecuteNonQuery();
                    i += cmdEmail.ExecuteNonQuery();

                    if (i == 3)
                    {
                        this.Close();
                        MessageBox.Show("Successfully Registered");
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }            
        }
    }
}
