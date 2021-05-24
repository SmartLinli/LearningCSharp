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
    public class Student
    {
        /// <summary>
        /// 学号；
        /// </summary>
        public string Number
        {
            get;
            private set;
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
        public Class Class
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
        /// <param name="birthDate">生日</param>
        public Student(string number, string name, Gender gender, Class currentClass)
            : this(number, name, gender)
        {
            this.Class = currentClass;
        }
    }
}
