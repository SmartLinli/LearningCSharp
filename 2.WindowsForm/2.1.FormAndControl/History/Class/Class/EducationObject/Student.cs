using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.Oop
{
    public class Student
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
        public LearningTask[] LearningTasks
        {
            get;
            set;
        }

        public void ShowAllCourses()
        {
            Console.WriteLine("本学期修读课程如下：");
            for (int i = 0; i < this.LearningTasks.Count(); i++)
            {
                LearningTask learningTask = this.LearningTasks[i];
                Console.WriteLine
                    ("\t序号：{0}\t课程：{1}\t教师：{2}\t{3}",
                    (i + 1).ToString(),
                    learningTask.Course.Name,
                    learningTask.Faculty.Name,
                    learningTask.GetFinalScoreResult());
            }
        }
        public void InputCourseRate()
        {
            this.ShowAllCourses();
            Console.Write("请输入要评教的课程序号：");
            var input = Console.ReadLine();
            int index = 0;
            int.TryParse(input, out index);
            this.LearningTasks[index - 1].SaveRate();
        }
        public Student(string number, string name)
        {
            this.Number = number;
            this.Name = name;
        }
    }
}
