using System;

namespace SmartLin.LearningCSharp.Linq
{
    /// <summary>
    /// 班级；
    /// </summary>
    public class Class : IComparable<Class>                                     //实现IComparable泛型接口，用于排序时的比较；
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
        public string Name => this.Year.ToString() + "级" + this.Major.Name;
        /// <summary>
        /// 简称；
        /// </summary>
        public string ShortName => this.Year.ToString().Substring(2, 2) + this.Major.ShortName;
        /// <summary>
        /// 转为字符串；
        /// </summary>
        /// <returns>字符串</returns>
        public override string ToString() => this.ShortName;
        /// <summary>
        /// 比较；
        /// </summary>
        /// <param name="otherClass">其它班级</param>
        /// <returns>大小</returns>
        public int CompareTo(Class otherClass)
        =>  this.ShortName.CompareTo(otherClass.ShortName);
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
