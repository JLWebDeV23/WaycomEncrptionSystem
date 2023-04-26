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
    public partial class frameRegistration : UserControl
    {
        public frameRegistration()
        {
            InitializeComponent();
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            string query = "insert into User_data (user_ID, firstname, lastname, email, contact, organisation, date_of_birth) values (@user_ID, @firstname, @lastname, @email, @contact, @organisation, @date_of_birth)";
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NSR5BOG\SQLEXPRESS;Initial Catalog=Waycomdb;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();

            cmd.Parameters.AddWithValue("@user_ID", textBox_username.Text);
            cmd.Parameters.AddWithValue("@firstname", textBox_firstName.Text);
            cmd.Parameters.AddWithValue("@lastname", textBox_lastName.Text);
            cmd.Parameters.AddWithValue("@email", textBox_email.Text);
            cmd.Parameters.AddWithValue("@contact", textBox_Contact.Text);
            cmd.Parameters.AddWithValue("@organisation", textBox_organisation.Text);
            cmd.Parameters.AddWithValue("@date_of_birth", textBox_Date_Of_Birth.Text);
            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Saved");
        }
    }
}
