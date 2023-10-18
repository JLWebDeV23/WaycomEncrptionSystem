using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaycomEncrptionSystem.Encryption
{
    internal class AES
    {
        public byte[] EcryptStringToByte(string plaintext, byte[] key, byte[] iV)
        {
            // Check input argument 
            if (plaintext == null || plaintext.Length <= 0)
                throw new ArgumentNullException("plaintext");
            if (key == null || key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (iV == null || iV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            using (Aes aesObj = Aes.Create())
            {
                aesObj.Key = key;
                aesObj.IV = iV;

                ICryptoTransform encryptor = aesObj.CreateEncryptor(aesObj.Key, aesObj.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            // Write data to stream
                            swEncrypt.Write(plaintext);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            return encrypted;
        }

        public string DecryptStringFromByte(byte[] ciphertext, byte[] key, byte[] iV)
        {
            if (ciphertext == null || ciphertext.Length <= 0)
                throw new ArgumentNullException("ciphertext");
            if (key == null || key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (iV == null || iV.Length <= 0)
                throw new ArgumentNullException("IV");

            string plaintext;

            using (Aes aesObj = Aes.Create())
            {
                aesObj.Key = key;
                aesObj.IV = iV;

                ICryptoTransform decryptor = aesObj.CreateDecryptor(aesObj.Key, aesObj.IV);

                using (MemoryStream msDecrypt = new MemoryStream(ciphertext))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            return plaintext;
        }

        public byte[] GenerateRandomKey()
        {
            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            byte[] key = new byte[16];
            rng.GetBytes(key);
            return key;            
        }

        public byte[] GenerateRandomIV()
        {
            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            byte[] iv = new byte[16];
            rng.GetBytes(iv);
            return iv;                       
        }
    }    
}
