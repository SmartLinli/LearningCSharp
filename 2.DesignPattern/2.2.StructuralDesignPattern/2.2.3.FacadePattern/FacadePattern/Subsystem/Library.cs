using System;

namespace SmartLin.LearningCSharp.FacadePattern
{
    /// <summary>
    /// 图书馆；
    /// </summary>
    public class Library
    {
        /// <summary>
        /// 激活； 
        /// </summary>
        /// <param name="newStudent">新生</param>
        public static void Active(Student newStudent)
        {
            Console.WriteLine("读者{0}已激活。\n", newStudent.Name);
        }
    }
}
