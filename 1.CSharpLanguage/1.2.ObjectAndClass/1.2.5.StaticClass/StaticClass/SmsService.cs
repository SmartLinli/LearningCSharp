using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    public class SmsService                                                                     //定义非静态类；
    {
        public static void SendSms(string phoneNumber, string message)                          //在非静态类中定义静态方法；
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
