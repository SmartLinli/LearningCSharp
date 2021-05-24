using System;

namespace SmartLin.LearningCSharp.Inheritance
{
    class Program
    {
        static void Main()
        {
            Major infomationManagement = new Major("信息管理与信息系统", "信管");
            Class im18 = new Class(infomationManagement, 2018);
            Student boy = new Student("3180707000", "张三", Gender.MALE, im18);
            boy.BirthDate = new DateTime(2000, 1, 2);
            boy.PhoneNumber = "18900001111";

            Department collegeOfManagement = new Department("人文与管理学院");
            Faculty mrLin = new Faculty("2004034", "林立", Gender.MALE, collegeOfManagement);
            mrLin.BirthDate = new DateTime(1982, 4, 17);

            Display.Student(boy);
            Display.User(boy);                                                          //基类参数同样适用于子类；
            boy.SendSms("请及时评教。");                                                //子类未重写基类的虚方法，将调用基类的虚方法；
            Display.Faculty(mrLin);
            Console.Read();
        }
    }
}