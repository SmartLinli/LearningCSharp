using System;

namespace SmartLin.LearningCSharp.AdapterPattern
{
    /// <summary>
    /// 倒序加密器；
    /// </summary>
    public class ReverseCrypto : ICrypto
    {
        /// <summary>
        /// 加密；
        /// 将明文中每个字符倒序输出；
        /// </summary>
        /// <param name="plainText">明文</param>
        /// <returns>密文</returns>
        public string Encrypt(string plainText)
        {
            char[] charArray = plainText.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
