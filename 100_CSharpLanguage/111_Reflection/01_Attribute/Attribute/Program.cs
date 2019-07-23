using System;
using System .Collections.Generic;

namespace SmartLin.LearningCSharp.Reflection
{
    class Program
    {
        static void Main()
        {
            List<Course> courses = new List<Course>()
            {
                new Course("2060162","计算机科学导论",3f)
                ,new Course("2060316","面向对象程序设计与C#语言",4.5f)
                ,new Course("N2060241","计算机网络",4f)
                ,new Course("2020136","线性代数",12.5f)
            };
            foreach (var course in courses)
            {
                try
                {
                    ValidationService.Validate(course);
                    Console.WriteLine("课程{0}《{1}》信息正确。\n", course.Number, course.Name);
                }
                catch (ApplicationException ex)
                {
                    Console.WriteLine("错误：课程{0}《{1}》信息有误，{2}。\n", course.Number, course.Name, ex.Message);
                }
            }

            List<Book> books = new List<Book>()
            {
                new Book("9787302179641","计算机导论",35f)
                ,new Book("9787302108535O","C程序设计（第三版）",26f)
                ,new Book("9787302271284","计算机网络",39.5f)
                ,new Book("9787513208529","中医学基础 ",260f)
            };
            foreach (var book in books)
            {
                try
                {
                    ValidationService.Validate(book);
                    Console.WriteLine("教材{0}《{1}》信息正确。\n", book.Isbn, book.Name);
                }
                catch (ApplicationException ex)
                {
                    Console.WriteLine("错误：教材{0}《{1}》信息有误，{2}。\n", book.Isbn, book.Name, ex.Message);
                }
            }
            Console.Read();
        }
    }
}
