using System;
using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
	class Program
    {
        static void Main()
        {
			Faculty mrLin = new Faculty("2004034", "林立", Gender.MALE)
			{
				BirthDate = new DateTime(1982, 4, 17),
				PhoneNumber = "13599995555",
				Department = "人文与管理学院",
			};
			Student boy = new Student("3190707000", "张三", Gender.MALE)
			{
				BirthDate = new DateTime(2000, 1, 2),
				PhoneNumber = "18900001111",
				Class = "19信管",
			};
			mrLin.Intro();                                                          
			WriteLine($"目前任教于{mrLin.Department}。\n");
			mrLin.SendSms("请及时阅卷。");											                                                                              
			boy.Intro();
			WriteLine($"目前就读于{boy.Class}。\n");                        
            boy.SendSms("请及时评教。");            
            Read();
        }
    }
}