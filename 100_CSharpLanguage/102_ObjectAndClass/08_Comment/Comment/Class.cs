using System;

namespace SmartLin.LearningCSharp.ClassAndObject
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
				return $"{this.Year}级{this.Major.Name}";
			}
		}
        /// <summary>
        /// 简称；
        /// </summary>
        public string ShortName
        {
            get
            {
				return $"{this.Year % 100}{this.Major.ShortName}";
			}
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
