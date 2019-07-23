using System;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    public static class StudentUi
    {
        public static void Display(Student student)
        {
            Console.WriteLine
                ("在校生信息：\n学号：{0,-15}姓名：{1}\n性别：{2,-14}民族：{5}\n手机号：{6}\n班级：{7,-13}专业：{8}\n"
                , student.Number
                , student.Name
                , student.Gender == Gender.MALE ? "男" : "女"
                , student.BirthDate
                , student.Age
                , student.Nationality
                , student.PhoneNumber
                , student.Class.ShortName
                , student.Class.Major.Name);
        }
    }
}
