using System;
using static System.Console;

namespace SmartLin.LearningCSharp.SingletonPattern
{
    class Program
    {
        static void Main()
        {
            WriteLine("首次执行：");
            while (true)
            {
                Write(SequentialNumberService.GetSequentialNumber());
                if (ReadLine() == "x")
                {
                    break;
                }
            }
            WriteLine("再次执行：");
            Execute();
        }
        /// <summary>
        /// 执行；
        /// </summary>
        static void Execute()
        {
            while (true)
            {
                Write(SequentialNumberService.GetSequentialNumber());
                if (ReadLine() == "x")
                {
                    break;
                }
            }
        }
    }
}
