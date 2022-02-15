using System;
using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
	class Program
	{
		static void Main()
		{
			Student boy = new Student()                                             
            {
				Number = "3220707000",												//派生类访问基类的属性；
				Name = "张三",
				Gender = Gender.MALE,
				BirthDate = new DateTime(2004, 1, 2),
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