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
            Class im21 = new Class();
            im21.Year = 2021;
            im21.Major = infomationManagement;                                                  
            Student boy = new Student();
            boy.Number = "3210707001";
            boy.Name = "张三";
            boy.Gender = Gender.MALE;
            boy.BirthDate = new DateTime(2003, 1, 2);
            boy.PhoneNumber = "18900001111";
            boy.Class = im21;
			WriteLine
				($"新生信息：\n"
				+ $"学号：{boy.Number,-15}姓名：{boy.Name}\n"
				+ $"性别：{(boy.Gender == Gender.MALE ? "男" : "女"),-14}生日：{boy.BirthDate:D}\n"
				+ $"年龄：{boy.Age,-15}手机号：{boy.PhoneNumber}\n"
				+ $"班级：{boy.Class.ShortName,-13}专业：{boy.Class.Major.Name}");
            Read();
        }
    }
}
