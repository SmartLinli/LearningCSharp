using System;
using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
	/// <summary>
	/// 性别；
	/// </summary>
	public class Gender
	{
		public static readonly string MALE = "男";
		public static readonly string FEMALE = "女";
	}
	/// <summary>
	/// 用户；
	/// </summary>
	public abstract class User                                                      
    {
        /// <summary>
        /// 编号；
        /// </summary>
        public string Number { get; private set; }                                                       
        /// <summary>
        /// 姓名；
        /// </summary>
        public string Name { get; private set; }
		/// <summary>
		/// 性别；
		/// </summary>
		public string Gender { get; private set; }
        /// <summary>
        /// 构造函数 
        /// </summary>
        /// <param name="number">编号</param>
        /// <param name="name">姓名</param>
        /// <param name="gender">性别</param>
        public User(string number, string name, string gender)                      
        {
            this.Number = number;
            this.Name = name;
            this.Gender = gender;
        }
    }
}
