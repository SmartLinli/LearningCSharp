using System;

namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
    /// <summary>
    /// 班级；
    /// </summary>
    public class Class
    {
        /// <summary>
        /// 年级；
        /// </summary>
        public int Year
        {
            get;
            private set;
        }
        /// <summary>
        /// 专业；
        /// </summary>
        public Major Major
        {
            get;
            private set;
        }
        /// <summary>
        /// 名称；
        /// </summary>
        public string Name
        {
            get
            {
                return this.Year.ToString() + "级" + this.Major.Name;
            }
        }
        /// <summary>
        /// 简称；
        /// </summary>
        public string ShortName
        {

            get
            {
                return this.Year.ToString().Substring(2, 2) + this.Major.ShortName;
            }
        }
        /// <summary>
        /// 是否与目标对象相等；
        /// </summary>
        /// <param name="obj">对象</param>
        /// <returns>是否相等</returns>
        public override bool Equals(object obj)                             //Lookup类要求作为键的类重写Equals方法，用于比较键；
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Class))
            {
                return false;
            }
            Class otherClass = obj as Class;
            return this.ShortName == otherClass.ShortName;
        }
        /// <summary>
        /// 获取散列值；
        /// </summary>
        /// <returns>散列值</returns>
        public override int GetHashCode()                                   //Lookup类要求作为键的类重写GetHashCode方法；
        {
            return this.ShortName.GetHashCode();
        }
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
