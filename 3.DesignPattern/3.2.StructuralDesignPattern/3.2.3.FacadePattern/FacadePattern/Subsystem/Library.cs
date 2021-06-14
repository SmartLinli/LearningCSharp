using static System.Console;

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
            WriteLine($"读者{newStudent.Name}已激活。\n");
        }
    }
}
