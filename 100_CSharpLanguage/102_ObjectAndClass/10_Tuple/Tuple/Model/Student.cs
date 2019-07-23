using System;
using SmartLin.LearningCSharp.ClassAndObject.Model;                                         //对项目默认命名空间以外的资源访问，可通过添加调用获得便利；

namespace SmartLin.LearningCSharp.ClassAndObject.Model                                      //向文件夹添加的类，所在命名空间默认为项目默认命名空间+文件夹路径；
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
    public partial class Student
    {
        /// <summary>
        /// 学号；
        /// </summary>
        public string Number
        {
            get;
            internal set;
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
        public DateTime BirthDate
        {
            get;
            set;
        }
        /// <summary>
        /// 年龄；
        /// </summary>
        public int Age
        {
            get
            {
                return DateTime.Now.Year - this.BirthDate.Year;
            }
        }
        /// <summary>
        /// 手机号；
        /// </summary>
        private string _PhoneNumber;
        /// <summary>
        /// 手机号；
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
        /// 班级；
        /// </summary>
        public Class Class
        {
            get;
            internal set;
        }
        /// <summary>
        /// 是否有班级；
        /// </summary>
        private bool HasClass                                               
        {
            get
            {
                return this.Class != null;
            }
        }
        /// <summary>
        /// 介绍；
        /// </summary>
        public void Intro()
        {
            Console.WriteLine
                ("我叫{0}{1}。"
                , this.Name
                , this.HasClass ? "，来自" + this.Class.ShortName : "");
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="gender">性别</param>
        private Student(string number, string name, Gender gender)                              //定义私有构造函数（重载1）；
        {
            this.Number = number;
            this.Name = name;
            this.Gender = gender;
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="gender">性别</param>
        /// <param name="currentClass">班级</param>
        private Student(string number, string name, Gender gender, Class currentClass)          //定义私有构造函数（重载2）；
            : this(number, name, gender)
        {
            this.Class = currentClass;
        }
    }
}
