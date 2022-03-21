using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
    class Program
    {
        static void Main()
        {
            object boy = new Student("3220707001", "张三");    //根据里氏替换原则，派生类对象的类型可声明为基类；
            WriteLine($"学生：{boy}");                         //此处WriteLine的参数类型为字符串，首先将隐式调用参数的ToString方法，进而调用学生类重写的ToString方法；
            Read();
        }
    }
}
