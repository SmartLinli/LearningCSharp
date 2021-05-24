using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.Oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Faculty mrLin = new Faculty("2004034", "立立");
            Course Oop = new Course("2060238", "面向对象程序设计");
            Course databaseTheory = new Course("2060308", "数据库原理");
            mrLin.Courses = new Course[2];
            mrLin.Courses[0] = Oop;
            mrLin.Courses[1] = databaseTheory;
            Student boy = new Student("3180707001", "张三");
            Student girl = new Student("3180707002", "李四");
            Oop.Students = new Student[2];
            Oop.Students[0] = boy;
            Oop.Students[1] = girl;
            mrLin.ShowCourses();
            while (true)
            {
                Course courseFound = mrLin.FindCourse();
                if (courseFound != null)
                {
                    courseFound.EnterStudentsScore();
                    courseFound.ShowStudentsScore();            
                }
            }
        }
    }
}
