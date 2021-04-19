using System;

namespace SmartLin.LearningCSharp.SingletonPattern
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("首次执行：");
            while (true)
            {
                Console.Write(SequentialNumberService.GetSequentialNumber());
                if (Console.ReadLine() == "x")
                {
                    break;
                }
            }
            Console.WriteLine("再次执行：");
            Execute();
        }
        /// <summary>
        /// 执行；
        /// </summary>
        static void Execute()
        {
            while (true)
            {
                Console.Write(SequentialNumberService.GetSequentialNumber());
                if (Console.ReadLine() == "x")
                {
                    break;
                }
            }
        }
    }
}
