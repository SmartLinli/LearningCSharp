using System;
using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
	class Program
    {
        static void Main()
        {
			Student boy = new Student("3220707001", "张三", Gender.MALE);
			boy.Intro();
			boy.SendSms("请及时评教。");
			Read();
		}
	}
}