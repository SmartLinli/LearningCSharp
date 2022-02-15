using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
    /// <summary>
    /// 学生；
    /// </summary>
    public class Student : User
    {
		/// <summary>
		/// 学籍；
		/// </summary>
		public string Status { get; set; }                    
		/// <summary>
		/// 介绍；
		/// </summary>
		public override void Intro()                                                        //重写基类中的虚方法；
		{
			WriteLine($"我叫{this.Name}，是福建中医药大学在校生。");
		}
		/// <summary>
		/// 构造函数；
		/// </summary>
		/// <param name="number">学号</param>
		/// <param name="name">姓名</param>
		/// <param name="gender">性别</param>
		public Student(string number, string name, string gender)
            : base(number, name, gender)
        {
            ;
        }
    }
}
