using static System.Console;														//若事先调用静态类，还可在后续调用时省略静态类，直接调用静态方法；

namespace SmartLin.LearningCSharp.ClassAndObject
{
    class Program
    {
        static void Main()
        {
            Major infomationManagement = new Major("信息管理与信息系统", "信管");
            Class im18 = new Class(infomationManagement, 2018);
			Student boy = new Student("3190707000", "张三", Gender.MALE, im18)
			{
				PhoneNumber = "18900001111"
			};
            SmsService.SendSms(boy.PhoneNumber, "请抓紧评教。");						//调用非静态类的静态方法；
            Read();
        }
    }
}
