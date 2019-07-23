using Microsoft.Win32;

namespace SmartLin.LearningCSharp.Installer
{
    /// <summary>
    /// 注册表服务；
    /// </summary>
    public class RegistryService
    {
        /// <summary>
        /// 公司名称；
        /// </summary>
        private static readonly string _CompanyName;
        /// <summary>
        /// 应用程序名称；
        /// </summary>
        private static readonly string _ApplicationName;
        /// <summary>
        /// 获取应用程序键；
        /// </summary>
        /// <returns>注册表键</returns>
        private static RegistryKey GetApplicationKey()
        {
            RegistryKey softwareKey =                                                           //定义注册表键；
                Registry.LocalMachine.OpenSubKey("SOFTWARE", true);                             //以写入方式打开注册表巢HKEY_LOCAL_MACHINE下的SOFTWARE子键；
            RegistryKey companyNameKey =
                softwareKey.CreateSubKey(_CompanyName);                                         //创建子键；
            RegistryKey applicationNameKey =
                companyNameKey.CreateSubKey(_ApplicationName);
            return applicationNameKey;
        }
        /// <summary>
        /// 设置值；
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="value">值</param>
        public static void SetValue(string name, object value)
        {
            GetApplicationKey().SetValue(name, value);                                          //写入名称与值；decimal类型将被转为REG_SZ类型（即StringZero）；
        }
        /// <summary>
        /// 获取值；
        /// </summary>
        /// <param name="name">名称</param>
        /// <returns>值</returns>
        public static object GetValue(string name)
        {
            return GetApplicationKey().GetValue(name);                                          //获取与名称相应的值；
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        static RegistryService()
        {
            _CompanyName = "SmartLin";
            _ApplicationName = "CourseManagement";
        }
    }
}
