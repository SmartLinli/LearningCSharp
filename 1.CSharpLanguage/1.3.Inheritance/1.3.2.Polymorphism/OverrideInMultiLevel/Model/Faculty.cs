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
		/// 介绍；
		/// </summary>
		public override void Intro()                                                        //重写基类中的虚方法；
		{
			var introduction =
				$"我是{this.Name.Substring(0, 1)}老师" +
				$"{(this.Department == null ? "，今天刚入职" : $"，来自{this.Department}")}" +
				$"专长是{this.Speciality}。";
			WriteLine(introduction);
		}
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
