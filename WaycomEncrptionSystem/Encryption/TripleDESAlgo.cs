using System.Security.Cryptography;
using System;

namespace WaycomEncrptionSystem.Encryption
{
    internal class TripleDESAlgo
    {
        internal byte[] Encrypt(byte[] data, byte[] key)
        {
            using (TripleDES tripleDesAlg = TripleDES.Create())
            {
                tripleDesAlg.Key = key;
                tripleDesAlg.Mode = CipherMode.ECB; // Electronic Codebook (ECB) mode

                ICryptoTransform encryptor = tripleDesAlg.CreateEncryptor();

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        csEncrypt.Write(data, 0, data.Length);
                        csEncrypt.FlushFinalBlock();
                    }
                    return msEncrypt.ToArray();
                }
            }
        }

        internal string Decrypt(byte[] encryptedData, byte[] key)
        {
            using (TripleDES tripleDesAlg = TripleDES.Create())
            {
                tripleDesAlg.Key = key;
                tripleDesAlg.Mode = CipherMode.ECB;

                ICryptoTransform decryptor = tripleDesAlg.CreateDecryptor();

                using (MemoryStream msDecrypt = new MemoryStream(encryptedData))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }

        internal byte[] GenerateValidTripleDESKey()
        {
            using (TripleDES tripleDesAlg = TripleDES.Create())
            {
                // Generate a valid 3DES key with a key size of 192 bits (24 bytes)
                tripleDesAlg.GenerateKey();

                // Get the generated key
                return tripleDesAlg.Key;
            }
        }
    }
}
