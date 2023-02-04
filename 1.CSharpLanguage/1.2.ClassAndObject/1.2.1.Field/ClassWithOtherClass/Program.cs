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
            Class im23 = new Class();
            im23.Year = 2023;
            im23.Major = infomationManagement;                                                  //将其它对象赋予该对象的字段；
            Student boy = new Student();
            boy.Number = "3230707001";
            boy.Name = "张三";
            boy.Gender = Gender.MALE;
            boy.BirthDate = new DateTime(2005, 1, 2);
            boy.PhoneNumber = "18900001111";
            boy.Class = im23;                                                                   //将其它对象赋予该对象的字段；
            var info =
                $"新生信息：\n" +
                $"学号：{boy.Number,-15}姓名：{boy.Name}\n" +                                    //访问对象的字段；
                $"性别：{(boy.Gender == Gender.MALE ? "男" : "女"),-14}生日：{boy.BirthDate:D}\n" +
                $"手机：{boy.PhoneNumber}\n" +
                $"班级：{boy.Class.Year}{boy.Class.Major.ShortName}\n" +                         //访问字段中的对象及其字段；
                $"专业：{boy.Class.Major.Name}";                                                 //访问更深层次的对象及其字段；
            WriteLine(info);
            Read();
        }
    }
}
