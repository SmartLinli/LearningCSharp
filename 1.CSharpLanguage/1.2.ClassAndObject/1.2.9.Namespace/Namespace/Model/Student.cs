using System;

namespace SmartLin.LearningCSharp.ClassAndObject.Model                                      //向文件夹添加的类，所在命名空间默认为项目默认命名空间+文件夹路径；
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
		/// 生日；
		/// </summary>
		public DateTime BirthDate { get; set; }
		/// <summary>
		/// 年龄；
		/// </summary>
		public int Age
		=>	DateTime.Now.Year - this.BirthDate.Year;
		/// <summary>
		/// 手机号；
		/// </summary>
		public string PhoneNumber { get; set; }
		/// <summary>
		/// 班级；
		/// </summary>
		public Class Class { get; internal set; }
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
