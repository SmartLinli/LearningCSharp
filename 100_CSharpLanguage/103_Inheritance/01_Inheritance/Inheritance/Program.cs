using System;

namespace SmartLin.LearningCSharp.Inheritance
{
    class Program
    {
        static void Main()
        {
            /*定义教师、本科生、研究生；*/
            Department collegeOfManagement = new Department("人文与管理学院");
            Faculty msYang = new Faculty("2002010", "杨雪梅", Gender.FEMALE, collegeOfManagement)
            {
                BirthDate = new DateTime(1975, 12, 1),                                                  //派生类调用基类的属性；                             
                Speciality = "数据仓库与数据挖掘、医学统计"
            };
            Faculty mrLin = new Faculty("2004034", "林立", Gender.MALE, collegeOfManagement)
            {
                BirthDate = new DateTime(1982, 4, 17),
                Speciality = "面向对象程序设计、数据库"
            };
            Major infomationManagement = new Major("信息管理与信息系统", "信管");
            Class im18 = new Class(infomationManagement, 2018);
            Undergraduate boy = new Undergraduate("3180707000", "张三", Gender.MALE, im18)
            {
                BirthDate = new DateTime(2000, 1, 2),
                PhoneNumber = "18900001111",
                Instructor = mrLin
            };
            Postgraduate girl = new Postgraduate("2190757001", "李四", Gender.FEMALE, msYang);
            girl.ResearchDirection("数据可视化");
            /*介绍；注册；发送短信；*/
            msYang.Intro();                                                                             //派生类调用基类的方法； 
            mrLin.Intro();
            boy.Register();                                                                             //派生类调用基类的方法；
            girl.Register();
            boy.SendSms("请及时评教。");                                                                //派生类调用基类的方法；                                                                                
            girl.SendSms("请及时评教。");            
            Console.Read();
        }
    }
}