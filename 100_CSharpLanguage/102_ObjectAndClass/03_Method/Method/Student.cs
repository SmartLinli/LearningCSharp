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
        private string _Number;
        public string Number
        {
            get
            {
                return this._Number;
            }
            set
            {
                if (this._Number == null)
                {
                    this._Number = value;
                }
            }
        }
        private string _Name;
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
            }
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
            private set;                                                    //set访问器的访问级别为私有，只能允许该类的方法访问；
        }
        private bool HasClass                                               //定义私有属性；
        {
            get
            {
                return this.Class != null;
            }
        }
        public void Intro()                                                 //定义公有方法；
        {
            Console.WriteLine
                ("我叫{0}{1}。"
                , this.Name
                , this.HasClass ? "，来自" + this.Class.ShortName : "");
        }
        public void EnrollByMajor(Major newMajor)
        {
            if (this.HasClass)                                              //调用私有属性，实现代码复用，提高代码可读性；
            {
                Console.WriteLine
                    ("{0}已被{1}专业录取，不得重复录取。"
                    , this.Name
                    , this.Class.Major.Name);
            }
            else
            {
                Class newClass = new Class();
                newClass.Year = DateTime.Now.Year;
                newClass.Major = newMajor;
                this.Class = newClass;
                Console.WriteLine
                    ("{0}被{1}专业录取，并分配至{2}班。"
                    , this.Name
                    , newMajor.Name
                    , newClass.ShortName);
            }
        }
        private bool ValidateForTransferToMajor()                           //定义私有方法；
        {
            if (!this.HasClass)
            {
                Console.WriteLine
                    ("{0}尚未被任何专业录取，无法转专业。"
                    , this.Name);
            }
            return this.HasClass;
        }
        public void TransferToMajor(Major newMajor, int year)               //公有方法（重载1）
        {
            if (this.ValidateForTransferToMajor())                          //调用私有方法，实现代码复用；
            {
                Class newClass = new Class();
                newClass.Major = newMajor;
                newClass.Year = year;
                this.Class = newClass;
                Console.WriteLine
                    ("{0}已转至{1}专业，并分配至{2}班。"
                    , this.Name
                    , newMajor.Name
                    , newClass.ShortName);
            }
        }
        public void TransferToMajor(Major newMajor)                         //公有方法（重载2）
        {
            if (this.ValidateForTransferToMajor())
            {
                int newClassYear = this.Class.Year + 1;
                this.TransferToMajor(newMajor, newClassYear);               //调用另一重载方法，实现代码复用；
            }
        }
    }
}
