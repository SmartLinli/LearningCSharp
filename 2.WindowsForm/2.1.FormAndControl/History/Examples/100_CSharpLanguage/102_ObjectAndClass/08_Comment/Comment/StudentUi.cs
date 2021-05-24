using System;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    /// <summary>
    /// 学生界面；
    /// </summary>
    public static class StudentUi
    {
        /// <summary>
        /// 显示；
        /// </summary>
        /// <param name="student">学生</param>
        public static void Display(Student student)
        {
            Console.WriteLine
                ("在校生信息：\n学号：{0,-15}姓名：{1}\n性别：{2,-14}手机号：{5}\n班级：{6,-13}专业：{7}\n"
                , student.Number
                , student.Name
                , student.Gender == Gender.MALE ? "男" : "女"
                , student.BirthDate
                , student.Age
                , student.PhoneNumber
                , student.Class.ShortName
                , student.Class.Major.Name);
        }
    }
}
