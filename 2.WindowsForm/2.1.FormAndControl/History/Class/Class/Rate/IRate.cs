using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.Oop
{
    public interface IRate<T>
    {
        T Target
        {
            get;
            set;
        }
        bool HasRated
        {
            get;
        }
        string RateStatus
        {
            get;
        }
        DateTime OpeningDate
        {
            get;
            set;
        }
        DateTime ClosingDate
        {
            get;
            set;
        }
        ValidationResult ValidateBeforeInput();
        ValidationResult ValidateAfterInput();
        void Input();
    }
}
