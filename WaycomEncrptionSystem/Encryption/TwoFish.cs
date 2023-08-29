using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;


namespace WaycomEncrptionSystem
{
    internal class Twofish
    {
        internal byte[] Encrypt(string plainText, byte[] encryptionKey)
        {
            try
            {
                // Create the Twofish cipher
                var cipher = new TwofishEngine();
                var cipherParameters = new KeyParameter(encryptionKey);

                // Initialize the cipher in ECB mode with no padding
                var cipherStream = new BufferedBlockCipher(new CfbBlockCipher(cipher, 8));
                cipherStream.Init(true, cipherParameters);

                // Convert the plaintext to bytes
                byte[] inputBytes = Encoding.UTF8.GetBytes(plainText);

                // Encrypt the plaintext
                byte[] encryptedBytes = new byte[cipherStream.GetOutputSize(inputBytes.Length)];
                int outputLength = cipherStream.ProcessBytes(inputBytes, 0, inputBytes.Length, encryptedBytes, 0);
                cipherStream.DoFinal(encryptedBytes, outputLength);

                return encryptedBytes;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Encryption error: {ex.Message}");
                return null;
            }
        }

        internal string Decrypt(byte[] encryptedBytes, byte[] decryptionKey)
        {
            try
            {
                // Create the Twofish cipher
                var cipher = new TwofishEngine();
                var cipherParameters = new KeyParameter(decryptionKey);

                // Initialize the cipher in ECB mode with no padding
                var cipherStream = new BufferedBlockCipher(new CfbBlockCipher(cipher, 8));
                cipherStream.Init(false, cipherParameters);

                // Decrypt the encrypted bytes
                byte[] decryptedBytes = new byte[cipherStream.GetOutputSize(encryptedBytes.Length)];
                int outputLength = cipherStream.ProcessBytes(encryptedBytes, 0, encryptedBytes.Length, decryptedBytes, 0);
                cipherStream.DoFinal(decryptedBytes, outputLength);

                // Convert the decrypted bytes back to a string
                string decryptedText = Encoding.UTF8.GetString(decryptedBytes);

                return decryptedText;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Decryption error: {ex.Message}");
                return null;
            }
        }
        
    }
}