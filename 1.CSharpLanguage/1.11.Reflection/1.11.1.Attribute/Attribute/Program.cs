using System;
using System .Collections.Generic;
using static System.Console;

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
                    WriteLine($"课程{course.Number}《{course.Name}》信息正确。\n");
                }
                catch (ApplicationException ex)
                {
                    WriteLine($"错误：课程{course.Number}《{course.Name}》信息有误，{ex.Message}。\n");
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
                    WriteLine($"教材{book.Isbn}《{book.Name}》信息正确。\n");
                }
                catch (ApplicationException ex)
                {
                    WriteLine($"错误：教材{book.Isbn}《{book.Name}》信息有误，{ex.Message}。\n");
                }
            }
            Read();
        }
    }
}
