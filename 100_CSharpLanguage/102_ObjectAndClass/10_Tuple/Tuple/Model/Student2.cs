using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject.Model                                  
{
	/// <summary>
	/// 学生；
	/// </summary>
	public partial class Student                                                                                                       
	{
		/// <summary>
		/// 电子邮件地址；
		/// </summary>
		public string Email
		{
			get;
			set;
		}
		/// <summary>
		/// 创建；
		/// </summary>
		/// <param name="number">学号</param>
		/// <param name="name">姓名</param>
		/// <param name="gender">性别</param>
		/// <returns>学生</returns>
		public static Student Create(string number, string name, string gender)         
		{
			if (number.Length != 10)
			{
				WriteLine("学号长度应为10位！");
				return null;
			}
			else
			{
				Student student = new Student(number, name, gender);                    
				return student;
			}
		}
		/// <summary>
		/// 创建；
		/// </summary>
		/// <param name="number">学号</param>
		/// <param name="name">姓名</param>
		/// <param name="gender">性别</param>
		/// <param name="currentClass">班级</param>
		/// <returns>学生</returns>
		public static Student Create(string number, string name, string gender, Class currentClass)
		{
			Student student = Create(number, name, gender);                             
			if (student != null)
			{
				student.Class = currentClass;
			}
			return student;
		}
	}
}
