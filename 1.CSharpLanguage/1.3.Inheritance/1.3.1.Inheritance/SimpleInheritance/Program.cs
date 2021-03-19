using System;
using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
	class Program
	{
		static void Main()
		{
			Student boy = new Student()                                             //派生类调用基类的构造函数；
            {
				Number = "3210707000",												//派生类访问基类的属性；
				Name = "张三",
				Gender = Gender.MALE,
				BirthDate = new DateTime(2003, 1, 2),
				PhoneNumber = "18900001111",
			};
			boy.Intro();                                                            //派生类调用基类的方法； 
			boy.SendSms("请及时评教。");
			boy.Register();															//派生类调用自身的方法；                                                                             //派生类调用基类的方法；
			WriteLine($"{boy.Name}当前学籍：{boy.Status}");							//派生类访问自身的属性；
			Read();
		}
	}
}