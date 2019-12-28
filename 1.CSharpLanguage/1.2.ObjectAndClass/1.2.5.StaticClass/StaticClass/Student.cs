using System;
using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    public enum Gender
    {
        FEMALE = 0,
        MALE = 1
    }
    public class Nationality
    {
        public static readonly string HAN = "汉族";                                         //定义静态只读字段并赋值；
        public static readonly string QIANG = "羌族";
        public static readonly string SHE = "畲族";
    }
    public class Student
    {
		public string Number { get; private set; }
		public string Name { get; private set; }
		public Gender Gender { get; private set; }
		public string Nationality { get; set; }
		public DateTime BirthDate { get; set; }
		public int Age
		=>	DateTime.Now.Year - this.BirthDate.Year;
		public string PhoneNumber { get; set; }
		public Class Class { get; private set; }
		private Student(string number, string name, Gender gender)                       
		{
			this.Number = number;
			this.Name = name;
			this.Gender = gender;
		}
		private Student(string number, string name, Gender gender, Class currentClass)   
			: this(number, name, gender)                                                
		{                                                                               
			this.Class = currentClass;
		}
        public static Student Create(string number, string name, Gender gender)         
        {
            if (number.Length != 10)
            {
				WriteLine("学号长度应为10位！");
				Read();
				return null;
			}
			Student student = new Student(number, name, gender);							//调用私有构造函数；
			return student;
        }
        public static Student Create(string number, string name, Gender gender, Class currentClass)
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
