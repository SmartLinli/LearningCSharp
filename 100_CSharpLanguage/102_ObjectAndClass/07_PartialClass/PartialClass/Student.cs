using System;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    public enum Gender
    {
        FEMALE = 0,
        MALE = 1
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
        public Gender Gender
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
            Console.WriteLine
                ("我叫" + this.Name + (this.Class == null ? "" : "，来自" + this.Class.ShortName) + "。");
        }
        public Student(string number, string name, Gender gender)                       
        {
            this.Number = number;
            this.Name = name;
            this.Gender = gender;
        }
        public Student(string number, string name, Gender gender, Class currentClass)  
            : this(number, name, gender)                                               
        {                                                                              
            this.Class = currentClass;
        }
    }
}
