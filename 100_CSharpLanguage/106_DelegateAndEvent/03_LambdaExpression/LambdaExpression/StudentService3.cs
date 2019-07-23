﻿
namespace SmartLin.LearningCSharp.DelegateAndEvent
{
    /// <summary>
    /// 学生服务；
    /// </summary>
    public static partial class StudentService
    {
        /// <summary>
        /// 匹配；
        /// </summary>
        /// <param name="student">学生</param>
        /// <returns>是否匹配</returns>
        public delegate bool Match(Student student);                                        //定义委托；
        /// <summary>
        /// 操作委托；
        /// </summary>
        /// <param name="student">学生</param>
        public delegate void Operation(Student student);                                    //定义委托；
        /// <summary>
        /// 按指定条件查找；
        /// </summary>
        /// <param name="students">多名学生</param>
        /// <param name="match">匹配</param>
        /// <returns>多名学生</returns>
        public static Student[] Find(this Student[] students, Match match)                  //使用委托作为参数；
        {
            Student[] tempResults = new Student[students.Length];
            int tempResultCount = 0;
            foreach (Student student in students)
            {
                if (match(student))                                                         //调用委托；
                {
                    tempResults[tempResultCount] = student;
                    tempResultCount++;
                }
            }
            Student[] results = new Student[tempResultCount];
            int resultsCount = 0;
            foreach (Student student in tempResults)
            {
                if (student != null)
                {
                    results[resultsCount] = student;
                    resultsCount++;
                }
            }
            return results;
        }
        /// <summary>
        /// 修改；
        /// </summary>
        /// <param name="students">多名学生</param>
        /// <param name="modify">修改</param>
        /// <returns>多名学生</returns>
        public static Student[] Modify(this Student[] students, Operation modify)           //使用委托作为参数；
        {
            foreach (Student student in students)
            {
                modify(student);                                                                    //调用委托；
            }
            return students;
        }
    }
}
