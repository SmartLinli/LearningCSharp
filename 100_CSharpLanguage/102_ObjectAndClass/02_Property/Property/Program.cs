using System;

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
            im18.Year = 2018;
            im18.Major = infomationManagement;                                                  
            Student boy = new Student();
            boy.Number = "3180707000";
            boy.Number = "3180707001";                                                          //已有学号无法更改；
            boy.Name = "张三";
            boy.Gender = Gender.MALE;
            boy.BirthDate = new DateTime(2000, 1, 2);
            boy.PhoneNumber = "18900001111";
            boy.Class = im18;
            Console.WriteLine
                ("新生信息：\n学号：{0,-15}姓名：{1}\n性别：{2,-14}生日：{3:D}\n年龄：{4,-15}手机号：{5}\n班级：{6,-13}专业：{7}"
                , boy.Number
                , boy.Name
                , boy.Gender == Gender.MALE ? "男" : "女"
                , boy.BirthDate
                , boy.Age
                , boy.PhoneNumber
                , boy.Class.ShortName                                                                                                        
                , boy.Class.Major.Name);
            Console.Read();
        }
    }
}
