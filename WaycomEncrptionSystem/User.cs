using ImageMagick;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace WaycomEncrptionSystem
{
    public class User
    {
        public string userName { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Organisation { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public Image ProfileImage { get; set; }
        public byte[] ProfileImg { get; set; }
        public string Extension { get; set; }
        public bool IsActive { get; set; }
        
        static SqlConnection conn = DatabaseConnection.db_Connect(); 
        
        // Default constructor
        public User()
        {

        }

        public User(string userName, bool active)
        {
            this.userName = userName;      
            this.IsActive = active;
            retriveData(userName);

        }

        private void retriveData(string username)
        {
            try
            {
                conn.Open();                
                string queryInfo = "SELECT name_first, name_organisation, profile_img, email_address, address_1, address_2, city, postcode, state, country FROM tb_user_info LEFT JOIN tb_email_address ON tb_user_info.user_code = tb_email_address.user_code LEFT JOIN tb_address ON tb_user_info.user_code = tb_address.user_code";
                SqlCommand cmdInfo = new SqlCommand(queryInfo, conn);
                cmdInfo.Parameters.AddWithValue("user_code", username);
                SqlDataReader readerInfo = cmdInfo.ExecuteReader();

                while (readerInfo.Read())
                {
                    Name = readerInfo["name_first"].ToString();
                    Organisation = readerInfo["name_organisation"].ToString();
                    Email = readerInfo["email_address"].ToString();
                    Address1 = readerInfo["address_1"].ToString();
                    Address2 = readerInfo["address_2"].ToString();
                    City = readerInfo["city"].ToString();
                    PostalCode = readerInfo["postcode"].ToString();
                    State = readerInfo["state"].ToString();
                    Country = readerInfo["country"].ToString();
                    
                    if (readerInfo["profile_img"] != DBNull.Value)
                    {
                        byte[] img = (byte[])readerInfo["profile_img"];
                        ProfileImg = img;
                    }
                    else
                    {
                        ProfileImg = null;
                    }
                }                
                readerInfo.Close();
                conn.Close();
                ProfileImage = ByteArrayToImage(ProfileImg);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        
        public Image ImportImage()
        {
            var filePath = string.Empty;           

            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "Image Files(*.BMP; *.JPG; *.PNG) | *.BMP; *.JPG; *.PNG" + "|All files(*.*) | *.*";
            dialog.CheckFileExists = true;
            dialog.Multiselect = false;

            //delete file when new one is selected 
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ProfileImage = Image.FromFile(dialog.FileName);

                // Convert file content to byte array
                ProfileImg = ConvertImageToByte(ProfileImage);
            }
            return ProfileImage;
        }

        // Method to convert a byte array to an Image
        public Image ByteArrayToImage(byte[] byteArray)
        {
            MemoryStream ms = new MemoryStream(byteArray);
            
            return Image.FromStream(ms);              
        }

        byte[] ConvertImageToByte (Image img)
        {
            byte[] imgByte;
            ImageConverter converter = new ImageConverter();
            imgByte = (byte[])converter.ConvertTo(img, typeof(byte[]));
            return imgByte;
        }

        /**
         * Image Format
         */
        public enum ImageFormat
        {
            bmp,
            jpg,
            gif,
            tiff,
            png,
            unknown
        }

        private static ImageFormat GetImageFormat(byte[] bytes)
        {
            var bmp = Encoding.ASCII.GetBytes("BM");        // BMP
            var gif = Encoding.ASCII.GetBytes("GIF");       // GIF
            var png = new byte[] { 137, 80, 78, 71 };       // PNG
            var tiff = new byte[] { 73, 73, 42 };           // TIFF
            var tiff2 = new byte[] { 77, 77, 42 };          // TIFF
            var jpeg = new byte[] { 255, 216, 255, 224 };   // JPEG
            var jpeg2 = new byte[] { 255, 216, 255, 244 };  // JPEG

            if (bmp.SequenceEqual(bytes.Take(bmp.Length)))
            {
                return ImageFormat.bmp;
            }
            if (gif.SequenceEqual(bytes.Take(gif.Length)))
            {
                return ImageFormat.gif;
            }
            if (png.SequenceEqual(bytes.Take(png.Length)))
            {
                return ImageFormat.png;
            }
            if (tiff.SequenceEqual(bytes.Take(tiff.Length)))
            {
                return ImageFormat.tiff;
            }
            if (tiff2.SequenceEqual(bytes.Take(tiff2.Length)))
            {
                return ImageFormat.tiff;
            }
            if (jpeg.SequenceEqual(bytes.Take(jpeg.Length)))
            {
                return ImageFormat.jpg;
            }
            if (jpeg2.SequenceEqual(bytes.Take(jpeg2.Length)))
            {
                return ImageFormat.jpg;
            }
            return ImageFormat.unknown;
        }
    }
}
