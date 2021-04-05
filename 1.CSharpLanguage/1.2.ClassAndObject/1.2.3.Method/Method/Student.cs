using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    public class Student
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public void Intro()                                                 //定义公有方法；
        {
            WriteLine($"我叫{this.Name}，来自{this.Class}。");
        }
    }
}
