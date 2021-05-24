using System;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    public class Class
    {
        public int Year
        {
            get;
            private set;
        }
        public Major Major
        {
            get;
            private set;
        }
        public string Name
        {
            get
            {
                return this.Year.ToString() + "级" + this.Major.Name;
            }
        }
        public string ShortName
        {
            get
            {
                return this.Year.ToString().Substring(2, 2) + this.Major.ShortName;
            }
        }
        public Class(Major major, int year)
        {
            this.Year = year;
            this.Major = major;
        }
        public Class(Major major)
            : this(major, DateTime.Now.Year)
        {
            ;
        }
    }
}
