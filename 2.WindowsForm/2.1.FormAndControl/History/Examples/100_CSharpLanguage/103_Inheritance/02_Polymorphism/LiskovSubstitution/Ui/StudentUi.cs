using System;

namespace SmartLin.LearningCSharp.Inheritance
{
    /// <summary>
    /// 学生界面；
    /// </summary>
    public static class StudentUi
    {
        /// <summary>
        /// 显示学生；
        /// </summary>
        /// <param name="student">学生</param>
        public static void Display(Student student)
        {
            Console.WriteLine
                ("在校生信息：\n学号：{0,-15}姓名：{1}\n性别：{2,-14}生日：{3:D}\n年龄：{4,-15}手机号：{5}\n学籍：{6}"
                , student.Number                                                                //派生类的对象可访问基类与派生类成员；
                , student.Name
                , student.Gender == Gender.MALE ? "男" : "女"
                , student.BirthDate
                , student.Age
                , student.PhoneNumber
                , student.Status);
            student.Intro();
            Console.WriteLine("\n");
        }
    }
}
