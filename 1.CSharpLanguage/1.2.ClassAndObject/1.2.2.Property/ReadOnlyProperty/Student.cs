using System;

namespace SmartLin.LearningCSharp.ClassAndObject
{
	public enum Gender
	{
		FEMALE,
		MALE
	}
	public class Student
	{
		public string Number;
		public string Name;
		public Gender Gender;
		public DateTime BirthDate;
		public int Age
		{
			get
			{
				return DateTime.Now.Year - this.BirthDate.Year;
			}                                                       //省略set访问器，可实现只读属性；
		}
		public string PhoneNumber;
		public Class Class;               
	}
}
