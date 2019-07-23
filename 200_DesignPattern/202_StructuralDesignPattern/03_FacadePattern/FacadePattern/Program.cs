using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.FacadePattern
{
    class Program
    {
        static void Main()
        {
            Student newStudent = new Student("3190707001", "张三", Gender.MALE);
            StudentAffairOffice.WelCome(newStudent);
            Console.ReadLine();
        }
    }
}
