using System;
using static System.Console;

namespace SmartLin.LearningCSharp.Reflection
{
    class Program
    {
        static void Main()
        {
            try
            {
                Course course = Course.Create("2060316", "面向对象程序设计", 4.5f);
                WriteLine($"课程{course.Number}《{course.Name}》创建成功。");
            }
            catch (ApplicationException ex)
            {
                WriteLine($"错误：{ex.Message}。\n课程创建失败。");
            }
            Read();
        }
    }
}