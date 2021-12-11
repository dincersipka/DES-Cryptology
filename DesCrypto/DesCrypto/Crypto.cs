using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DesCrypto
{
    class Crypto
    {
        private DESCryptoServiceProvider ServiceProvider;

        public Crypto() 
        {
            ServiceProvider = new DESCryptoServiceProvider();

            ServiceProvider.Mode = CipherMode.CBC;
            ServiceProvider.Padding = PaddingMode.PKCS7;
        }

        public string Encrypt(string PlainText)
        {
            string EncryptedText;
            byte[] ByteArray = Encoding.UTF8.GetBytes(PlainText);

            using (var memoryStream = new MemoryStream())
            {
                using (var cryptoStream = new CryptoStream(memoryStream, ServiceProvider.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cryptoStream.Write(ByteArray, 0, ByteArray.Length);
                    cryptoStream.FlushFinalBlock();

                    EncryptedText = Convert.ToBase64String(memoryStream.ToArray());
                }
            }

            return EncryptedText;
        }

        public string Decrypt(string EncryptedText)
        {
            string DecryptedText;
            byte[] ByteArray = Convert.FromBase64String(EncryptedText);

            using (var memoryStream = new MemoryStream())
            {
                using (var cryptoStream = new CryptoStream(memoryStream, ServiceProvider.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    cryptoStream.Write(ByteArray, 0, ByteArray.Length);
                    cryptoStream.FlushFinalBlock();

                    DecryptedText = Encoding.UTF8.GetString(memoryStream.ToArray());
                }
            }

            return DecryptedText;
        }

        #region Generators
        public string GenerateKey()
        {
            var Key = GenerateRandom(8);

            ServiceProvider.Key = Encoding.UTF8.GetBytes(Key);

            return Key;
        }

        public string GenerateIV()
        {
            string IV = GenerateRandom(8);

            ServiceProvider.IV = Encoding.UTF8.GetBytes(IV);

            return IV;
        }

        private string GenerateRandom(int length)
        {
            string generateChars = "ASDFGHJKLzxcvbnm12345670987@";
            string generated = "";
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                generated += generateChars[random.Next(0, generateChars.Length)];
            }

            return generated;
        }
        #endregion
    }
}
