using System;

namespace SmartLin.LearningCSharp.Inheritance
{
    public class Faculty : User
    {
        public Department Department
        {
            get;
            private set;
        }
        public override void Intro()                                                        //重写基类中的虚方法；
        {
            Console.Write("我是{0}老师", this.Name.Substring(0, 1));
            if (this.Department != null)
            {
                Console.WriteLine("，来自{0}。\n", this.Department.Name);
            }
            else
            {
                Console.WriteLine("，今天刚入职。\n");
            }
        }
        public Faculty(string number, string name, Gender gender)
            : base(number, name, gender)                                                    //调用基类的构造函数；
        {
            ;
        }
        public Faculty(string number, string name, Gender gender, Department department)
            : this(number, name, gender)
        {
            this.Department = department;
        }
    }
}
