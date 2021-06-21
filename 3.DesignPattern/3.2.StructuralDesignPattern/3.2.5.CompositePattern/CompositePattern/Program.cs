using System.Collections.Generic;
using static System.Console;

namespace SmartLin.LearningCSharp.CompositePattern
{
    class Program
    {
        static void Main()
        {
            List<Student> students = StudentRepository.GetAll();
            students[0].Intro(1);
            ReadLine();
        }
    }
}
