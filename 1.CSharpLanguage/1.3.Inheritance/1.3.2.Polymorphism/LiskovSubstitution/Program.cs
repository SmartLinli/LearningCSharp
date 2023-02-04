using System;
using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
	class Program
	{
		static void Main()
		{
			/*定义教师、本科生、研究生、交换生；*/
			Faculty msYang = new Faculty("2002010", "杨雪梅", Gender.FEMALE, "人文与管理学院")
			{
				BirthDate = new DateTime(1975, 12, 1),
				Speciality = "数据仓库与数据挖掘、医学统计"
			};
			Undergraduate boy = new Undergraduate("3230707001", "张三", Gender.MALE, "23信管")
			{
				BirthDate = new DateTime(2005, 1, 2),
				PhoneNumber = "18900001111",
			};
			Postgraduate girl = new Postgraduate("2210757002", "李四", Gender.FEMALE, msYang);
			girl.AssignDirection("数据可视化");
			ExchangeStudent newGuy = new ExchangeStudent("20220531005", "王五", Gender.MALE, "22信管", "江西中医药大学")
			{
				Instructor = msYang
			};
			/*显示；介绍所有用户；批量注册；*/
			UserUi.Display(boy);
			StudentUi.Display(boy);
			UndergraduateUi.Display(newGuy);
			User[] users = { msYang, boy, girl, newGuy };
			UserService.IntroduceAll(users);
			WriteLine();
			StudentService.RegisterAll(boy, girl, newGuy);
			Read();
		}
	}
}