﻿using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
    class Program
    {
        static void Main()
        {
			Faculty msYang = new Faculty("2002010", "杨雪梅", Gender.FEMALE, "人文与管理学院");
			Undergraduate boy = new Undergraduate("3230707001", "张三", Gender.MALE, "23信管");
			Postgraduate girl = new Postgraduate("2210757002", "李四", Gender.FEMALE, msYang);
			girl.AssignDirection("数据可视化");
			ExchangeStudent newGuy = new ExchangeStudent("20220531005", "王五", Gender.MALE, "22信管", "江西中医药大学");

			boy.Intro();
			WriteLine();
			girl.Intro();
			WriteLine();
			newGuy.Intro();
			Read();
		}
	}
}