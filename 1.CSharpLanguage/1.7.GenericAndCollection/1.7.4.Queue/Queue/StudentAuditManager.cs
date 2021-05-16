using System.Collections.Generic;
using static System.Console;

namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
    /// <summary>
    /// 学生审核；
    /// </summary>
    public class StudentAuditManager
    {
        /// <summary>
        /// 已报名学生；
        /// </summary>
        public Queue<Student> StudentsEntered { get; private set; }                     //定义泛型队列；
        /// <summary>
        /// 已通过学生；
        /// </summary>
        public List<Student> StudentsPassed { get; private set; }
        /// <summary>
        /// 学生报名；
        /// </summary>
        /// <param name="student">学生</param>
        public void EnterStudent(Student student)
        {
            this.StudentsEntered.Enqueue(student);                                      //向队列末端增加元素；
            WriteLine("新报名1人。");
        }
        /// <summary>
        /// 多名学生报名；
        /// </summary>
        /// <param name="students">多名学生</param>
        public void EnterStudents(List<Student> students)
        {
            students.ForEach
                (s => this.StudentsEntered.Enqueue(s));
            WriteLine($"新报名共{students.Count}人。");
        }
        /// <summary>
        /// 审核学生；
        /// </summary>
        public void AuditStudents()
        {
            while (this.StudentsEntered.Count > 0)                                      //若队列中存在元素；
            {
                Student student = this.StudentsEntered.Dequeue();                       //从队列前端读取并删除元素；
                WriteLine
                    ($"学号：{student.Number}，姓名：{student.Name}，是否通过？（Y/N）");
                var input = ReadLine().ToUpper();
                if (input == "Y")
                {
                    this.StudentsPassed.Add(student);
                    Write("审核通过。");
                }
                else
                {
                    Write("审核未通过。");
                }
                WriteLine($"剩余{this.StudentsEntered.Count}人未审核。");
            }
            WriteLine("当前已无未审核学生。");
        }
        /// <summary>
        /// 展示已通过学生；
        /// </summary>
        public void ShowStudentsPassed()
        {
            WriteLine($"以下{this.StudentsPassed.Count}名学生通过审核：");
            this.StudentsPassed.ForEach
                (s => WriteLine($"学号：{s.Number,-15}姓名：{s.Name,-5}"));
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        public StudentAuditManager()
        {
            this.StudentsEntered = new Queue<Student>();
            this.StudentsPassed = new List<Student>();
        }
    }
}
