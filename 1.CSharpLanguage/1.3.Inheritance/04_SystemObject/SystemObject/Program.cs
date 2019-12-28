using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
    class Program
    {
        static void Main()
        {
            object boy = new Student("3180707001", "张三", Gender.MALE);
            WriteLine($"学生姓名：{boy}");                        //隐式调用对象的ToString方法；
            Read();
        }
    }
}
