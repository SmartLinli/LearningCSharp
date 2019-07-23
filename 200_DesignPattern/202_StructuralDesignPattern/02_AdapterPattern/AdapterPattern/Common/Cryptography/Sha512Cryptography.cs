using System.Text;
using System.Security.Cryptography;

namespace SmartLin.LearningCSharp.AdapterPattern
{
    /// <summary>
    /// SHA-512密码系统；
    /// </summary>
    public class Sha512Cryptography : ICryptography
    {
        /// <summary>
        /// 计算；
        /// </summary>
        /// <param name="plainText">明文</param>
        /// <returns>密文</returns>
        public byte[] Compute(string plainText)
        {
            byte[] plainTextBytes = Encoding.Default.GetBytes(plainText);
            SHA512 sha512 = new SHA512CryptoServiceProvider();
            byte[] cipherTextBytes = sha512.ComputeHash(plainTextBytes);
            return cipherTextBytes;
        }
    }
}
