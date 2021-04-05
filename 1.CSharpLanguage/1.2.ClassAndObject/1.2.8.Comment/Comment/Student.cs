using System;
using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
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
	/// 学生；
	/// </summary>
	public partial class Student
    {
		/// <summary>
		/// 学号；
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
		/// 班级；
		/// </summary>
		public Class Class { get; internal set; }
        /// <summary>
        /// 是否已有班级；
        /// </summary>
        private bool HasClass
        =>  this.Class != null;
        /// <summary>
        /// 介绍；
        /// </summary>
        public void Intro()
        =>	WriteLine
                ($"我叫{this.Name}" +
                 $"{(this.HasClass ? $"，来自{this.Class.ShortName}" : "")}。");
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="gender">性别</param>
        public Student(string number, string name, string gender)                              
        {
            this.Number = number;
            this.Name = name;
            this.Gender = gender;
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="gender">性别</param>
        /// <param name="currentClass">班级</param>
        public Student(string number, string name, string gender, Class currentClass)          
            : this(number, name, gender)
        {
            this.Class = currentClass;
        }
    }
}
