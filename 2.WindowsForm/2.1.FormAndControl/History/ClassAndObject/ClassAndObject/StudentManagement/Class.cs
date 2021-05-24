using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    public class Class
    {
        public int Year;
        public Major Major;
        public string ShortName
        {
            get
            {
                return this.Year.ToString().Substring(2, 2) + this.Major.ShortName;
            }
        }
        public string Name
        {
            get
            {
                return this.Year.ToString() + "级" + this.Major.Name;
            }
        }
        public Class(int year, Major major)
        {
            this.Year = year;
            this.Major = major;
        }
        public Class(Major major)
            : this(DateTime.Now.Year, major)
        {
        }
    }
}
