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
            var results0 = from s in students
                           select s;
            foreach (Student student in results0)
            {
                Console.WriteLine
                        ("学号：{0,-12}姓名：{1,-4}\t班级：{2}"
                        , student.Number
                        , student.Name
                        , student.Class);
            }

            Console.WriteLine("查询所有学生的基本信息：");
            var results02 = from s in students
                            select new
                            {
                                Number = s.Number,
                                Name = s.Name,
                                Class = s.Class
                            };
            foreach (var student in results02)
            {
                Console.WriteLine
                        ("学号：{0,-12}姓名：{1,-4}\t班级：{2}"
                        , student.Number
                        , student.Name
                        , student.Class);
            }

            Console.WriteLine("\n查询18公管的学生：");
            var results = from s in students
                          where s.Class.ShortName == "18公管"
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
                                 .FirstOrDefault();
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
                           from c in s.LearningCourses
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

            Console.WriteLine("\n对所有学生按照性别、生日（由早到晚）排序：");
            var results4 = from s in students
                           orderby s.Gender descending, s.BirthDate
                           select s;
            foreach (Student student in results4)
            {
                Console.WriteLine
                        ("学号：{0,-12}姓名：{1,-4}\t性别：{2,-3}生日：{3}"
                        , student.Number
                        , student.Name
                        , student.Gender == Gender.MALE ? "男" : "女"
                        , student.BirthDate.Value.ToLongDateString());
            }

            Console.WriteLine("\n查询各班的学生人数：");
            var results5 = from s in students
                           group s by s.Class into grouping
                           select new { Name = grouping.Key, StudentCount = grouping.Count() };
            foreach (var currentClass in results5)
            {
                Console.WriteLine
                        ("班级：{0,-6}人数：{1}"
                        , currentClass.Name
                        , currentClass.StudentCount);
            }

            Console.WriteLine("\n查询各班的学生人数与名单：");
            var results6 = from s in students
                           group s by s.Class into grouping
                           select new
                           {
                               Name = grouping.Key,
                               StudentCount = grouping.Count(),
                               Students = from s2 in grouping orderby s2.Number select s2.Name
                           };
            foreach (var currentClass in results6)
            {
                Console.WriteLine
                        ("【班级：{0,-6}人数：{1}】"
                        , currentClass.Name
                        , currentClass.StudentCount);
                foreach (var student in currentClass.Students)
                {
                    Console.Write("{0} ", student);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n查询人数在10人以上的班级与学生人数，并按人数降序排序：");
            var results7 = from s in students
                           group s by s.Class into grouping
                           where grouping.Count() >= 10
                           orderby grouping.Count() descending
                           select new { Name = grouping.Key, StudentCount = grouping.Count() };
            foreach (var currentClass in results7)
            {
                Console.WriteLine
                        ("班级：{0,-6}人数：{1}"
                        , currentClass.Name
                        , currentClass.StudentCount);
            }

            Console.WriteLine("\n查询各班学生的平均身高、体重：");
            var results8 = from s in students
                           group s by s.Class into grouping
                           select new
                           {
                               Name = grouping.Key,
                               HeightAverage = (from s2 in grouping select s2.Height).Average(),
                               WeightAverage = (from s2 in grouping select s2.Weight).Average()
                           };
            foreach (var currentClass in results8)
            {
                Console.WriteLine
                        ("班级：{0,-6}平均身高：{1,-8:F}平均体重：{2:F}"
                        , currentClass.Name
                        , currentClass.HeightAverage
                        , currentClass.WeightAverage);
            }

            Console.WriteLine("\n查询各班男生的平均体重，并筛选出平均体重在62以上的班级：");
            var results9 = from s in students
                           where s.Gender == Gender.MALE
                           group s by s.Class into grouping
                           where (from s2 in grouping select s2.Weight).Average() > 62f
                           select new
                           {
                               Name = grouping.Key,
                               WeightAverage = (from s2 in grouping select s2.Weight).Average()
                           };
            foreach (var currentClass in results9)
            {
                Console.WriteLine
                        ("班级：{0,-6}男生平均体重：{1:F}"
                        , currentClass.Name
                        , currentClass.WeightAverage);
            }

            Console.WriteLine("\n查询各班男女生的平均身高、体重：");
            var results10 = from s in students
                            group new { s.Class.ShortName, s.Gender, s.Height, s.Weight }
                                by new { s.Class, s.Gender }
                                into grouping
                                orderby grouping.Key.Class descending, grouping.Key.Gender descending
                                select new
                                {
                                    Name = grouping.Key.Class,
                                    Gender = grouping.Key.Gender == Gender.MALE ? "男" : "女",
                                    HeightAverage = (from s2 in grouping select s2.Height).Average(),
                                    WeightAverage = (from s2 in grouping select s2.Weight).Average()
                                };
            foreach (var currentClass in results10)
            {
                Console.WriteLine
                        ("班级：{0,-6}{1}生平均身高：{2,-8:F}{1}生平均体重：{3:F}"
                        , currentClass.Name
                        , currentClass.Gender
                        , currentClass.HeightAverage
                        , currentClass.WeightAverage);
            };

            Console.WriteLine("\n查询每名学生的导师：");
            List<Faculty> faculties = FacultyRepository.GetAllFaculties();
            var results11 = from s in students
                            join f in faculties on s.InstructorNumber equals f.Number
                            select new
                            {
                                Name = s.Name,
                                Class = s.Class,
                                Instructor = f.Name,
                                InstructorPhone = f.PhoneNumber
                            };
            foreach (var student in results11)
            {
                Console.WriteLine
                        ("学生：{0,-4}\t班级：{1,-7}导师：{2}\t电话：{3}"
                        , student.Name
                        , student.Class
                        , student.Instructor
                        , student.InstructorPhone);
            }

            Console.WriteLine("\n查询18信管每位导师指导的学生人数：");
            var results12 = from s in students
                            join f in faculties on s.InstructorNumber equals f.Number
                            where s.Class.ShortName == "18信管"
                            group f by f.Name into grouping
                            select new
                            {
                                Name = grouping.Key,
                                StudentCount = grouping.Count()
                            };
            foreach (var faculty in results12)
            {
                Console.WriteLine
                        ("导师：{0,-4}\t人数：{1}"
                        , faculty.Name
                        , faculty.StudentCount);
            }

            Console.WriteLine("\n分页查询学生：");
            int
                pageSize = 5
                , previousPageIndex = 7;
            var results13 = (from s in students
                             select s)
                          .Skip(previousPageIndex * pageSize).Take(pageSize);
            foreach (var student in results13)
            {
                Console.WriteLine
                        ("学号：{0,-12}姓名：{1,-4}\t班级：{2}"
                        , student.Number
                        , student.Name
                        , student.Class);
            }

            Console.WriteLine("\n首次查询18信管的学生：");
            var results15 = from s in students
                            where s.Class.ShortName == "18信管"
                            select s;
            foreach (var student in results15)
            {
                Console.WriteLine
                        ("学号：{0,-12}姓名：{1,-4}\t班级：{2}"
                        , student.Number
                        , student.Name
                        , student.Class);
            }
            students.RemoveRange(0, 5);
            Console.WriteLine("二次查询18信管的学生：");
            foreach (var student in results15)
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
