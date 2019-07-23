using System;

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
        public string Number
        {
            get;
            set;
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
            set;
        }
        public void Intro()
        {
            Console.WriteLine
                ("我叫" + this.Name + (this.Class == null ? "" : "，来自" + this.Class.ShortName) + "。");
        }
        private Student(string number, string name, Gender gender)                          //定义私有构造函数（重载1）；
        {
            this.Number = number;
            this.Name = name;
            this.Gender = gender;
        }
        private Student(string number, string name, Gender gender, Class currentClass)      //定义私有构造函数（重载2）；
            : this(number, name, gender)
        {
            this.Class = currentClass;
        }
        public static Student Create(string number, string name, Gender gender)             //在非静态类中定义静态方法；
        {
            if (number.Length == 10)
            {
                Student student = new Student(number, name, gender);                        //调用私有构造函数；
                return student;
            }
            else
            {
                Console.WriteLine("学号长度应为10位！");
                Console.Read();
                return null;
            }
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
