using System;

namespace SmartLin.LearningCSharp.Inheritance
{
    class Program
    {
        static void Main()
        {
            /*定义教师、本科生、研究生、交换生；*/
            Department collegeOfManagement = new Department("人文与管理学院");
            Faculty msYang = new Faculty("2002010", "杨雪梅", Gender.FEMALE, collegeOfManagement)
            {
                Speciality = "数据仓库与数据挖掘、医学统计"
            };
            Faculty mrLin = new Faculty("2004034", "林立", Gender.MALE, collegeOfManagement)
            {
                Speciality = "面向对象程序设计、数据库"
            };
            Major infomationManagement = new Major("信息管理与信息系统", "信管");
            Class im18 = new Class(infomationManagement, 2018);
            Undergraduate boy = new Undergraduate("3180707000", "张三", Gender.MALE, im18);
            Postgraduate girl = new Postgraduate("2190757001", "李四", Gender.FEMALE, msYang);
            girl.ResearchDirection("数据可视化");
            ExchangeStudent newGuy = new ExchangeStudent("20180531001", "王五", Gender.MALE, im18, "江西中医药大学");
            newGuy.Instructor = msYang;
            /*介绍；注册；转专业；*/
            mrLin.Intro();                                                                          //调用派生类重写的方法；
            Console.WriteLine();
            boy.Intro();
            Console.WriteLine();
            girl.Intro(); 
            Console.WriteLine();
            newGuy.Intro();
            Console.WriteLine();
            boy.Register();
            girl.Register();
            newGuy.Register();
            newGuy.TransferToMajor(null, 2018);                                                     //调用派生类的新方法；
            Console.Read();
        }
    }
}