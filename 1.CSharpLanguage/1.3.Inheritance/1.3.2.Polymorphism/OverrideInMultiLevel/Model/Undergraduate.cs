using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
	/// <summary>
	/// 本科生；
	/// </summary>
	public class Undergraduate : Student
	{
		/// <summary>
		/// 班级
		/// </summary>
		public string Class { get; private set; }
		/// <summary>
		/// 介绍；
		/// </summary>
		public override void Intro()                                                        //重写基类中的虚方法；
		{
            WriteLine
                ($"我叫{this.Name}" +
                 $"{(this.Class == null ? "，今天刚入学。" : $"，来自{this.Class}。")}");
		}
		/// <summary>
		/// 构造函数；
		/// </summary>
		/// <param name="number">学号</param>
		/// <param name="name">姓名</param>
		/// <param name="gender">性别</param>
		/// <param name="currentClass">班级</param>
		public Undergraduate(string number, string name, string gender, string currentClass)
			: base(number, name, gender)
		{
			this.Class = currentClass;
		}
	}
}
