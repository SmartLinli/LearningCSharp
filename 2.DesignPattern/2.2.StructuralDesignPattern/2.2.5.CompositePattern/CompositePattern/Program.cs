using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.CompositePattern
{
    class Program
    {
        static void Main()
        {
            List<Student> students = StudentRepository.GetAll();
            students[0].Intro(1);
            Console.ReadLine();
        }
    }
}
