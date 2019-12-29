﻿using System;
using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
	class Program
	{
		static void Main()
		{
			Major infomationManagement = new Major("信息管理与信息系统", "信管");          //调用构造函数；
			Class im18 = new Class(infomationManagement, 2018);
			Student boy = new Student("3180707000", "张三", Gender.MALE);                 //调用构造函数；
			boy.BirthDate = new DateTime(2000, 1, 2);
			boy.PhoneNumber = "18900001111";
			boy.Class = im18;
			WriteLine
				($"新生信息：\n"
				+ $"学号：{boy.Number,-15}姓名：{boy.Name}\n"
				+ $"性别：{(boy.Gender == Gender.MALE ? "男" : "女"),-14}生日：{boy.BirthDate:D}\n"
				+ $"年龄：{boy.Age,-15}手机号：{boy.PhoneNumber}\n"
				+ $"班级：{boy.Class.ShortName,-13}专业：{boy.Class.Major.Name}");
			Read();
		}
	}
}
