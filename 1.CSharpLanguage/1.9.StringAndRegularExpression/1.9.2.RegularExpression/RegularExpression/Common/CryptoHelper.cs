using System.Text;

namespace SmartLin.LearningCSharp.StringAndRegularExpression
{
    /// <summary>
    /// 加密助手；
    /// </summary>
    public class CryptoHelper
    {
        /// <summary>
        /// 加密；
        /// 将明文中每个字符替换为前1个字符；
        /// </summary>
        /// <param name="plainText">明文</param>
        /// <returns>密文</returns>
        public static string Encrypt(string plainText)
        {
            StringBuilder cipherTextBuilder = new StringBuilder(plainText);                 //定义字符串构建器；
            for (int i = 'a'; i <= 'z'; i++)
            {
                char
                    oldLowerCaseLetter = (char)i
                    , newLowerCaseLetter = (char)(i - 1);
                cipherTextBuilder =
                    cipherTextBuilder.Replace(oldLowerCaseLetter, newLowerCaseLetter);      //调用字符串构建器的Replace方法；
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
            return cipherTextBuilder.ToString();                                            //调用字符串构建器的ToString方法，生成最终字符串；
        }                                                                                   //字符串构建器在修改字符串时，能动态分配内存，无需创建新字符串对象；
    }
}