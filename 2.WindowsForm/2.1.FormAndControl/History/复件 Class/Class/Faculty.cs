using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.Oop
{
    public class Faculty
    {
        public string Number
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public Course[] Courses
        {
            get;
            set;
        }
        public void ShowCourses()
        {
            Console.Write("{0}老师，欢迎使用教务系统。\n本学期您的任教课程有：\n", this.Name);
            foreach (var course in this.Courses)
            {
                Console.Write("\t课程号：{0}\t名称：《{1}》\n", course.Number, course.Name);
            }
        }
        public Course FindCourse()
        {
            Course courseFound = null;
            Console.Write("请输入课程号并开始录入成绩：\n");
            {
                var inputCourseNumber = Console.ReadLine();
                if (inputCourseNumber == "")
                {
                    Console.Write("未输入课程号。\n"); 
                    return courseFound;
                }
                courseFound = (from c in this.Courses
                                      where c.Number == inputCourseNumber
                                      select c).FirstOrDefault();
                if (courseFound != null)
                {
                    Console.Write("开始录入《{0}》成绩：\n", courseFound.Name); 
                    return courseFound;
                }
                else
                {
                    Console.Write("课程号不存在。\n");
                    return courseFound;
                }
            }
        }
        public Faculty(string number, string name)
        {
            this.Number = number;
            this.Name = name;
        }
    }
}
