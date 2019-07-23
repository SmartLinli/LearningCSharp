using System.Text;
using System.Security.Cryptography;

namespace SmartLin.LearningCSharp.AdapterPattern
{
    /// <summary>
    /// MD5密码系统；
    /// </summary>
    public class Md5Cryptography : ICryptography
    {
        /// <summary>
        /// 计算；
        /// </summary>
        /// <param name="plainText">明文</param>
        /// <returns>密文</returns>
        public byte[] Compute(string plainText)
        {
            byte[] plainTextBytes = Encoding.Default.GetBytes(plainText);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] cipherTextBytes = md5.ComputeHash(plainTextBytes);
            return cipherTextBytes;
        }
    }
}
