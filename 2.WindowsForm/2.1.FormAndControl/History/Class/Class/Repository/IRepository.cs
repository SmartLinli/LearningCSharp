using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.Oop
{
    public interface IRepository<E,I>
    {
        E[] FindAll(I input);
        void Save(E entity);
    }
}
