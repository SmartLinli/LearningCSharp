using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    class Program
    {
        static void Main()
        { 
            Student girl = new Student();
            girl.Name = "李四";
            girl.EnrollBy("23信管");                                                  //调用方法；
            girl.Intro();                                                                   
            Read();
        }
    }
}
