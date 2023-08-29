using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace WaycomEncrptionSystem.Encryption
{
    internal class Camellia
    {
        // Encrypt a byte array using Camellia
        internal byte[] Encrypt(byte[] data, byte[] key, byte[] iv)
        {
            var cipher = new CfbBlockCipher(new CamelliaEngine(), 128); // 128-bit block size
            var bufferedCipher = new BufferedBlockCipher(cipher);
            cipher.Init(true, new ParametersWithIV(new KeyParameter(key), iv));

            byte[] output = new byte[bufferedCipher.GetOutputSize(data.Length)];
            int length = bufferedCipher.ProcessBytes(data, output, 0);
            bufferedCipher.DoFinal(output, length);

            return output;
        }

        // Decrypt a byte array using Camellia
        internal byte[] Decrypt(byte[] data, byte[] key, byte[] iv)
        {
            var cipher = new CfbBlockCipher(new CamelliaEngine(), 128); // 128-bit block size
            var bufferedCipher = new BufferedBlockCipher(cipher);
            cipher.Init(false, new ParametersWithIV(new KeyParameter(key), iv));

            byte[] output = new byte[bufferedCipher.GetOutputSize(data.Length)];
            int length = bufferedCipher.ProcessBytes(data, output, 0);
            bufferedCipher.DoFinal(output, length);

            return output;
        }

        // Generate a random key of the specified length
        internal byte[] GenerateRandomKey(int length)
        {
            SecureRandom random = new SecureRandom();
            byte[] key = new byte[length / 8]; // Bouncy Castle uses bits, so divide by 8
            random.NextBytes(key);
            return key;
        }

        // Generate a random IV of the specified length
        internal byte[] GenerateRandomIV(int length)
        {
            SecureRandom random = new SecureRandom();
            byte[] iv = new byte[length / 8]; // Bouncy Castle uses bits, so divide by 8
            random.NextBytes(iv);
            return iv;
        }
    }
}


