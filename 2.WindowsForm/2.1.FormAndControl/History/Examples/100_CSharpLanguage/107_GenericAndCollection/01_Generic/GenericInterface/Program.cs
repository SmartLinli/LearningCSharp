using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
    class Program
    {
        static void Main()
        {
            Course Oop = new Course("2060238", "面向对象程序设计",4.5f);
            Student boy = new Student("3180707001", "张三", Gender.MALE);
            CourseUi courseUi = new CourseUi();
            StudentUi studentUi = new StudentUi();
            courseUi.Display(Oop);
            studentUi.Display(boy);
            Console.Read();
        }
    }
}
