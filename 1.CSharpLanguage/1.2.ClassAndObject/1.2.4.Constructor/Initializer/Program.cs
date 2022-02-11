﻿using System;
using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
	class Program
    {
        static void Main()
        {
            Major infomationManagement = new Major("信息管理与信息系统", "信管");				
            Class im22 = new Class(infomationManagement, 2022);
            Student boy = new Student("3220707000", "张三", Gender.MALE, im22)				//调用构造函数（重载2）；
            {
                BirthDate = new DateTime(2004, 1, 2),                                       //还可在初始化器中对其余属性进行赋值；
                PhoneNumber = "18900001111"
            } ;
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
