using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WaycomEncrptionSystem
{
    internal class DocFile
    {
        public string userName {  get; set; }
        public byte[] Key { get; set; }
        public byte[] Iv { get; set; }        
        public string Name { get; set; }
        public string Size { get; set; }
        public string Type { get; set; }        
        public string EncryptionType { get; set; }
        public byte[] DocOriginal { get; set; }
        public byte[] DocCipher { get; set; }
        public byte[] DocDecyptedCipher { get; set; }
        public Image OrignialImage { get; set; }
        public Image EncryptedImage { get; set; }
        public Image DecryptedImage { get; set; }

        public DocFile()
        {

        }
        public DocFile(string filePath)
        {
            // Gets file content to byte array
            byte[] fileToArray = File.ReadAllBytes(filePath);
            DocOriginal = fileToArray;

            string extensionType = Path.GetExtension(filePath);

            if (extensionType == ".pdf" || extensionType == "pdf")
            {
                Type = extensionType;
            }
            else
            {
                OrignialImage = Image.FromFile(filePath);

                // Gets the file extension
                // and check if the input is image file and display the image or other type of file,
                ImageFormat extension = GetImageFormat(fileToArray);
                if (extension != ImageFormat.unknown)
                {
                    // Display the image
                    Type = extension.ToString();
                }
                else
                {
                    Type = extensionType;
                }
            }
            

            // Gets the file size
            FileInfo fileInfo = new FileInfo(filePath);
            Size = fileInfo.Length.ToString();

            // Gets the file name
            Name = Path.GetFileName(filePath);       
      
        }

        public byte[] StringToByte(string str)
        {
            return Encoding.UTF8.GetBytes(str);
        }

        public string ByteToString(byte[] bytes)
        {
            return Convert.ToBase64String(bytes);
        }

        public enum ImageFormat
        {
            bmp,
            jpg,
            gif,
            tiff,
            png,
            unknown
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

        // Create image using ciphertext
        public Image ByteArrayToImage(byte[] byteArrayIn)
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
    }
}
