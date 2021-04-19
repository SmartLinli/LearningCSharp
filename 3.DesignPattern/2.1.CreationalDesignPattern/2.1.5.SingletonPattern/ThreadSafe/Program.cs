using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.SingletonPattern
{
    class Program
    {
        static void Main()
        {
            while (true)
            {

                Console.Write(SequentialNumberService.Instance.GetSequentialNumber());
                if (Console.ReadLine() == "x")
                {
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
