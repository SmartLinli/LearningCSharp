using System;

namespace SmartLin.LearningCSharp.Inheritance
{
    /// <summary>
    /// 本科生界面；
    /// </summary>
    public static class UndergraduateUi
    {
        /// <summary>
        /// 显示本科生；
        /// </summary>
        /// <param name="student">本科生</param>
        public static void Display(Undergraduate student)
        {
            Console.WriteLine
                ("本科生信息：\n学号：{0,-15}姓名：{1}\n性别：{2,-14}生日：{3:D}\n年龄：{4,-15}手机号：{5}\n班级：{6,-13}专业：{7}\n本科生导师：{8}"
                , student.Number
                , student.Name
                , student.Gender == Gender.MALE ? "男" : "女"
                , student.BirthDate
                , student.Age
                , student.PhoneNumber
                , student.Class.ShortName
                , student.Class.Major.Name
                , student.Instructor.Name);
            student.Intro();
            Console.WriteLine("\n");
        }
    }
}
