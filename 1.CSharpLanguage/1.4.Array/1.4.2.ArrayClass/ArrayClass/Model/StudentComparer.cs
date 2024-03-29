﻿using System.Collections.Generic;

namespace SmartLin.LearningCSharp.ArrayClass
{
    /// <summary>
    /// 学生比较器类型；
    /// </summary>
    public enum StudentComparerType                                             //使用枚举表达不同的排序选项；
    {
        NUMBER,
        NAME
    }
    /// <summary>
    /// 学生比较器；
    /// </summary>
    public class StudentComparer : IComparer<Student>                           //该类实现IComparer<>接口，用于实现更多排序选项；
    {
        /// <summary>
        /// 比较类型
        /// </summary>
        public StudentComparerType Type { get; private set; }
        /// <summary>
        /// 比较
        /// </summary>
        /// <param name="student">学生</param>
        /// <param name="otherStudent">另一学生</param>
        /// <returns>大小</returns>
        public int Compare(Student student, Student otherStudent)               //实现IComparer<>接口的方法Compare，用于实现更多排序选项；
        {
            if (otherStudent is null)                                           //该方法不会跳过空值，必须自行处理空值，否则比较时将导致异常；
            {
                otherStudent = new Student(string.Empty, string.Empty);
            }
            switch (this.Type)
            {
                case StudentComparerType.NUMBER:
                    return student.Number.CompareTo(otherStudent.Number);
                case StudentComparerType.NAME:
                    return student.Name.CompareTo(otherStudent.Name);
                default:
                    return 0;
            }
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="type">比较类型</param>
        public StudentComparer(StudentComparerType type)
        {
            this.Type = type;
        }
    }
}
