using System;
using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
	/// <summary>
	/// 性别；
	/// </summary>
	public class Gender
	{
		public static readonly string FEMALE = "女";
		public static readonly string MALE = "男";
	}
	/// <summary>
	/// 民族；
	/// </summary>
	public class Nationality
	{
		public static readonly string HAN = "汉族";
		public static readonly string QIANG = "羌族";
		public static readonly string SHE = "畲族";
	}
	/// <summary>
	/// 学生；
	/// </summary>
	public class Student
	{
		public string Number { get; private set; }
		public string Name { get; private set; }
		public string Gender { get; private set; }
		public string Nationality { get; set; }
		public DateTime BirthDate { get; set; }
		public int Age
		=> DateTime.Now.Year - this.BirthDate.Year;
		public string PhoneNumber { get; set; }
		public Class Class { get; private set; }
		private Student(string number, string name, string gender)							//将构造函数定义为私有；                   
		{
			this.Number = number;
			this.Name = name;
			this.Gender = gender;
		}
		private Student(string number, string name, string gender, Class currentClass)   
			: this(number, name, gender)                                                
		{                                                                               
			this.Class = currentClass;
		}
		/// <summary>
		/// 创建；
		/// </summary>
		/// <param name="number">学号</param>
		/// <param name="name">姓名</param>
		/// <param name="gender">性别</param>
		/// <returns>学生</returns>
        public static Student Create(string number, string name, string gender)				//在非静态类中定义静态方法；     
        {																					//无需实例化非静态类，即可调用其静态方法，从而实现创造行为模式等设计模式；
            if (number.Length != 10)
            {
				WriteLine("学号长度应为10位！");
				Read();
				return null;
			}
			Student student = new Student(number, name, gender);							//调用私有构造函数；
			return student;
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
            Student student = Create(number, name, gender);                                 //调用本类的静态方法；
            if (student != null)
            {
                student.Class = currentClass;
            }
            return student;
        }
    }
}
