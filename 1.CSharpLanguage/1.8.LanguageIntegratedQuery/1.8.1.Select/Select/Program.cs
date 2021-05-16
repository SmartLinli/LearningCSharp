using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace SmartLin.LearningCSharp.Linq
{
    class Program
    {
        static void Main()
        {
            List<Student> students = StudentRepository.GetAllStudents();

            WriteLine("查询所有学生：");
            var results = from s in students                                            //使用匿名类型来声明Linq的查询结果；from子句等价于foreach语句，用于声明范围变量、指定集合；
                          select s;                                                     //select子句返回结果；
            foreach (Student student in results)                                        //查询结果为IEnumerable<Student>类型，可直接在foreach语句中迭代；
            {
                WriteLine
                    ($"学号：{student.Number,-12}姓名：{student.Name}\t" +
                    $"性别：{student.Gender,-3}生日：{student.BirthDate,-12:d}班级：{student.Class}");
            }

            WriteLine("\n查询所有学生的基本信息：");
            var results2 = from s in students
                           select new                                                   //select可返回由new操作符与初始化器实现的匿名类型；
                           {
                               s.Number,                                                //初始化器中可指定（只读）属性名称与值；
                               s.Name,
                               s.Class
                           };
            foreach (var student in results2)
            {
                WriteLine
                    ($"学号：{student.Number,-12}姓名：{student.Name,-4}\t班级：{student.Class}");
            }
            Read();
        }
    }
}
