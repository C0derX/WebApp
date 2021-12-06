using System.Security.Cryptography;
using System.Text;
using UserManagement.Service.Services.Interface;

namespace UserManagement.Service.Services.Implementations
{
    public sealed class RandomKeyGeneratorServiceImpl : RandomKeyGeneratorService
    {
        public string getRandomAlphanumericKey(int size = 15)
        {
            char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
            byte[] data = new byte[size];
            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetBytes(data);
            }
            StringBuilder result = new StringBuilder(size);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }
    }
}
