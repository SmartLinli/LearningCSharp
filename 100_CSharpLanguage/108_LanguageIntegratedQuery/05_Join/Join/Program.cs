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
            List<Faculty> faculties = FacultyRepository.GetAllFaculties();

            Console.WriteLine("\n查询每名学生的导师：");
            var results = from s in students
                          join f in faculties on s.InstructorNumber equals f.Number             //join子句连接来自不同集合的元素；on指定连接条件；on只支持等值连接，不支持!=、>=等运算符，故使用专用的equals，而不使用==运算符；
                          select new
                          {
                              Name = s.Name,
                              Class = s.Class,
                              Instructor = f.Name,
                              InstructorPhone = f.PhoneNumber
                          };
            foreach (var student in results)
            {
                Console.WriteLine
                        ("学生：{0,-4}\t班级：{1,-7}导师：{2}\t电话：{3}"
                        , student.Name
                        , student.Class
                        , student.Instructor
                        , student.InstructorPhone);
            }

            Console.WriteLine("\n查询18信管每名学生的导师，按导师姓名、学生学号排序：");
            var results2 = from s in students
                           join f in faculties on s.InstructorNumber equals f.Number
                           where s.Class.ShortName == "18信管"
                           orderby f.Name, s.Number
                           select new
                           {
                               Number = s.Number,
                               Name = s.Name,
                               Instructor = f.Name,
                               InstructorPhone = f.PhoneNumber
                           };
            foreach (var student in results2)
            {
                Console.WriteLine
                        ("学号：{0,-12}姓名：{1,-4}\t导师：{2,-4}\t电话：{3}"
                        , student.Number
                        , student.Name
                        , student.Instructor
                        , student.InstructorPhone);
            }

            Console.WriteLine("\n查询指导18信管超过1名学生的导师及其指导人数，按人数（降序）、导师姓名排序：");
            var results3 = from s in students
                           join f in faculties on s.InstructorNumber equals f.Number
                           where s.Class.ShortName == "18信管"
                           group f by f.Name into grouping
                           where grouping.Count() > 1
                           orderby grouping.Count() descending, grouping.Key
                           select new
                           {
                               Name = grouping.Key,
                               StudentCount = grouping.Count()
                           };
            foreach (var faculty in results3)
            {
                Console.WriteLine
                        ("导师：{0,-4}\t人数：{1}"
                        , faculty.Name
                        , faculty.StudentCount);
            }

            Console.Read();
        }
    }
}