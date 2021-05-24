using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polymorphism
{
    public class ElectiveCourse : BaseCourse
    {
        public ElectiveCourse(string name)
            : base(name)
        {
            ;
        }
        public override void Examine()
        {
            Console.Write("《{0}》选修课程考试", this.Name);
            Console.ReadLine();
        }
    }
}
