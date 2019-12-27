using System;
using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
	class Program
    {
        static void Main()
        {
            /*定义教师、本科生、研究生；*/
            Faculty msYang = new Faculty("2002010", "杨雪梅", Gender.FEMALE, "人文与管理学院")
            {
                BirthDate = new DateTime(1975, 12, 1),                                                  //派生类访问基类的属性；                             
                Speciality = "数据仓库与数据挖掘、医学统计"
            };
			Faculty mrLin = new Faculty("2004034", "林立", Gender.MALE, "人文与管理学院")
			{
				BirthDate = new DateTime(1982, 4, 17),
				Speciality = "面向对象程序设计、数据库",
				PhoneNumber = "13599995555"
			};
            Undergraduate boy = new Undergraduate("3180707000", "张三", Gender.MALE, "18信管")
            {
                BirthDate = new DateTime(2000, 1, 2),
                PhoneNumber = "18900001111",
                Instructor = mrLin                                                                      //派生类访问自身的属性；
			};
            Postgraduate girl = new Postgraduate("2190757001", "李四", Gender.FEMALE, msYang);
            girl.AssignDirection("数据可视化");                                                          //派生类调用自身的方法；
			/*介绍；注册；发送短信；*/
			msYang.Intro();                                                                             //派生类调用基类的方法； 
            mrLin.Intro();
			boy.Intro();
			girl.Intro();
			boy.Register();                                                                             //派生类调用基类的方法；
            girl.Register();
            mrLin.SendSms("请及时阅卷。");																//派生类调用基类的方法；                                                                                
            boy.SendSms("请及时评教。");            
            Read();
        }
    }
}