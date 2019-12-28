using System;
using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
	class Program
    {
        static void Main()
        {
			Faculty msYang = new Faculty("2002010", "杨雪梅", Gender.FEMALE)
			{
				BirthDate = new DateTime(1975, 12, 1),
				Department = "人文与管理学院",
				Speciality = "数据仓库与数据挖掘、医学统计"
			};
			Faculty mrLin = new Faculty("2004034", "林立", Gender.MALE)
			{
				BirthDate = new DateTime(1982, 4, 17),
				PhoneNumber = "13599995555",
				Department = "人文与管理学院",
				Speciality = "面向对象程序设计、数据库",
			};
			Undergraduate boy = new Undergraduate("3190707000", "张三", Gender.MALE)
			{
				BirthDate = new DateTime(2000, 1, 2),
				PhoneNumber = "18900001111",
				Class = "19信管",
				Instructor = mrLin                                                                      //派生类访问自身的属性；
			};
			Postgraduate girl = new Postgraduate("2190757001", "李四", Gender.FEMALE)
			{
				Supervisor = msYang
			};
			msYang.Intro();                                                                             //派生类调用基类的方法； 
            mrLin.Intro();
			boy.Intro();
			girl.Intro();
            mrLin.SendSms("请及时阅卷。");																//派生类调用基类的方法；                                                                                
            boy.SendSms("请及时评教。");            
			boy.Register();                                                                             //派生类调用基类的方法；
            girl.Register();
            girl.AssignDirection("数据可视化");                                                          //派生类调用自身的方法；
			Read();
        }
    }
}