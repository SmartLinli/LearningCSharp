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
		/// 注册；
		/// </summary>
		public override void Register()														//重写基类中的虚方法；
		{
			this.Status = "在读";															//只有派生类实例才能访问基类的受保护成员；
			WriteLine($"本科生{this.Name}当前学籍为“{this.Status}”");
		}
		/// <summary>
		/// 介绍；
		/// </summary>
		public override void Intro()                                                        //重写基类中的虚方法；
		{
			Write($"我叫{this.Name}");
			WriteLine(this.Class == null ?
					"，今天刚入学。"
					: $"，来自{this.Class}。");
		}
		/// <summary>
		/// 构造函数；
		/// </summary>
		/// <param name="number">学号</param>
		/// <param name="name">姓名</param>
		/// <param name="gender">性别</param>
		public Undergraduate(string number, string name, string gender)
			: base(number, name, gender)
		{
			;
		}
		/// <summary>
		/// 构造函数；
		/// </summary>
		/// <param name="number">学号</param>
		/// <param name="name">姓名</param>
		/// <param name="gender">性别</param>
		/// <param name="currentClass">班级</param>
		public Undergraduate(string number, string name, string gender, string currentClass)
			: this(number, name, gender)
		{
			this.Class = currentClass;
		}
	}
}
