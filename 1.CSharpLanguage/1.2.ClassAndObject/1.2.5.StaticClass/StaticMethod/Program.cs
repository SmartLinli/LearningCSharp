using static System.Console;														//若事先调用静态类，还可在后续调用时省略静态类，直接调用静态方法；

namespace SmartLin.LearningCSharp.ClassAndObject
{
    class Program
    {
        static void Main()
        {
			Student boy = new Student("3220707000", "张三", Gender.MALE)
			{
				PhoneNumber = "18900001111"
			};
            SmsService.SendSms(boy.PhoneNumber, "请抓紧评教。");						//调用非静态类的静态方法；
            Read();
        }
    }
}
