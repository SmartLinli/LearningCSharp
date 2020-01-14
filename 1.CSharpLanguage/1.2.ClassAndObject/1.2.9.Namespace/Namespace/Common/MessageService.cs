using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject.Common                                         //向文件夹添加的类，所在命名空间默认为项目默认命名空间+文件夹路径；
{
    /// <summary>
    /// 消息服务；
    /// </summary>
    public static class MessageService
    {
        /// <summary>
        /// 发送短信；
        /// </summary>
        /// <param name="phoneNumber">手机号</param>
        /// <param name="message">消息</param>
        public static void SendSms(string phoneNumber, string message)
        {
			if (phoneNumber == null)
			{
				WriteLine("用户尚未登记手机号。\n");
				return;
			}
			WriteLine($"发送短信至用户手机{phoneNumber}：{message}\n");
		}
	}
}
