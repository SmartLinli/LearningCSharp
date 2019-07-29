using static System.Console;

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
			WriteLine
				($"本科生信息：\n学号：{student.Number,-15}姓名：{student.Name}\n"
				+ $"性别：{student.Gender,-14}生日：{student.BirthDate:D}\n"
				+ $"年龄：{student.Age,-15}手机号：{student.PhoneNumber}\n"
				+ $"班级：{student.Class.ShortName,-13}专业：{student.Class.Major.Name}\n"
				+ $"本科生导师：{student.Instructor.Name}");
			student.Intro();
			WriteLine("\n");
		}
	}
}
