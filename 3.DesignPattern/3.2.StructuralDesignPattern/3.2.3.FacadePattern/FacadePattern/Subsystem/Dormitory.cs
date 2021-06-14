using static System.Console;

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
                        WriteLine($"{newStudent.Name}分配至女生宿舍。\n");
                    }
                    break;
                case Gender.MALE:
                    {
                        WriteLine($"{newStudent.Name}分配至男生宿舍。\n");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
