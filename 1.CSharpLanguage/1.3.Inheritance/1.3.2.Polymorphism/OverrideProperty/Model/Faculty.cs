using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
	/// <summary>
	/// 教职工；
	/// </summary>
	public class Faculty : User
	{
		/// <summary>
		/// 部门；
		/// </summary>
		public string Department { get; private set; }
		/// <summary>
		/// 专长；
		/// </summary>
		public string Speciality { get; set; }
		/// <summary>
		///  构造函数；
		/// </summary>
		/// <param name="number">工号</param>
		/// <param name="name">姓名</param>
		/// <param name="gender">性别</param>
		/// <param name="department">部门</param>
		public Faculty(string number, string name, string gender, string department)
			: base(number, name, gender)                                                    
		{
			this.Department = department;
		}
	}
}
