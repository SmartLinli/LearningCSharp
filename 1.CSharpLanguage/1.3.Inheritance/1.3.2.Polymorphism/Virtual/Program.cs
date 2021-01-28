using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
    class Program
    {
        static void Main()
        {
			Faculty msYang = new Faculty("2002010", "杨雪梅", Gender.FEMALE)
			{
				PhoneNumber = "13322223333"
			}; 
			Student boy = new Student("3210707000", "张三", Gender.MALE)
			{
				PhoneNumber = "15955559999"
			};

			msYang.Intro();                                                                         //调用基类的虚方法；
			boy.Intro();
			msYang.SendSms("请抓紧登分。");                                                           
			boy.SendSms("请抓紧评教。");
			Read();
		}
	}
}