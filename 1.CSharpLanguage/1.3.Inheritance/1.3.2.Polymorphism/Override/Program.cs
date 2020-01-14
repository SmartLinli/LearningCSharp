using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
    class Program
    {
        static void Main()
        {
			Faculty msYang = new Faculty("2002010", "杨雪梅", Gender.FEMALE, "人文与管理学院")
			{
				PhoneNumber = "13322223333",
				Speciality = "数据仓库与数据挖掘、医学统计"
			};
			Undergraduate boy = new Undergraduate("3190707000", "张三", Gender.MALE, "19信管")
			{
				PhoneNumber = "15955559999"
			};
			Postgraduate girl = new Postgraduate("2190757001", "李四", Gender.FEMALE, msYang);
            girl.AssignDirection("数据可视化");
            ExchangeStudent newGuy = new ExchangeStudent("20190531001", "王五", Gender.MALE, "19信管", "江西中医药大学");

			msYang.Intro();                                                                          //调用派生类重写的方法；
            boy.Intro();
            girl.Intro(); 
            newGuy.Intro();
			msYang.SendSms("请抓紧登分。");
			boy.SendSms("请抓紧评教。");
            boy.Register();
            girl.Register();
            newGuy.Register();
            Read();
        }
    }
}