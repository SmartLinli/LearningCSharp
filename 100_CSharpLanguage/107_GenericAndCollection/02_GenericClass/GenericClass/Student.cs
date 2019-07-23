using System;

namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
    /// <summary>
    /// 性别；
    /// </summary>
    public enum Gender
    {
        FEMALE = 0,
        MALE = 1
    }
    /// <summary>
    /// 学生；
    /// </summary>
    public class Student : IEntity
    {
        private string _Number;
        /// <summary>
        /// 学号；
        /// </summary>
        public string Number
        {
            get
            {
                return this._Number;
            }
            set
            {
                ;
            }
        }
        /// <summary>
        /// 姓名；
        /// </summary>
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// 性别；
        /// </summary>
        public Gender Gender
        {
            get;
            set;
        }
        /// <summary>
        /// 生日；
        /// </summary>
        public DateTime? BirthDate                                              //基于Nullable<T>的可空类型；
        {
            get;
            set;
        }
        /// <summary>
        /// 年龄；
        /// </summary>
        public int? Age                                                         //基于Nullable<T>的可空类型；
        {
            get
            {
                if (this.BirthDate == null)
                {
                    return null;
                }
                else
                {
                    return DateTime.Now.Year - this.BirthDate.Value.Year;       //通过Value属性访问Nullable<T>中的值；
                }
            }
        }
        private string _PhoneNumber;
        /// <summary>
        /// 电话；
        /// </summary>
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
        /// <summary>
        /// 学籍；
        /// </summary>
        public string Status
        {
            get;
            set;
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="gender">性别</param>
        public Student(string number, string name, Gender gender)
        {
            this._Number = number;
            this.Name = name;
            this.Gender = gender;
            this.BirthDate = null;
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="gender">性别</param>
        /// <param name="birthDate">生日</param>
        public Student(string number, string name, Gender gender, DateTime birthDate)
            : this(number, name, gender)
        {
            this.BirthDate = birthDate;
        }
    }
}
