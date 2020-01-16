using static System.Console;

namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
	/// <summary>
	/// 课程界面；
	/// </summary>
	public class CourseUi : IDisplay<Course>                        //实现泛型接口；
	{
		/// <summary>
		/// 显示；
		/// </summary>
		/// <param name="course">课程</param>
		public void Display(Course course)                          //实现泛型接口中的方法；
			=> WriteLine
				("课程信息：\n"
				+ $"编号：{course.Number}\n"
				+ $"名称：{course.Name}\n"
				+ $"学分：{course.Credit}\n");
	}
}
