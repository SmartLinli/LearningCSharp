﻿using System;
using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    class Program
    {
        static void Main()
        {
            Student boy = new Student();                                                        //声明类的实例（对象），调用new关键字来实例化对象，调用默认构造函数来初始化对象；
            boy.Number = "3180707000";                                                          //向对象的字段赋值；
            boy.Name = "张三";
            boy.Gender = Gender.MALE;
            boy.BirthDate = new DateTime(2000, 1, 2);                                           //直接调用new与构造函数来实例化对象，并赋予其它对象的成员；
            boy.PhoneNumber = "18900001111";
            WriteLine
                ($"新生信息：\n"
                + $"学号：{boy.Number,-15}姓名：{boy.Name}\n"                                     //访问对象的字段；
                + $"性别：{(boy.Gender == Gender.MALE ? "男" : "女"),-14}生日：{boy.BirthDate:D}\n"
                + $"手机：{boy.PhoneNumber}");
            Read();
        }
    }
}
