using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;


namespace WaycomEncrptionSystem.Encryption
{
    internal class Serpent
    {
        // Encrypt a byte array using Serpent
        internal byte[] Encrypt(byte[] data, byte[] key)
        {
            var engine = new SerpentEngine();
            var cipher = new PaddedBufferedBlockCipher(engine, new ZeroBytePadding());
            cipher.Init(true, new KeyParameter(key));

            return ProcessData(cipher, data);
        }

        // Decrypt a byte array using Serpent
        internal byte[] Decrypt(byte[] data, byte[] key)
        {
            var engine = new SerpentEngine();
            var cipher = new PaddedBufferedBlockCipher(engine, new ZeroBytePadding());
            cipher.Init(false, new KeyParameter(key));

            return ProcessData(cipher, data);
        }

        // Process data using the cipher
        internal byte[] ProcessData(IBufferedCipher cipher, byte[] data)
        {
            int outputSize = cipher.GetOutputSize(data.Length);
            byte[] output = new byte[outputSize];

            int length = cipher.ProcessBytes(data, 0, data.Length, output, 0);
            length += cipher.DoFinal(output, length);

            // Trim any padding
            byte[] result = new byte[length];
            Array.Copy(output, result, length);

            return result;
        }

        // Generate a random key of the specified length
        internal byte[] GenerateRandomKey(int length)
        {
            SecureRandom random = new SecureRandom();
            byte[] key = new byte[length];
            random.NextBytes(key);
            return key;
        }
    }
}
