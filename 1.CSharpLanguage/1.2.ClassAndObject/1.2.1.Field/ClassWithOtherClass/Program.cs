using System;
using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    class Program
    {
        static void Main()
        {
            Major infomationManagement = new Major();
            infomationManagement.Name = "信息管理与信息系统";
            infomationManagement.ShortName = "信管";
            Class im18 = new Class();
            im18.Year = 2019;
            im18.Major = infomationManagement;                                                  //将其它对象赋予该对象的字段；
            Student boy = new Student();
            boy.Number = "3190707001";
            boy.Name = "张三";
            boy.Gender = Gender.MALE;
            boy.BirthDate = new DateTime(2000, 1, 2);
            boy.PhoneNumber = "18900001111";
            boy.Class = im18;                                                                   //将其它对象赋予该对象的字段；
            WriteLine
                ($"新生信息：\n"
                + $"学号：{boy.Number,-15}姓名：{boy.Name}\n"                                    //访问对象的字段；
                + $"性别：{(boy.Gender == Gender.MALE ? "男" : "女"),-14}生日：{boy.BirthDate:D}\n"
                + $"手机：{boy.PhoneNumber}\n"
                + $"班级：{boy.Class.Year}{boy.Class.Major.ShortName}\n"                         //访问字段中的对象及其字段；
                + $"专业：{boy.Class.Major.Name}");                                              //访问更深层次的对象及其字段；
            Read();
        }
    }
}
