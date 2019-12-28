using System;

namespace SmartLin.LearningCSharp.Reflection
{
    class Program
    {
        static void Main()
        {
            try
            {
                Course course = Course.Create("2060316", "面向对象程序设计", 4.5f);
                Console.WriteLine("课程{0}《{1}》创建成功。", course.Number, course.Name);
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine("错误：{0}。\n课程创建失败。", ex.Message);
            }
            Console.Read();
        }
    }
}
