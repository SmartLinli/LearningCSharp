using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    public class SmsService                                                                     //定义非静态类；
    {
        public static void SendSms(string phoneNumber, string message)                          //在非静态类中定义静态方法；
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
