﻿using static System.Console;

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
			WriteLine
				($"在校生信息：\n"
				+ $"学号：{student.Number,-15}姓名：{student.Name}\n"
				+ $"性别：{(student.Gender == Gender.MALE ? "男" : "女"),-14}生日：{student.BirthDate:D}\n"
				+ $"年龄：{student.Age,-15}手机号：{student.PhoneNumber}\n"
				+ $"班级：{student.Class.ShortName,-13}专业：{student.Class.Major.Name}");
		}
	}
}
