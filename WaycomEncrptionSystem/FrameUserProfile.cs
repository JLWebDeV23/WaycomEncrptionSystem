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

namespace WaycomEncrptionSystem
{
    public partial class FrameUserProfile : UserControl
    {
        SqlConnection conn = DatabaseConnection.db_Connect();
        private static User currentUser = null!;
        public FrameUserProfile()
        {
            InitializeComponent();
        }

        internal static User CurrentUser
        {
            get { return currentUser; }
            set
            {
                currentUser = value;
            }
        }


        private void button_Save_Click(object sender, EventArgs e)
        {
            updateDatabase();
            updateProfile();
        }

        private void updateDatabase()
        {
            currentUser.Name = textBox_Profile_Name.Text;
            currentUser.Email = textBox_Profile_Email.Text;
            currentUser.Organisation = textBox_Profile_Organisation.Text;
            currentUser.Address1 = textBox_Profile_A1.Text;
            currentUser.Address2 = textBox_Profile_A2.Text;
            currentUser.State = textBox_Profile_State.Text;
            currentUser.City = textBox_Profile_City.Text;
            currentUser.PostalCode = textBox_Profile_Postcode.Text;
            currentUser.Country = textBox_Profile_Country.Text;
        }

        private void updateProfile()
        {
            try
            {
                string queryInfo = "UPDATE tb_user_info SET name_first=@name_first, name_organisation=@name_organisation, date_time_edit=@edit_time, profile_img=@profile_img WHERE user_code=@username";
                string queryEmail = "UPDATE tb_email_address SET email_address=@email, date_time_edit=@edit_time WHERE user_code=@username";
                string queryAddress = "UPDATE tb_address SET address_1=@address_1, address_2=@address_2, city=@city, postcode=@postcode, state=@state, country=@country, date_time_edit=@edit_time WHERE user_code=@username";

                SqlCommand cmdInfo = new SqlCommand(queryInfo, conn);
                SqlCommand cmdEmail = new SqlCommand(queryEmail, conn);
                SqlCommand cmdAddress = new SqlCommand(queryAddress, conn);

                cmdInfo.Parameters.AddWithValue("@username", currentUser.userName);
                cmdInfo.Parameters.AddWithValue("@name_first", currentUser.Name);
                cmdInfo.Parameters.AddWithValue("@edit_time", DateTime.Now.ToString());
                cmdInfo.Parameters.AddWithValue("@name_organisation", currentUser.Organisation);
                cmdInfo.Parameters.AddWithValue("@profile_img", currentUser.ProfileImg);

                cmdEmail.Parameters.AddWithValue("@username", currentUser.userName);
                cmdEmail.Parameters.AddWithValue("@email", currentUser.Email);
                cmdEmail.Parameters.AddWithValue("@edit_time", DateTime.Now.ToString());

                cmdAddress.Parameters.AddWithValue("@username", currentUser.userName);
                cmdAddress.Parameters.AddWithValue("@address_1", currentUser.Address1);
                cmdAddress.Parameters.AddWithValue("@address_2", currentUser.Address2);
                cmdAddress.Parameters.AddWithValue("@city", currentUser.City);
                cmdAddress.Parameters.AddWithValue("@state", currentUser.State);
                cmdAddress.Parameters.AddWithValue("@country", currentUser.Country);
                cmdAddress.Parameters.AddWithValue("@postcode", currentUser.PostalCode);
                cmdAddress.Parameters.AddWithValue("@edit_time", DateTime.Now.ToString());
                conn.Open();

                int i = cmdInfo.ExecuteNonQuery();
                i += cmdAddress.ExecuteNonQuery();
                i += cmdEmail.ExecuteNonQuery();


                if (i > 0)
                {
                    MessageBox.Show("Successfully Updated");
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void button_Upload_Click(object sender, EventArgs e)
        {
            currentUser.ProfileImage = currentUser.ImportImage();
            pictureBox_Profile.Image = currentUser.ProfileImage;
        }

        private void FrameUserProfile_Load(object sender, EventArgs e)
        {
            textBox_Profile_Name.Text = currentUser.Name;
            textBox_Profile_Organisation.Text = currentUser.Organisation;
            textBox_Profile_Email.Text = currentUser.Email;
            textBox_Profile_A1.Text = currentUser.Address1;
            textBox_Profile_A2.Text = currentUser.Address2;
            textBox_Profile_City.Text = currentUser.City;
            textBox_Profile_State.Text = currentUser.State;
            textBox_Profile_Postcode.Text = currentUser.PostalCode;
            textBox_Profile_Country.Text = currentUser.Country;
            pictureBox_Profile.Image = currentUser.ProfileImage;
        }

        /*private void FrameUserProfile_Load(object sender, EventArgs e)
        {
            textBox_Profile_Name.Text = currentUser.Name;
            textBox_Profile_Organisation.Text = currentUser.Organisation;
            textBox_Profile_Email.Text = currentUser.Email;
            textBox_Profile_A1.Text = currentUser.Address1;
            textBox_Profile_A2.Text = currentUser.Address2;
            textBox_Profile_City.Text = currentUser.City;
            textBox_Profile_State.Text = currentUser.State;
            textBox_Profile_Postcode.Text = currentUser.PostalCode;
            textBox_Profile_Country.Text = currentUser.Country;
            pictureBox_Profile.Image = currentUser.ProfileImage;
        }*/
    }
}
