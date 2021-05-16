using System;
using System.Collections.Generic;

namespace SmartLin.LearningCSharp.Linq
{
    /// <summary>
    /// 性别；
    /// </summary>
    public class Gender
    {
        public static readonly string MALE = "男";
        public static readonly string FEMALE = "女";
    }
    /// <summary>
    /// 学生；
    /// </summary>
    public class Student
    {
        /// <summary>
        /// 学号；
        /// </summary>
        public string Number { get; private set; }
        /// <summary>
        /// 姓名；
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 性别；
        /// </summary>
        public string Gender { get; set; }
        /// <summary>
        /// 生日；
        /// </summary>
        public DateTime? BirthDate { get; set; }
        /// <summary>
        /// 年龄；
        /// </summary>
        public int? Age
        {
            get
            {
                if (this.BirthDate == null)
                {
                    return null;
                }
                else
                {
                    return DateTime.Now.Year - this.BirthDate.Value.Year;
                }
            }
        }
        /// <summary>
        /// 身高；
        /// </summary>
        public float Height { get; set; }
        /// <summary>
        /// 体重；
        /// </summary>
        public float Weight { get; set; }
        /// <summary>
        /// 班级；
        /// </summary>
        public Class Class { get; set; }
        /// <summary>
        /// 修读课程；
        /// </summary>
        public List<Course> LearningCourses { get; set; }
        /// <summary>
        /// 导师工号；
        /// </summary>
        public string InstructorNumber { get; set; }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="gender">性别</param>
        public Student(string number, string name, string gender)
        {
            this.Number = number;
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
        public Student(string number, string name, string gender, DateTime birthDate, Class currentClass)
            : this(number, name, gender)
        {
            this.BirthDate = birthDate;
            this.Class = currentClass;
        }
    }
}
