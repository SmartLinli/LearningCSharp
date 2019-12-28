using System.Text;

namespace SmartLin.LearningCSharp.AdapterPattern
{
    /// <summary>
    /// 十六进制加密器；
    /// </summary>
    public class HexadecimalCrypto : ICrypto
    {
        /// <summary>
        /// 加密；
        /// 将明文中每个字符的编码转为十六进制；
        /// </summary>
        /// <param name="plainText">明文</param>
        /// <returns>密文</returns>
        public string Encrypt(string plainText)
        {
            StringBuilder cipherTextBuilder = new StringBuilder();
            char[] charArray = plainText.ToCharArray();
            foreach (short shortCode in charArray)
            {
                cipherTextBuilder.Append(shortCode.ToString("X4"));
            }
            return cipherTextBuilder.ToString();
        }
    }
}
