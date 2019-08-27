using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject.Common                                         //向文件夹添加的类，所在命名空间默认为项目默认命名空间+文件夹路径；
{
    /// <summary>
    /// 消息服务；
    /// </summary>
    public static class MessageService
    {
        /// <summary>
        /// 发送电子邮件；
        /// </summary>
        /// <param name="email">电子邮件地址</param>
        /// <param name="message">消息</param>
        public static void SendEmail(string email, string message)
        {
            if (email != null)
            {
				WriteLine($"发送电子邮件至{email}：{message}");
			}
			else
            {
                WriteLine("尚未登记电子邮件。");
            }
        }
        /// <summary>
        /// 发送短信；
        /// </summary>
        /// <param name="phoneNumber">手机号</param>
        /// <param name="message">消息</param>
        public static void SendSms(string phoneNumber, string message)
        {
            if (phoneNumber != null)
            {
				WriteLine($"发送短信至{phoneNumber}：{message}");
			}
			else
            {
                WriteLine("尚未登记手机号。");
            }
        }
    }
}
