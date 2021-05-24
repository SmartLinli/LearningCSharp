using System;

namespace SmartLin.LearningCSharp.AdapterPattern
{
    /// <summary>
    /// 密码系统适配器；
    /// </summary>
    public class CryptographyAdapter : ICrypto                                          //适配器需实现适配目标的接口；
    {
        /// <summary>
        /// 密码系统；
        /// </summary>
        private ICryptography _Cryptography;                                            //适配器可引用被适配者，从而实现对象适配器模式；
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="plainText">明文</param>
        /// <returns>密文</returns>
        public string Encrypt(string plainText)                                         //实现适配目标的接口，并调用被适配者的相应方法、进行必要的处理；
        {
            byte[] cipherTextBytes = this._Cryptography.Compute(plainText);
            return BitConverter.ToString(cipherTextBytes).Replace("-", "");
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="cryptography">密码系统</param>
        public CryptographyAdapter(ICryptography cryptography)                          //从构造函数传入被适配者；
        {
            this._Cryptography = cryptography;
        }
    }
}
