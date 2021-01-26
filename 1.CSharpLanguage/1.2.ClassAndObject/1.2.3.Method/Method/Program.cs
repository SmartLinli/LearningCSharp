using System;
using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
	class Program
    {
        static void Main()
        { 
            Student girl = new Student();
            girl.Name = "李四";
			girl.Class = "21信管";
            girl.Intro();                                                                   //调用方法；
            Read();
        }
    }
}
