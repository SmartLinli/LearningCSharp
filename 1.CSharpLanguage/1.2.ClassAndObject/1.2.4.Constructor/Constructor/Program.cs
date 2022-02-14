using System;
using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
	class Program
	{
		static void Main()
		{
			Major infomationManagement = new Major("信息管理与信息系统", "信管");           //调用构造函数；
			Class im22 = new Class(infomationManagement, 2022);                           //调用构造函数；
			Student boy = new Student("3220707000", "张三", Gender.MALE);                 //调用构造函数；
			boy.Class = im22;
			boy.ShowInfo();
			Read();
		}
	}
}
