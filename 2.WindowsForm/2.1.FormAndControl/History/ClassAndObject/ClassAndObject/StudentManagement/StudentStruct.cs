using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    struct StudentStruct
    {
        string Number;
        string Name;
        Gender Gender;
        DateTime BirthDate;
    }
    public enum Gender
    {
        Male = 0,
        Female = 1
    }
}
