using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.Oop
{
    public interface IRateValidatorFactory<T>
    {
        IValidator Create(IRate<T> rate);
    }
}
