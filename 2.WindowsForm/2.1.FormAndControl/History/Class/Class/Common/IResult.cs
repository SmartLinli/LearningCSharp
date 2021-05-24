using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.Oop
{
    public interface IResult
    {
        ResultType Type
        {
            get;
            set;
        }
        string Message
        {
            get;
            set;
        }
        string Error
        {
            get;
            set;
        }
    }
    public enum ResultType
    {
        OK = 1,
        FAIL = 2
    }
}
