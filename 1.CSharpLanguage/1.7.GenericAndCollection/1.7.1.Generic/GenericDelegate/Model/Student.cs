﻿using System;

namespace SmartLin.LearningCSharp.GenericTypeAndCollection
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
		public string Gender { get; set; }
		/// <summary>
		/// 生日；
		/// </summary>
		public DateTime BirthDate { get; set; }
		/// <summary>
		/// 年龄；
		/// </summary>
		public int Age => DateTime.Now.Year - this.BirthDate.Year;
		/// <summary>
		/// 电话；
		/// </summary>
		public string PhoneNumber { get; set; }
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
		/// <param name="birthDate">生日</param>
		public Student(string number, string name, string gender, DateTime birthDate)
			: this(number, name, gender)
		=>	this.BirthDate = birthDate;
	}
}
