using System;

namespace SmartLin.LearningCSharp.FacadePattern
{
    /// <summary>
    /// 教材；
    /// </summary>
    public class Book
    {
        /// <summary>
        /// 申领；
        /// </summary>
        /// <param name="newStudent">新生</param>
        public static void Apply(Student newStudent)
        {
            Console.WriteLine("{0}有以下教材需要申领：", newStudent.Name);
            Console.WriteLine("《计算机导论》");
            Console.WriteLine("《C程序设计（第三版）》");
            Console.WriteLine();
        }
    }
}
