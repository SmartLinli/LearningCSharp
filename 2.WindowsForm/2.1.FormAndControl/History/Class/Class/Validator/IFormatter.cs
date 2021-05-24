using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.Oop
{
    public interface IFormatter<O>
    {
        O Output();
    }
}
