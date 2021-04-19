using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
    /// <summary>
    /// 随机分配导师；
    /// </summary>
    public class AssignInstructorByRandom : IStudentInstructorService
    {
        /// <summary>
        /// 分配；
        /// </summary>
        public void Assign()
        {
            WriteLine("将从本学院教职工中随机分配导师……\n");
        }
    }
}
