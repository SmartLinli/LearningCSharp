using System;
using System.Reflection;
using System.Configuration;                                                                     //欲使用配置管理器，还需在本项目的“引用”中添加程序集System.Configuration；

namespace SmartLin.LearningCSharp.Reflection
{
    /// <summary>
    /// 加密器服务；
    /// </summary>
    public class CryptoService
    {
        /// <summary>
        /// 创建加密器；
        /// </summary>
        /// <returns>加密器</returns>
        public static ICrypto Create()
        {
            string currentNamespace = MethodBase.GetCurrentMethod().DeclaringType.Namespace;    //获取当前方法的完整类型名称中的命名空间，从而获取当前的命名空间；
            string cryptoTypeName = ConfigurationManager.AppSettings["CryptoType"].ToString();  //通过配置管理器从配置文件（app.config）中读取应用配置，从而获取当前指定的加密器类型名称；
            Type cryptoType = Type.GetType(currentNamespace + "." + cryptoTypeName);            //根据命名空间与指定的类型名称，获取相应的类型；
            ICrypto crypto = (ICrypto)Activator.CreateInstance(cryptoType);                     //根据类型创建对象（即实例）；
            return crypto;
        }
    }
}
