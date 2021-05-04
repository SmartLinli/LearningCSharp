using static System.Console;

namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
	/// <summary>
	/// 学生界面；
	/// </summary>
	public class StudentUi : IDisplay<Student>                              //实现泛型接口；
	{
		/// <summary>
		/// 显示；
		/// </summary>
		/// <param name="student">学生</param>
		public void Display(Student student)                                //实现泛型接口中的方法；
		=>  WriteLine
				("在校生信息：\n" +
                $"学号：{student.Number,-15}姓名：{student.Name,-15}性别：{student.Gender}");
	}
}
