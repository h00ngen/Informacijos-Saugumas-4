using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IS_Pd4
{
    static class AES
    {
        private static string IV = "0123456789012345";
        private static string key = "5v8y/B?E(H+MbPeShVmYq3t6w9z$C&F)";
        public static string Encrypt(string text)
        {
            AesCryptoServiceProvider crypt_provider = new AesCryptoServiceProvider();
            crypt_provider.BlockSize = 128;
            crypt_provider.KeySize = 256;
            byte[] textBytes = ASCIIEncoding.ASCII.GetBytes(text);
            crypt_provider.IV = ASCIIEncoding.ASCII.GetBytes(IV);
            crypt_provider.Key = ASCIIEncoding.ASCII.GetBytes(key);
            crypt_provider.Padding = PaddingMode.PKCS7;
            crypt_provider.Mode = CipherMode.CBC;
            ICryptoTransform transform = crypt_provider.CreateEncryptor(crypt_provider.Key, crypt_provider.IV);
            byte[] encrypted_bytes = transform.TransformFinalBlock(textBytes, 0, textBytes.Length);
            transform.Dispose();
            return Convert.ToBase64String(encrypted_bytes);
        }
        public static string Decrypt(string text)
        {
            AesCryptoServiceProvider crypt_provider = new AesCryptoServiceProvider();
            crypt_provider.BlockSize = 128;
            crypt_provider.KeySize = 256;
            byte[] textBytes = Convert.FromBase64String(text);
            crypt_provider.IV = ASCIIEncoding.ASCII.GetBytes(IV);
            crypt_provider.Key = ASCIIEncoding.ASCII.GetBytes(key);
            crypt_provider.Padding = PaddingMode.PKCS7;
            ICryptoTransform transform = crypt_provider.CreateDecryptor(crypt_provider.Key, crypt_provider.IV);
            byte[] decrypted_bytes = transform.TransformFinalBlock(textBytes, 0, textBytes.Length);
            transform.Dispose();
            return ASCIIEncoding.ASCII.GetString(decrypted_bytes);
        }
    }
}
