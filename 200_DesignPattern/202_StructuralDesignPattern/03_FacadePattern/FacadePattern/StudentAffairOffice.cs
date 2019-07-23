using System;

namespace SmartLin.LearningCSharp.FacadePattern
{
    /// <summary>
    /// 学工处；
    /// </summary>
    public class StudentAffairOffice                                                            //定义外观；
    {
        /// <summary>
        /// 迎新；
        /// </summary>
        /// <param name="newStudent">新生</param>
        public static void WelCome(Student newStudent)
        {
            Console.WriteLine("欢迎你，新生{0}。下面为你安排迎新工作：\n", newStudent.Name);
            Dormitory.Assign(newStudent);                                                       //调用子系统；
            Canteen.PayIn(newStudent);
            Library.Active(newStudent);
            Book.Apply(newStudent);
        }
    }
}
