using System;

namespace Polymorphism
{
    public class BaseCourse:ICourse
    {
        public string Number
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public BaseCourse(string name)
        {
            this.Name = name;
        }
        public virtual void Examine()
        {
            Console.Write("《{0}》课程考试",this.Name);
            Console.ReadLine();
        }
    }
}
