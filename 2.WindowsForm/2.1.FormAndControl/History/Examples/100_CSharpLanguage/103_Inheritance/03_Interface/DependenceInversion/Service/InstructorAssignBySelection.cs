using System;

namespace SmartLin.LearningCSharp.Inheritance
{
    /// <summary>
    /// 导师按志愿分配；
    /// </summary>
    public class InstructorAssignBySelection : IInstructorAssignService
    {
        /// <summary>
        /// 分配；
        /// </summary>
        public void Assign()
        {
            Console.WriteLine("请依次输入3位意向导师，系统将根据输入的志愿分配导师。\n");
        }
    }
}
