using System;

namespace SmartLin.LearningCSharp.Array
{
    /// <summary>
    /// 学生；
    /// </summary>
    public class Student : IComparable
    {
        /// <summary>
        /// 学号；
        /// </summary>
        public string Number { get; private set; }
        /// <summary>
        /// 姓名；
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 比较；
        /// </summary>
        /// <param name="obj">对象</param>
        /// <returns>大小</returns>
        public int CompareTo(object obj)
        {
            Student otherStudent = obj as Student;
            int result = this.Number.CompareTo(otherStudent.Number);
            if (result == 0)
            {
                result = this.Name.CompareTo(otherStudent.Name);
            }
            return result;
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">学号</param>
        /// <param name="name">姓名</param>
        public Student(string number, string name)
        {
            this.Number = number;
            this.Name = name;
        }
    }
}