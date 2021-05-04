using System;

namespace SmartLin.LearningCSharp.DelegateAndEvent
{
    /// <summary>
    /// 班级；
    /// </summary>
    public class Class
    {
        /// <summary>
        /// 年级；
        /// </summary>
        public int Year { get; private set; }
        /// <summary>
        /// 专业；
        /// </summary>
        public Major Major { get; private set; }
        /// <summary>
        /// 名称；
        /// </summary>
        public string Name => $"{this.Year}级{this.Major.Name}";
        /// <summary>
        /// 简称；
        /// </summary>
        public string ShortName => $"{this.Year % 100}{this.Major.ShortName}";
        /// <summary>
        /// 学生；
        /// </summary>
        public Student[] Students { get; set; }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="major">专业</param>
        /// <param name="year">年级</param>
        public Class(Major major, int year)
        {
            this.Year = year;
            this.Major = major;
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="major">专业</param>
        public Class(Major major)
            : this(major, DateTime.Now.Year)
        {
            ;
        }
    }
}
