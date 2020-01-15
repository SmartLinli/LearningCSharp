using System;

namespace SmartLin.LearningCSharp.ClassAndObject
{
	public class Gender
	{
		public static readonly string FEMALE = "女";
		public static readonly string MALE = "男";
	}
    public class Student
    {
		public string Number { get; private set; }
		public string Name { get; private set; }
		public string Gender { get; private set; }
		public string PhoneNumber { get; set; }
		public Student(string number, string name, string gender)                       
		{
			this.Number = number;
			this.Name = name;
			this.Gender = gender;
		}
    }
}
