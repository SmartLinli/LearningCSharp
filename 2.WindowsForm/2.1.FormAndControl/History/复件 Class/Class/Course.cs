using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.Oop
{
    public class Course
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
        public Student[] Students
        {
            get;
            set;
        }
        public void EnterStudentsScore()
        {
            foreach (var student in this.Students)
            {
                Console.Write("\t学号：{0}\t姓名：{1}\n", student.Number, student.Name);
                student.Score.Save();
            }
            Console.Write("完成录入《{0}》成绩。\n", this.Name);
        }
        public void ShowStudentsScore()
        {
            foreach (var student in this.Students)
            {
                Console.Write("\t学号：{0}\t姓名：{1}\t成绩：{2}\n", student.Number, student.Number, student.Score.Value);
            }
        }
        public Course(string number, string name)
        {
            this.Number = number;
            this.Name = name;
        }
    }
}
