using System;
using static System.Console;
namespace SmartLin.LearningCSharp.ClassAndObject
{
    class Program
    {
        static void Main()
        {
            Student boy = new Student();
            boy.Number = "3220707001";												//向对象的属性赋值；
            boy.Name = "张三";
            boy.Gender = Gender.MALE;
            boy.BirthDate = new DateTime(2004, 1, 2);
            boy.PhoneNumber = "18900001111";
			WriteLine
				($"新生信息：\n"
				+ $"学号：{boy.Number,-15}姓名：{boy.Name}\n"						    //访问对象的属性；                                 
				+ $"性别：{(boy.Gender == Gender.MALE ? "男" : "女"),-14}生日：{boy.BirthDate:D}\n"
				+ $"手机：{boy.PhoneNumber}\n");                                              
			Read();
        }
    }
}
