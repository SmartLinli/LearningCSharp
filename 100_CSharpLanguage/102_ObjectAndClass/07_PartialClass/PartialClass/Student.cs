using System;
using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
	public class Gender
	{
		public static readonly string MALE = "男";
		public static readonly string FEMALE = "女";
	}
	public partial class Student                                                    //定义部分类；                                                  
    {
        public string Number                                                
        {
            get;
            private set;
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
            private set;                                                    
        }
        public void Intro()                                                 
        {
			WriteLine
				($"我叫{this.Name}"
				+ $"{(this.Class == null ? "" : "，来自" + this.Class.ShortName + "。")}");
		}
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
