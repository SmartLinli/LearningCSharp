﻿using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    class Program
    {
        static void Main()
        {
            Major infomationManagement = new Major("信息管理与信息系统", "信管");
            Class im18 = new Class(infomationManagement, 2018);

            Student boy = Student.Create("3180707000", "张三", Gender.MALE, im18);          //调用类的静态方法；
            if (boy == null)
            {
                return;
            }
            boy.Nationality = Nationality.HAN;                                              //调用类的静态字段；
            StudentUi.Display(boy);                                                         //调用静态类的静态方法；

            boy.PhoneNumber = "18900001111";
            SmsService.SendSms(boy.PhoneNumber, "请抓紧评教。");
            Read();
        }
    }
}
