using System;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    public class SmsService                                                                     //定义非静态类；
    {
        public static void SendSms(string phoneNumber, string message)                          //在非静态类中定义静态方法；
        {
            if (phoneNumber != null)
            {
                Console.WriteLine("发送短信至{0}：{1}", phoneNumber, message);
            }
            else
            {
                Console.WriteLine("尚未登记手机号。");
            }
        }
    }
}
