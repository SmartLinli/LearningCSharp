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
	public class Student : IComparable
	{
		/// <summary>
		/// 学号；
		/// </summary>
		public string Number
		{
			get;
			private set;
		}
		/// <summary>
		/// 姓名；
		/// </summary>
		public string Name
		{
			get;
			set;
		}
		/// <summary>
		/// 性别；
		/// </summary>
		public string Gender
		{
			get;
			set;
		}
		/// <summary>
		/// 生日；
		/// </summary>
		public DateTime? BirthDate
		{
			get;
			set;
		}
		/// <summary>
		/// 年龄；
		/// </summary>
		public int? Age => this.BirthDate == null ?
							null
							: (DateTime.Now.Year - this.BirthDate.Value.Year) as int?;
		private string _PhoneNumber;
		/// <summary>
		/// 电话；
		/// </summary>
		public string PhoneNumber
		{
			get => this._PhoneNumber != null ?
					this._PhoneNumber.Substring(0, 3) + "****" + this._PhoneNumber.Substring(7, 4)
					: null;
			set => this._PhoneNumber = value;
		}
		/// <summary>
		/// 是否与目标对象相等；
		/// </summary>
		/// <param name="obj">对象</param>
		/// <returns>是否相等</returns>
		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (!(obj is Student))
			{
				return false;
			}
			Student otherStudent = obj as Student;
			return this.Number == otherStudent.Number;
		}
		/// <summary>
		/// 获取散列值；
		/// </summary>
		/// <returns>散列值</returns>
		public override int GetHashCode() => this.Number.GetHashCode();
		/// <summary>
		/// 根据学号比较；
		/// </summary>
		/// <param name="obj">对象</param>
		/// <returns>大小</returns>
		public int CompareTo(object obj)
		{
			Student otherStudent = obj as Student;
			int result = this.Number.CompareTo(otherStudent.Number);
			if (result == 0)
			{
				result = this.Name.CompareTo(otherStudent.Name);
			}
			return result;
		}
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
			=> this.BirthDate = birthDate;
	}
}
