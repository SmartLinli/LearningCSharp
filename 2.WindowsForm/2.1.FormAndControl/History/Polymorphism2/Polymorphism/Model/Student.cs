using System;

namespace SmartLin.LearningCSharp.Inheritance
{
    public class Student : User                                                             //定义一个类，派生于另一个类；
    {
        public Class Class
        {
            get;
            private set;
        }
        public override void Intro()                                                        //重写基类中的虚方法；
        {
            base.Intro();
            if (this.Class != null)
            {
                Console.WriteLine("，来自{0}。\n", this.Class.ShortName);
            }
            else
            {
                Console.WriteLine("，今天刚入学。\n");
            }
        }
        public Student(string number, string name, Gender gender)
            : base(number, name, gender)                                                    //调用基类的构造函数；
        {
            ;
        }
        public Student(string number, string name, Gender gender, Class currentClass)
            : this(number, name, gender)
        {
            this.Class = currentClass;
        }
    }
}
