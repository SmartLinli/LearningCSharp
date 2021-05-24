using System;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    public enum Gender
    {
        FEMALE = 0,
        MALE = 1
    }
    public class Student                                                    
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
                ("我叫{0}{1}。"
                , this.Name
                , this.Class != null ? "，来自" + this.Class.ShortName : "");
        }
        public Student(string number, string name, Gender gender)                       //定义构造函数（重载1）；编译器将不再自动提供默认的（无参数）构造函数；
        {
            this.Number = number;
            this.Name = name;
            this.Gender = gender;
        }
        public Student(string number, string name, Gender gender, Class currentClass)   //定义构造函数（重载2）；
            : this(number, name, gender)                                                //构造函数初始化器，用于调用参数匹配的其它构造函数；
        {                                                                               //先执行构造函数初始化器调用的其它构造函数，后执行本构造函数；
            this.Class = currentClass;
        }
    }
}
