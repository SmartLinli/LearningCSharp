using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.Oop
{
    public interface IRateFactory<T>
    {
        IRate<T> Create();
        //IRate<T> Create(T target, DateTime openingDate, DateTime closingDate);
    }
}
