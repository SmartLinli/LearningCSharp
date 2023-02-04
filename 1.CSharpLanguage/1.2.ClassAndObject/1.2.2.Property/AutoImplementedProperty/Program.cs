using System;
using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    class Program
    {
        static void Main()
        {
            Student boy = new Student();
            boy.Number = "3230707001";
            boy.Name = "张三";
            boy.Gender = Gender.MALE;
            boy.BirthDate = new DateTime(2005, 1, 2);
            boy.PhoneNumber = "18900001111";
            var info =
                $"新生信息：\n" +
                 $"学号：{boy.Number,-15}姓名：{boy.Name}\n" +
                 $"性别：{(boy.Gender == Gender.MALE ? "男" : "女"),-14}生日：{boy.BirthDate:D}\n" +
                 $"手机号：{boy.PhoneNumber}\n";
            WriteLine(info);
            Read();
        }
    }
}
