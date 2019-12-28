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
            
            Console.WriteLine("\n对所有学生按照姓名排序：");
            var results = from s in students
                          orderby s.Name                                                        //orderby子句实现排序，默认升序；
                          select s;
            foreach (Student student in results)
            {
                Console.WriteLine
                        ("学号：{0,-12}姓名：{1,-4}\t性别：{2,-3}生日：{3}"
                        , student.Number
                        , student.Name
                        , student.Gender == Gender.MALE ? "男" : "女"
                        , student.BirthDate.Value.ToLongDateString());
            }

            Console.WriteLine("\n对所有学生按照性别（男→女）、生日（早→晚）排序：");
            var results2 = from s in students
                           orderby s.Gender descending, s.BirthDate                             //按不同属性排序，并分别指定是否降序；
                           select s;
            foreach (Student student in results2)
            {
                Console.WriteLine
                        ("学号：{0,-12}姓名：{1,-4}\t性别：{2,-3}生日：{3}"
                        , student.Number
                        , student.Name
                        , student.Gender == Gender.MALE ? "男" : "女"
                        , student.BirthDate.Value.ToLongDateString());
            }

            Console.Read();
        }
    }
}
