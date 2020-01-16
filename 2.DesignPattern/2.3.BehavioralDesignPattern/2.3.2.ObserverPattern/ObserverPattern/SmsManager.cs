using System;

namespace SmartLin.LearningCSharp.ObserverPattern
{
    /// <summary>
    /// 短信管理器；
    /// </summary>
    public class SmsManager
    {
        /// <summary>
        /// 通知
        /// </summary>
        /// <param name="sender">事件发送器</param>
        /// <param name="e">评教事件参数</param>
        public void Inform(object sender, EvaluateEventArgs e)
        {
            Student student = sender as Student;
            Faculty faculty = e.Faculty;
            Console.WriteLine
                ("\n发送短信至手机{0}：学生{1}已对您评教。\n"
                , faculty.PhoneNumber
                , student.Name);
        }
    }
}
