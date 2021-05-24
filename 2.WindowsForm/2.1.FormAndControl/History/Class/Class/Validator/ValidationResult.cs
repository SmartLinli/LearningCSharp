using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.Oop
{
    public class ValidationResult : IResult
    {
        public ResultType Type
        {
            get;
            set;
        }
        public string Message
        {
            get;
            set;
        }
        public string Error
        {
            get;
            set;
        }
        public ValidationResult()
        {
            ;
        }
        public ValidationResult(ResultType type, string message, string error)
        {
            this.Type = type;
            this.Message = message;
            this.Error = error;
        }
    }
}
