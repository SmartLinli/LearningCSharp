using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    public class Student
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public void Intro()                                                 
        =>  WriteLine($"我叫{this.Name}，来自{this.Class}。");               //通过表达式体，定义只有单语句的方法；
        public void EnrollBy(string newClassName)                           //定义公有方法；
        {
            this.Class = newClassName;
            WriteLine($"{this.Name}被录取至{newClassName}班。");
        }
    }
}
