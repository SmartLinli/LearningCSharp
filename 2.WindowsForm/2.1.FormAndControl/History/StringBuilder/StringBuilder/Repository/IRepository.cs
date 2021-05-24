using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.StringBuilder
{
    public interface  IRepository<T>
    {
        void Insert(T t);
        T Get(Predicate<T> expression);
    }
}
