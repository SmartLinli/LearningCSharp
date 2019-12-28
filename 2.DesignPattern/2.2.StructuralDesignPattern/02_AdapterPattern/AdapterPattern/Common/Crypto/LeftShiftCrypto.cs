using System.Text;

namespace SmartLin.LearningCSharp.AdapterPattern
{
    /// <summary>
    /// 左移加密器；
    /// </summary>
    public class LeftShiftCrypto : ICrypto
    {
        /// <summary>
        /// 加密；
        /// 将明文中每个字符左移1位；
        /// </summary>
        /// <param name="plainText">明文</param>
        /// <returns>密文</returns>
        public string Encrypt(string plainText)
        {
            StringBuilder cipherTextBuilder = new StringBuilder(plainText);
            for (int i = 'a'; i <= 'z'; i++)
            {
                char
                    oldLowerCaseLetter = (char)i
                    , newLowerCaseLetter = (char)(i - 1);
                cipherTextBuilder =
                    cipherTextBuilder.Replace(oldLowerCaseLetter, newLowerCaseLetter);
            }
            for (int i = 'A'; i <= 'Z'; i++)
            {
                char
                    oldUpperCaseLetter = (char)i
                    , newUpperCaseLetter = (char)(i - 1);
                cipherTextBuilder =
                    cipherTextBuilder.Replace(oldUpperCaseLetter, newUpperCaseLetter);
            }
            for (int i = '0'; i <= '9'; i++)
            {
                char
                    oldDigit = (char)i
                    , newDigit = (char)(i - 1);
                cipherTextBuilder =
                    cipherTextBuilder.Replace(oldDigit, newDigit);
            }
            return cipherTextBuilder.ToString();
        }
    }
}
