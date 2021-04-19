using System;

namespace SmartLin.LearningCSharp.AdapterPattern
{
    /// <summary>
    /// SHA-512密码系统适配器；
    /// </summary>
    public class Sha512CryptographyAdapter : Sha512Cryptography, ICrypto            //适配器除实现适配目标的接口，还继承被适配者；
    {
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="plainText">明文</param>
        /// <returns>密文</returns>
        public string Encrypt(string plainText)
        {
            byte[] cipherTextBytes = this.Compute(plainText);                       //适配器作为派生类，直接引用被适配者的方法，从而实现类适配器模式；
            return BitConverter.ToString(cipherTextBytes).Replace("-", "");
        }
    }
}
