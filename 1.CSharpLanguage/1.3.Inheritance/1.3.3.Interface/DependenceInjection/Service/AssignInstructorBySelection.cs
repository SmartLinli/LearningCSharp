using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
    /// <summary>
    /// 按志愿分配导师；
    /// </summary>
    public class AssignInstructorBySelection : IStudentInstructorService
    {
        /// <summary>
        /// 分配；
        /// </summary>
        public void Assign()
        {
            WriteLine("请依次输入3位意向导师，系统将根据输入的志愿分配导师……\n");
        }
    }
}
