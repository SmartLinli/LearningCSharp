using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
	/// <summary>
	/// 研究生界面；
	/// </summary>
	public static class PostgraduateUi
	{
		/// <summary>
		/// 显示研究生；
		/// </summary>
		/// <param name="student">研究生</param>
		public static void Display(Postgraduate student)
		{
			WriteLine
				($"研究生信息：\n"
				+ $"学号：{student.Number,-15}姓名：{student.Name}\n"
				+ $"性别：{ student.Gender,-14} 生日：{ student.BirthDate:D}\n"
				+ $"年龄：{student.Age,-15}手机号：{student.PhoneNumber}\n"
				+ $"导师：{student.Supervisor.Name,-12}方向：{student.Direction}");
			student.Intro();
			WriteLine("\n");
		}
	}
}
