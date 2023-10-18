using System;
using System.IO;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.OpenSsl;
using System.Text;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Crypto.Engines;

namespace WaycomEncrytionsystem
{
    class RSAAlogrithm
    {

        internal byte[] Encrypt(string plaintext, AsymmetricCipherKeyPair keyPair)
        {
            try
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(plaintext);
                var cipher = CipherUtilities.GetCipher("RSA/None/PKCS1Padding");
                cipher.Init(true, keyPair.Public);
                byte[] encryptedBytes = cipher.DoFinal(inputBytes);

                return encryptedBytes;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Encryption error: {ex.Message}");
                return null!;
            }
        }

        internal string Decrypt(byte[] encryptedData, AsymmetricCipherKeyPair keyPair)
        {
            try
            {
                
                var cipher = CipherUtilities.GetCipher("RSA/None/PKCS1Padding");
                cipher.Init(false, keyPair.Private);
                byte[] decryptedBytes = cipher.DoFinal(encryptedData);
                string decryptedPlaintext = Convert.ToBase64String(decryptedBytes);

                return decryptedPlaintext;
            }
            catch (Exception ex )
            {
                MessageBox.Show($"Encryption error: {ex.Message}");
                return null!;
            }
        }

        // Generate RSA key pair
        internal AsymmetricCipherKeyPair keyGenerator()
        {
            
            var keyGenerationParameters = new KeyGenerationParameters(new SecureRandom(), 2048);
            var generator = GeneratorUtilities.GetKeyPairGenerator("RSA");
            generator.Init(keyGenerationParameters);
            AsymmetricCipherKeyPair keyPair = generator.GenerateKeyPair();

            return keyPair;

        }
    }
}

