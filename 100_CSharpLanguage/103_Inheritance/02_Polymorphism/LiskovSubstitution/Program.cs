using System;
using static System.Console;

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
                    BirthDate = new DateTime(1975, 12, 1),
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
            ExchangeStudent newGuy = new ExchangeStudent("20180531001", "王五", Gender.MALE, im18, "江西中医药大学");
            newGuy.Instructor = msYang;
            /*显示；介绍所有用户；批量注册；*/
            UserUi.Display(boy);                                                                        //基类的类型同样适用于派生类；
            StudentUi.Display(boy);
            UndergraduateUi.Display(newGuy);
            UserService.IntroduceAll(new User[] { msYang, mrLin, boy, girl, newGuy });                  //基类的类型同样适用于派生类；
            WriteLine();
            StudentService.RegisterAll(new Student[] { boy, girl, newGuy });
            Read();
        }
    }
}