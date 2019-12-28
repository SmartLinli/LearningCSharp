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

            Console.WriteLine("\n查询18公管的学生：");
            var results = from s in students
                          where s.Class.ShortName == "18公管"                   //Where子句根据表达式筛选出结果；
                          select s;
            foreach (Student student in results)
            {
                Console.WriteLine
                        ("学号：{0,-12}姓名：{1,-4}\t班级：{2}"
                        , student.Number
                        , student.Name
                        , student.Class);
            }

            Console.WriteLine("\n查询18公管与18健管的男生：");
            var results2 = from s in students
                           where (s.Class.ShortName == "18公管" || s.Class.ShortName == "18健管") && s.Gender == Gender.MALE
                           select s;
            foreach (Student student in results2)
            {
                Console.WriteLine
                        ("学号：{0,-12}姓名：{1,-4}\t性别：{2,-3}班级：{3}"
                        , student.Number
                        , student.Name
                        , student.Gender == Gender.MALE ? "男" : "女"
                        , student.Class);
            }

            Console.WriteLine("\n查询指定学号的学生：");
            var studentResult = (from s in students
                                 where s.Number == "3180707001"
                                 select s)
                                 .FirstOrDefault();                             //select子句返回IEnumerable泛型类型，还需调用First方法来获取其中第一个元素；若查无结果，First方法将抛出异常，而FirstOrDefault方法则能返回null；
            if (studentResult != null)
            {
                Console.WriteLine
                        ("学号：{0,-12}姓名：{1,-4}\t性别：{2,-3}班级：{3}"
                        , studentResult.Number
                        , studentResult.Name
                        , studentResult.Gender == Gender.MALE ? "男" : "女"
                        , studentResult.Class);
            }
            else
            {
                Console.WriteLine("查无此人！");
            }

            Console.WriteLine("\n查询修读《管理学基础》的学生：");
            var results3 = from s in students
                           from c in s.LearningCourses                          //若元素中还包含集合，则可使用复合from子句查询两个层次的对象；复合from子句自动创建匿名类型，分别将上层类与下层类作为匿名类型的两个属性，并基于每个上层对象及其相应的若干下层对象返回匿名类型的若干对象；
                           where c.Name == "管理学基础"                         
                           select s;
            foreach (Student student in results3)
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
