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

            Console.WriteLine("\n首次查询18信管的学生：");
            var results = from s in students                                    //该匿名类型并不保存查询结果；
                          where s.Class.ShortName == "18信管"
                          select s;
            foreach (var student in results)                                    //查询在迭代时执行；
            {
                Console.WriteLine
                        ("学号：{0,-12}姓名：{1,-4}\t班级：{2}"
                        , student.Number
                        , student.Name
                        , student.Class);
            }
            students.RemoveRange(0, 10);
            Console.WriteLine("再次查询18信管的学生：");
            foreach (var student in results)                                    //再次迭代时，将再次执行查询，返回最新结果；
            {
                Console.WriteLine
                        ("学号：{0,-12}姓名：{1,-4}\t班级：{2}"
                        , student.Number
                        , student.Name
                        , student.Class);
            }

            Console.WriteLine("\n首次查询18公管的学生：");
            var results2 = (from s in students
                            where s.Class.ShortName == "18公管"
                            select s).ToList<Student>();                        //调用转换方法时，将创建新对象，保存转换结果；
            foreach (var student in results2)                                   //首次迭代访问转换结果；
            {
                Console.WriteLine
                        ("学号：{0,-12}姓名：{1,-4}\t班级：{2}"
                        , student.Number
                        , student.Name
                        , student.Class);
            }
            students.Clear();
            Console.WriteLine("再次查询18信管的学生：");
            foreach (var student in results2)                                   ////再次迭代依然访问先前的转换结果；
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
