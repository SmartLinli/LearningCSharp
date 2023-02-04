﻿using System;
using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
	class Program
    {
        static void Main()
        {
            Major infomationManagement = new Major("信息管理与信息系统", "信管");				
            Class im23 = new Class(infomationManagement, 2023);
			Student boy = new Student("3230707000", "张三", Gender.MALE, im23);				//调用构造函数（重载2）；
            boy.ShowInfo();
			Read();
        }
    }
}
