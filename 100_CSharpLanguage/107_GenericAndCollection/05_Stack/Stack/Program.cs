using System;

namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
    class Program
    {
        static void Main()
        {
            Course oop = new Course("2060316", "面向对象程序设计", 4.5f);
            oop.Name = "C#程序设计";
            oop.Name = ".Net程序设计";
            oop.RestoreName();
            oop.RestoreName();
            oop.RestoreName();
            Console.Read();
        }
    }
}
