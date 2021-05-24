using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polymorphism
{
    public interface ICourse
    {
        string Number{get;set;}
        string Name{get;set;}
        void Examine();
    }
}
