﻿using static System.Console;

namespace SmartLin.LearningCSharp.DelegateAndEvent
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
		private static void Display(Student student)
		=>  WriteLine
				($"学号：{student.Number,-15}姓名：{student.Name}\n"
				+ $"性别：{student.Gender,-14}生日：{student.BirthDate:D}\n"
				+ $"年龄：{student.Age,-15}手机号：{student.PhoneNumber}");
        /// <summary>
        /// 显示学生；
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="student">学生</param>
        public static void Display(string title, Student student)
        {
            if (student == null)
                return;
            WriteLine($"{title}");
            Display(student);
        }
		/// <summary>
		/// 显示多名学生；
		/// </summary>
		/// <param name="students">多名学生</param>
		private static void Display(Student[] students)
		{
			int i = 1;
			foreach (Student student in students)
			{
				Display($"{i}", student);
				i++;
			}
		}
		/// <summary>
		/// 显示多名学生；
		/// </summary>
		/// <param name="title">标题</param>
		/// <param name="students">多名学生</param>
		public static void Display(string title, Student[] students)
		{
			WriteLine($"\n{title}：");
			Display(students);
		}
	}
}
