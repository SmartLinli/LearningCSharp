using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            ICourse[] courses =
            {
                new CompulsiveCourse("数据库原理")
                , new ElectiveCourse("数据库技术与应用")
            };
            foreach (ICourse course in courses)
            {
                course.Examine();
            }
        }
    }
}
