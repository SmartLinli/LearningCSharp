using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Major infomationManagement = new Major("信息管理与信息系统", "信管");
            Class im18 = new Class(2018, infomationManagement);
            Student student = new Student("3180707001", "张三", Gender.Male, new DateTime(2000, 5, 5), im18);
            student.PhoneNumber = "18088080088";
            student.Intro();
            student.SendSms("");
            student.TransferToMajor(new Major("针灸学", "针灸"));
            student.Intro();
            Console.Read();
        }
    }
}
