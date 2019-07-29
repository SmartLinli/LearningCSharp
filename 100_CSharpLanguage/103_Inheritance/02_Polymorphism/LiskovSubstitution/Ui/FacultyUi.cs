using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
	/// <summary>
	/// 教职工界面；
	/// </summary>
	public static class FacultyUi
	{
		/// <summary>
		/// 显示教职工；
		/// </summary>
		/// <param name="faculty">教职工</param>
		public static void Display(Faculty faculty)
		{
			WriteLine
				($"教职工信息：\n"
				+ $"工号：{faculty.Number,-15}姓名：{faculty.Name}\n"
				+ $"性别：{faculty.Gender,-14}生日：{faculty.BirthDate:D}\n"
				+ $"年龄：{faculty.Age,-15}手机号：{faculty.PhoneNumber}\n"
				+ $"部门：{faculty.Department.Name}\n专长：{faculty.Speciality}");
			faculty.Intro();
			WriteLine("\n");
		}
	}
}
