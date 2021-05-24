using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polymorphism
{
    public class CompulsiveCourse : BaseCourse
    {
        public CompulsiveCourse(string name)
            : base(name)
        {
            ;
        }
        public override void Examine()
        {
            Console.Write("《{0}》必修课程考试", this.Name);
            Console.ReadLine();
        }
    }
}
