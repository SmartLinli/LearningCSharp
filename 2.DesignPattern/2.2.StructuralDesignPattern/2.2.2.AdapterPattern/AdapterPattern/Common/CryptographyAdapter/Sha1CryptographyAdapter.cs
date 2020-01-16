using System;

namespace SmartLin.LearningCSharp.AdapterPattern
{
    /// <summary>
    /// SHA-1密码系统适配器；
    /// </summary>
    public class Sha1CryptographyAdapter : ICrypto
    {
        /// <summary>
        /// 密码系统；
        /// </summary>
        private Sha1Cryptography _Sha1Cryptography = new Sha1Cryptography();            //若被适配者不含状态信息，可直接实例化，无需从构造函数传入；
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="plainText">明文</param>
        /// <returns>密文</returns>
        public string Encrypt(string plainText)
        {
            byte[] cipherTextBytes = this._Sha1Cryptography.Compute(plainText);
            return BitConverter.ToString(cipherTextBytes).Replace("-", "");
        }
    }
}
