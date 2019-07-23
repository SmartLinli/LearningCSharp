using System;
using System.Reflection;

namespace SmartLin.LearningCSharp.AdapterPattern
{
    /// <summary>
    /// 加密器服务；
    /// </summary>
    public class CryptoService
    {
        /// <summary>
        /// 加密；
        /// </summary>
        /// <param name="cryptoTypeName">加密器类型名称</param>
        /// <returns>加密器</returns>
        public static ICrypto Create(string cryptoTypeName)
        {
            string currentNamespace = MethodBase.GetCurrentMethod().DeclaringType.Namespace;    //获取当前方法的完整类型名称中的命名空间，从而获取当前的命名空间；
            Type cryptoType = Type.GetType(currentNamespace + "." + cryptoTypeName);            //根据命名空间与指定的类型名称，获取相应的类型；
            ICrypto crypto = (ICrypto)Activator.CreateInstance(cryptoType);                     //根据类型创建对象（即实例）；
            return crypto;
        }
    }
}
