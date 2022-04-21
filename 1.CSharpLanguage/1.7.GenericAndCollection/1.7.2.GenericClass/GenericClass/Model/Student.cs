using System;

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
	public class Student : IEntity
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
		public DateTime? BirthDate { get; set; }										//基于Nullable<T>的可空类型；
		/// <summary>
		/// 年龄；
		/// </summary>
		public int? Age 
		=>	this.BirthDate == null ?													//基于Nullable<T>的可空类型；
				null
				: (DateTime.Now.Year - this.BirthDate.Value.Year) as int?;				//通过Value属性访问Nullable<T>中的值；返回值还需转为可空类型；			
		/// <summary>
		/// 学籍；
		/// </summary>
		public string Status { get; set; }
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
			this.BirthDate = null;
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
