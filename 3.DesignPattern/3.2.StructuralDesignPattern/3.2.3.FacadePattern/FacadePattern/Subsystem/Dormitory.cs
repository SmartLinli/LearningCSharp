using System;

namespace SmartLin.LearningCSharp.FacadePattern
{
    /// <summary>
    /// 宿舍；
    /// </summary>
    public class Dormitory
    {
        /// <summary>
        /// 分配；
        /// </summary>
        /// <param name="newStudent">新生</param>
        public static void Assign(Student newStudent)
        {
            switch (newStudent.Gender)
            {
                case Gender.FEMALE:
                    {
                        Console.WriteLine("{0}分配至女生宿舍。\n", newStudent.Name);
                    }
                    break;
                case Gender.MALE:
                    {
                        Console.WriteLine("{0}分配至男生宿舍。\n", newStudent.Name);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
