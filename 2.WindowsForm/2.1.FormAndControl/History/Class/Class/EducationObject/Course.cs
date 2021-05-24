using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.Oop
{
    public class Course
    {
        public string Number
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public Course(string number, string name)
        {
            this.Number = number;
            this.Name = name;
        }
    }
}
