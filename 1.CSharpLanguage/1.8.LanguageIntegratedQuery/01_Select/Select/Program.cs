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

            Console.WriteLine("查询所有学生：");
            var results = from s in students                                            //使用匿名类型来声明Linq的查询结果；from子句等价于foreach语句，用于声明范围变量、指定集合；
                          select s;                                                     //select子句返回结果；
            foreach (Student student in results)                                        //查询结果为IEnumerable<Student>类型，可直接在foreach语句中迭代；
            {
                Console.WriteLine
                ("学号：{0,-12}姓名：{1}\t性别：{2,-3}生日：{3,-12:d}班级：{4}"
                , student.Number                                                        
                , student.Name
                , student.Gender == Gender.MALE ? "男" : "女"
                , student.BirthDate
                , student.Class);
            }

            Console.WriteLine("\n查询所有学生的基本信息：");
            var results2 = from s in students
                           select new                                                   //select可返回由new操作符与初始化器实现的匿名类型；
                            {
                                Number = s.Number,                                      //初始化器中可指定（只读）属性名称与值；
                                Name = s.Name,
                                Class = s.Class
                            };
            foreach (var student in results2)
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
