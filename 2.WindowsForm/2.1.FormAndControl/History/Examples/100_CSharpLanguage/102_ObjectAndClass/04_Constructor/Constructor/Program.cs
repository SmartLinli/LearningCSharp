using System;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    class Program
    {
        static void Main()
        {
            Major infomationManagement = new Major("信息管理与信息系统", "信管");           //调用构造函数；
            Class im18 = new Class(infomationManagement, 2018);
            Student boy = new Student("3180707000", "张三", Gender.MALE, im18)              //调用构造函数（重载2）；
            {
                BirthDate = new DateTime(2000, 1, 2),                                       //还可在初始化器中对属性进行赋值；
                PhoneNumber = "18900001111"
            } ;             
            Console.WriteLine
                ("新生信息：\n学号：{0,-15}姓名：{1}\n性别：{2,-14}生日：{3:D}\n年龄：{4,-15}手机号：{5}\n班级：{6,-13}专业：{7}"
                , boy.Number
                , boy.Name
                , boy.Gender == Gender.MALE ? "男" : "女"
                , boy.BirthDate
                , boy.Age
                , boy.PhoneNumber
                , boy.Class.ShortName
                , boy.Class.Major.Name);
            Console.Read();
        }
    }
}
