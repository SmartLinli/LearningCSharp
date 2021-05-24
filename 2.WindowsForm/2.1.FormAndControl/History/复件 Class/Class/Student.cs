using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.Oop
{
    public class Student
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
        public Score Score
        {
            get;
            set;
        }        
        public Student(string number, string name)
        {
            this.Number = number;
            this.Name = name;
            this.Score = new Score();
        }
    }
}
