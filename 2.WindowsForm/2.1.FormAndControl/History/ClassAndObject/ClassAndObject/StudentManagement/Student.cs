using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    public class Student
    {
        private string _Number;
        public string Number
        {
            get
            {
                return this._Number;
            }
        }
        public string Name
        {
            get;
            private set;
        }
        public Gender Gender
        {
            get;
            private set;
        }
        public DateTime BirthDate
        {
            get;
            private set;
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
                return this._PhoneNumber.Substring(0, 3) + "****" + this._PhoneNumber.Substring(8, 4);
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
            Console.WriteLine("我叫" + this.Name + (this.Class == null ? "" : "，来自" + this.Class.ShortName) + "。");
        }
        public void SendSms(string message)
        {
            if (this._PhoneNumber != null)
            {
                Console.WriteLine("{发送短信至" + this._PhoneNumber + "}");
            }
            else
            {
                Console.WriteLine("尚未登记手机号。");
            }
        }
        public void EnrollByMajor(Major newMajor)
        {
            Class newClass = new Class(DateTime.Now.Year, newMajor);
            this.Class = newClass; 
            Console.WriteLine("该生已被录取。");
        }
        public void TransferToMajor(Major newMajor)
        {
            Class newClass = new Class(this.Class.Year + 1, newMajor);
            this.Class = newClass;
            Console.WriteLine("该生已转专业。");
        }
        public Student(string number, string name, Gender gender, DateTime birthDate)
        {
            this._Number = number;
            this.Name = name;
            this.Gender = gender;
            this.BirthDate = birthDate;
        }
        public Student(string number, string name, Gender gender, DateTime birthDate, Class currentClass)
            : this(number, name, gender, birthDate)
        {
            this.Class = currentClass;
        }
    }
}
