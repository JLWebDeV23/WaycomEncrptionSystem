using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using WaycomEncrptionSystem.Encryption;
using System.Buffers.Text;
using System.Diagnostics.Eventing.Reader;
using ImageMagick;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Bcpg.OpenPgp;
using WaycomEncrytionsystem;
using System.Diagnostics;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Security;

namespace WaycomEncrptionSystem
{
    public partial class FormImportFile : Form
    {
        Bitmap image;
        Image img;
        string cipher = null;
        string original = null;

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

        public FormImportFile()
        {
            InitializeComponent();
            pictureBox_Img.AllowDrop = true;
        }

        private void ImportFile()
        {
            var filePath = string.Empty;
            long fileSize;
            string toBase64;

            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "Image Files(*.BMP; *.JPG; *.PNG) | *.BMP; *.JPG; *.PNG" + "|All files(*.*) | *.*";
            dialog.CheckFileExists = true;
            dialog.Multiselect = false;

            //delete file when new one is selected 
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // Get file path and content
                filePath = dialog.FileName;

                // Create a FileInFo object from file path
                FileInfo fileInfo = new FileInfo(filePath);

                // Convert file content to byte array
                byte[] fileToArray = File.ReadAllBytes(filePath);

                // Display the file extension
                // and check if the input is image file and display the image or other type of file,
                ImageFormat extension = GetImageFormat(fileToArray);
                if (extension != ImageFormat.unknown)
                {
                    // Display the image
                    img = Image.FromFile(filePath);
                    pictureBox_Img.Image = img;
                    textBox_fileType.Text = "." + extension;
                }
                else
                {
                    textBox_fileType.Text = Path.GetExtension(filePath);
                }

                // Convert the file path from byte array to string 
                toBase64 = Convert.ToBase64String(fileToArray);

                // Save original file text
                string filePath1 = @"D:\IFB399\tempPicturePath\storePath\orignial.txt";
                using (StreamWriter writer = new StreamWriter(filePath1))
                {
                    writer.Write(toBase64);
                }

                // Display the file content in richTextBox
                richTextBox1.Text = toBase64;
                original = toBase64;

                // Display the file size
                fileSize = fileInfo.Length;
                textBox_fileSize.Text = fileSize.ToString();

                // Display the file name
                textBox_fileName.Text = Path.GetFileName(filePath);
            }
        }

        private void button_Import_File_Click(object sender, EventArgs e)
        {
            ClearAll();
            ImportFile();
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

        /** 
         * Clear current the image and its information 
         */
        private void button_Clear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            richTextBox1.Text = string.Empty;
            pictureBox_Img.Image = null;
            textBox_fileName.Text = string.Empty;
            textBox_fileType.Text = string.Empty;
            textBox_fileTitle.Text = string.Empty;
            textBox_fileSize.Text = string.Empty;
            comboBox1.SelectedItem = null;
        }

        Aes myAes = Aes.Create();
        AES AES = new AES();
        RSAAlogrithm myRSA = new RSAAlogrithm();
        BlowFish myBlowFish = new BlowFish();
        Twofish myTwoFish = new Twofish();
        Camellia myCamellia = new Camellia();
        Serpent mySerpent = new Serpent();
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        private string stringIV = "abcdefghijklmnmo";
        private string stringKey = "abcdefghijklmnmoabcdefghijklmnmo";
        byte[] iv;
        byte[] key;
        AsymmetricCipherKeyPair keyRSA;

        private void button_Encrypt_Click(object sender, EventArgs e)
        {
            myAes.Key = Encoding.ASCII.GetBytes(stringKey);
            myAes.IV = Encoding.ASCII.GetBytes(stringIV);
            byte[] encryptedData = null;
            string imageToString = richTextBox1.Text;

            byte[] imgByte = Encoding.UTF8.GetBytes(imageToString);

            // Encryption select
            if (comboBox_encryptionMethods.Text == "AES")
            {
                encryptedData = AES.EcryptStringToByte(imageToString, myAes.Key, myAes.IV);
            }
            else if (comboBox_encryptionMethods.Text == "RSA")
            {
                keyRSA = myRSA.keyGenerator();
                encryptedData = myRSA.Encrypt(imageToString, keyRSA);
            }
            else if (comboBox_encryptionMethods.Text == "Blowfish")
            {
                key = myBlowFish.GenerateBlowfishKey();
                encryptedData = myBlowFish.Encrypt(imageToString, key);
            }
            else if (comboBox_encryptionMethods.Text == "Twofish")
            {
                key = myBlowFish.GenerateBlowfishKey();
                encryptedData = myTwoFish.Encrypt(imageToString, key);
            }
            else if (comboBox_encryptionMethods.Text == "Camellia")
            {
                key = myCamellia.GenerateRandomKey(256); // 256-bit key for Camellia
                iv = myCamellia.GenerateRandomIV(128);   // 128-bit IV for Camellia
                encryptedData = myCamellia.Encrypt(imgByte, key, iv);
            }
            else if (comboBox_encryptionMethods.Text == "Serpent")
            {
                key = mySerpent.GenerateRandomKey(256 / 8);
                encryptedData = mySerpent.Encrypt(imgByte, key);
            }
            else
            {
                MessageBox.Show("Please make a selection");
                return;
            }

            // Convert ciphertext to String
            cipher = Convert.ToBase64String(encryptedData);

            string filePath = @"D:\IFB399\tempPicturePath\storePath\base64.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(cipher);
            }

            richTextBox1.Text = cipher;

            img = byteArrayToImage(encryptedData);
            img.Save(@"D:\IFB399\tempPicturePath\storePath\sample1.jpg");

            img = Image.FromFile(@"D:\IFB399\tempPicturePath\storePath\sample1.jpg");
            pictureBox_Img.Image = img;
        }

        // Create image using ciphertext
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            int size = (int)Math.Sqrt(byteArrayIn.Length); // Some bytes will not be used as we round down here

            Bitmap bitmap = new Bitmap(size, size, PixelFormat.Format8bppIndexed);
            BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.WriteOnly, bitmap.PixelFormat);

            try
            {
                // Copy byteArrayIn to bitmapData row by row (to account for the case
                // where bitmapData.Stride != bitmap.Width)
                for (int rowIndex = 0; rowIndex < bitmapData.Height; ++rowIndex)
                    Marshal.Copy(byteArrayIn, rowIndex * bitmap.Width, bitmapData.Scan0 + rowIndex * bitmapData.Stride, bitmap.Width);
            }
            finally
            {
                bitmap.UnlockBits(bitmapData);
            }

            return bitmap;
        }

        // check files content are the same
        private void button_Decrypt_Click(object sender, EventArgs e)
        {
            string imageObjPath = @"D:\IFB399\tempPicturePath\storePath\sample.png";
            byte[] cipher = Convert.FromBase64String(richTextBox1.Text);
            string decryptedData = null;
            byte[] imageByte = null;
            byte[] decryptedDataForBlowfish = null;
            if (comboBox_encryptionMethods.Text == "AES")
            {
                decryptedData = AES.DecryptStringFromByte(cipher, myAes.Key, myAes.IV);
            }
            else if (comboBox_encryptionMethods.Text == "RSA")
            {
                decryptedData = myRSA.Decrypt(cipher, keyRSA);
            }
            else if (comboBox_encryptionMethods.Text == "Blowfish")
            {
                decryptedData = myBlowFish.Decrypt(cipher, key);
            }
            else if (comboBox_encryptionMethods.Text == "Twofish")
            {
                decryptedData = myTwoFish.Decrypt(cipher, key);
            }
            else if (comboBox_encryptionMethods.Text == "Camellia")
            {
                decryptedData = Encoding.UTF8.GetString(myCamellia.Decrypt(cipher, key, iv));
            }
            else if (comboBox_encryptionMethods.Text == "Serpent")
            {
                decryptedData = Encoding.UTF8.GetString(mySerpent.Decrypt(cipher, key));
            }
            else
            {
                MessageBox.Show("Please make a selection");
                return;
            }

            imageByte = Convert.FromBase64String(decryptedData);
            string filePath1 = @"D:\IFB399\tempPicturePath\storePath\decryptedCipher.txt";
            using (StreamWriter writer = new StreamWriter(filePath1))
            {
                writer.Write(decryptedData);
            }

            using (FileStream imageFileStream = new FileStream(imageObjPath, FileMode.Create))
            {
                imageFileStream.Write(imageByte, 0, imageByte.Length);
                imageFileStream.Flush();
            }

            img = Image.FromFile(@"D:\IFB399\tempPicturePath\storePath\sample.png");
            pictureBox_Img.Image = img;
            richTextBox1.Text = Convert.ToBase64String(imageByte);
        }

        private void pictureBox_Img_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox_Img_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string pic in ((string[])e.Data.GetData(DataFormats.FileDrop)))
            {
                img = Image.FromFile(pic);
                image = new Bitmap(img);
                pictureBox_Img.Image = image;
                // fix when import an image, the detail field is also updated 
            }
        }

        private void UsefulFunctions()
        {
            // Save string 
            string filePath = @"D:\ASUS\Desktop\base64.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(richTextBox1.Text);
            }

            // String to image click
            string base64String = richTextBox1.Text;
            string imageObjPath = @"D:\ASUS\Desktop\sample.png";
            byte[] imageBytes = Convert.FromBase64String(base64String);

            using (FileStream imageFileStream = new FileStream(imageObjPath, FileMode.Create))
            {
                imageFileStream.Write(imageBytes, 0, imageBytes.Length);
                imageFileStream.Flush();
            }
        }


        /**
         * Identify Image Formate
         */
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

        private void button_Upload_Click(object sender, EventArgs e)
        {
            string query = "insert into User_encrypted_file (file_type, doc_name, doc_bin, doc_bin_encrypted) values (@file_type, @doc_name, @doc_bin, @doc_bin_encrypted)";

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NSR5BOG\SQLEXPRESS;Initial Catalog=Waycomdb;Integrated Security=True");

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            cmd.Parameters.AddWithValue("@file_type", textBox_fileType.Text);
            cmd.Parameters.AddWithValue("@doc_name", textBox_fileName.Text);
            cmd.Parameters.AddWithValue("@doc_bin", Convert.FromBase64String(original));
            cmd.Parameters.AddWithValue("@doc_bin_encrypted", Convert.FromBase64String(cipher));
            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Saved");
        }
    }
}
