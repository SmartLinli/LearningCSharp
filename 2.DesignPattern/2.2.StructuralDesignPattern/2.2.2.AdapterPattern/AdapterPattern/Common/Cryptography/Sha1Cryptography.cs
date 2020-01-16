using System.Text;
using System.Security.Cryptography;

namespace SmartLin.LearningCSharp.AdapterPattern
{
    /// <summary>
    /// SHA-1密码系统；
    /// </summary>
    public class Sha1Cryptography : ICryptography
    {
        /// <summary>
        /// 计算；
        /// </summary>
        /// <param name="plainText">明文</param>
        /// <returns>密文</returns>
        public byte[] Compute(string plainText)
        {
            byte[] plainTextBytes = Encoding.Default.GetBytes(plainText);
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] cipherTextBytes = sha1.ComputeHash(plainTextBytes);
            return cipherTextBytes;
        }
    }
}
