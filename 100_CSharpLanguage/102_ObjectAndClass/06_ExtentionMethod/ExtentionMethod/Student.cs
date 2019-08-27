using System;
using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
	public class Gender
	{
		public static readonly string MALE = "男";
		public static readonly string FEMALE = "女";
	}
	public partial class Student
    {
        public string Number
        {
            get;
            internal set;
        }
        public string Name
        {
            get;
            set;
        }
        public string Gender
        {
            get;
            set;
        }
        public string Nationality
        {
            get;
            set;
        }
        public DateTime BirthDate
        {
            get;
            set;
        }
        public int Age
        {
            get
            {
                return DateTime.Now.Year - this.BirthDate.Year;
            }
        }
        private string _PhoneNumber;
        public string PhoneNumber
        {
            get
            {
                if (this._PhoneNumber != null)
                {
                    return this._PhoneNumber.Substring(0, 3) + "****" + this._PhoneNumber.Substring(7, 4);
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this._PhoneNumber = value;
            }
        }
        public Class Class
        {
            get;
            internal set;
        }
        private bool HasClass                                                               //定义私有属性；
        {
            get
            {
                return this.Class != null;
            }
        }
        public void Intro()                                                                 //定义公有方法；
        {
			WriteLine
				($"我叫{this.Name}"
				+ $"{(this.Class == null ? "" : "，来自" + this.Class.ShortName + "。")}");
        }
        private Student(string number, string name, string gender)                          //定义私有构造函数（重载1）；
        {
            this.Number = number;
            this.Name = name;
            this.Gender = gender;
        }
        private Student(string number, string name, string gender, Class currentClass)      //定义私有构造函数（重载2）；
            : this(number, name, gender)
        {
            this.Class = currentClass;
        }
        public static Student Create(string number, string name, string gender)             //定义静态方法；
        {
			if (number.Length != 10)
			{
				WriteLine("学号长度应为10位！");
				return null;
			}
			Student student = new Student(number, name, gender);                            //调用私有构造函数；
			return student;
		}
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
