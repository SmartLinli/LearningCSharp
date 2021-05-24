using System;

namespace SmartLin.LearningCSharp.Inheritance
{
    class Program
    {
        static void Main()
        {
            object boy = new Student("3180707001", "张三", Gender.MALE);
            Console.WriteLine("学生姓名：{0}", boy);                        //隐式调用对象的ToString方法；
            Console.Read();
        }
    }
}
