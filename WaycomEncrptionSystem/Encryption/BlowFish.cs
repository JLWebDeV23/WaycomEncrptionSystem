using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Crypto.Parameters;

namespace WaycomEncrptionSystem.Encryption
{
    
    internal class BlowFish
    {
        internal byte[] Encrypt(string data, byte[] key)
        {
            // Convert the string to bytes using UTF-8 encoding
            byte[] dataBytes = System.Text.Encoding.UTF8.GetBytes(data);


            // Initialize the Blowfish cipher for encryption
            IBufferedCipher cipher = InitializeBlowfishCipher(key, true); // true for encryption

            // Encrypt the data
            byte[] encryptedData = cipher.DoFinal(dataBytes);

            return encryptedData;
        }

        // Decrypts a byte array using Blowfish
        internal string Decrypt(byte[] encryptedData, byte[] key)
        {

            // Initialize the Blowfish cipher for decryption
            IBufferedCipher cipher = InitializeBlowfishCipher(key, false); // false for decryption

            // Decrypt the data
            byte[] decryptedData = cipher.DoFinal(encryptedData);

            // Convert the decrypted bytes back to a string using UTF-8 encoding
            string decryptedString = System.Text.Encoding.UTF8.GetString(decryptedData);

            return decryptedString;
        }

        // Generate a Blowfish key
        internal byte[] GenerateBlowfishKey()
        {
            SecureRandom random = new SecureRandom();
            byte[] key = new byte[16]; // 16 bytes key for Blowfish (128 bits)
            random.NextBytes(key);
            return key;
        }

        // Initialize the Blowfish cipher
        internal IBufferedCipher InitializeBlowfishCipher(byte[] key, bool forEncryption)
        {
            CipherKeyGenerator generator = GeneratorUtilities.GetKeyGenerator("Blowfish");
            generator.Init(new KeyGenerationParameters(new SecureRandom(key), 128));

            IBufferedCipher cipher = CipherUtilities.GetCipher("Blowfish/ECB/PKCS7Padding"); // ECB mode with PKCS7Padding
            cipher.Init(forEncryption, new KeyParameter(key));

            return cipher;
        }
    }
}
