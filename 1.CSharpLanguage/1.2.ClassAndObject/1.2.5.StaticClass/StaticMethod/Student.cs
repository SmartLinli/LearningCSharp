using System;

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
		=>	DateTime.Now.Year - this.BirthDate.Year;
		public string PhoneNumber { get; set; }
		public Class Class { get; private set; }
		public Student(string number, string name, string gender)                       
		{
			this.Number = number;
			this.Name = name;
			this.Gender = gender;
		}
		public Student(string number, string name, string gender, Class currentClass)   
			: this(number, name, gender)                                                
		{                                                                               
			this.Class = currentClass;
		}
    }
}
