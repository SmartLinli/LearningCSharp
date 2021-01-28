using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
    class Program
    {
        static void Main()
        {
			Faculty msYang = new Faculty("2002010", "杨雪梅", Gender.FEMALE, "人文与管理学院")
			{
				PhoneNumber = "13322223333"
			}; 
			Undergraduate boy = new Undergraduate("3210707000", "张三", Gender.MALE, "21信管")
			{
				PhoneNumber = "15955559999"
			};

			msYang.SendSms("请抓紧登分。");
			boy.SendSms("请抓紧评教。");
			Read();
		}
	}
}