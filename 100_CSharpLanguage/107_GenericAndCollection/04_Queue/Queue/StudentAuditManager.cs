using System;
using System.Collections.Generic;

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
        public Queue<Student> StudentsEntered                                           //定义泛型队列；
        {
            get;
            private set;
        }            
        /// <summary>
        /// 已通过学生；
        /// </summary>
        public List<Student> StudentsPassed
        {
            get;
            private set;
        }
        /// <summary>
        /// 学生报名；
        /// </summary>
        /// <param name="student">学生</param>
        public void EnterStudent(Student student)
        {
            this.StudentsEntered.Enqueue(student);                                      //向队列末端增加元素；
            Console.WriteLine("新报名1人。");
        }
        /// <summary>
        /// 多名学生报名；
        /// </summary>
        /// <param name="students">多名学生</param>
        public void EnterStudents(List<Student> students)
        {
            foreach (Student student in students)
            {
                this.StudentsEntered.Enqueue(student);
            }
            Console.WriteLine("新报名共{0}人。", students.Count);
        }
        /// <summary>
        /// 审核学生；
        /// </summary>
        public void AuditStudents()
        {
            while (this.StudentsEntered.Count > 0)                                      //若队列中存在元素；
            {
                Student currentStudent = this.StudentsEntered.Dequeue();                //从队列前端读取并删除元素；
                Console.WriteLine
                    ("学号：{0}，姓名：{1}，是否通过？（Y/N）", currentStudent.Number, currentStudent.Name);
                var input = Console.ReadLine().ToUpper();
                if (input == "Y")
                {
                    this.StudentsPassed.Add(currentStudent);
                    Console.Write("审核通过。");
                }
                else
                {
                    Console.Write("审核未通过。");
                }
                Console.WriteLine("剩余{0}人未审核。", this.StudentsEntered.Count);
            }
            Console.WriteLine("当前已无未审核学生。");
        }
        /// <summary>
        /// 展示已通过学生；
        /// </summary>
        public void ShowStudentsPassed()
        {
            Console.WriteLine("以下{0}名学生通过审核：", this.StudentsPassed.Count);
            this.StudentsPassed.ForEach
                (s =>
                {
                    Console.WriteLine
                        ("学号：{0,-15}姓名：{1,-5}"
                        , s.Number
                        , s.Name);
                });
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
