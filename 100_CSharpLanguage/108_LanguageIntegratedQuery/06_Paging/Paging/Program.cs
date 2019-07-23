using System;
using System.Collections.Generic;
using System.Linq;

namespace SmartLin.LearningCSharp.Linq
{
    class Program
    {
        static void Main()
        {
            List<Student> students = StudentRepository.GetAllStudents();

            Console.WriteLine("\n分页查询学生：");
            int
                pageSize = 5
                , previousPageIndex = 0;
            var results = (from s in students
                           select s)
                          .Skip(previousPageIndex * pageSize)               //对查询结果调用Skip方法，首先根据页面大小，跳过先前页的所有元素；
                          .Take(pageSize);                                  //其次提取当前页的元素；
            foreach (var student in results)
            {
                Console.WriteLine
                        ("学号：{0,-12}姓名：{1,-4}\t班级：{2}"
                        , student.Number
                        , student.Name
                        , student.Class);
            }

            Console.Read();
        }
    }
}
