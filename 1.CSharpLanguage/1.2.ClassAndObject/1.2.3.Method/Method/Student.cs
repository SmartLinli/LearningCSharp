using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
	/// <summary>
	/// 学生；
	/// </summary>
	public class Student
	{
		/// <summary>
		/// 姓名；
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// 班级；
		/// </summary>
		public string Class { get; set; }                            
		/// <summary>
		/// 是否有班级；
		/// </summary>
		private bool HasClass                                               
		=>	this.Class != null;
		/// <summary>
		/// 介绍；
		/// </summary>
        public void Intro()                                                 //定义公有方法；
        =>	WriteLine														//通过表达式体，定义只有单语句的方法；
				($"我叫{this.Name}"
				+ $"{(this.HasClass ? "，来自" + this.Class : "")}。");
    }
}
