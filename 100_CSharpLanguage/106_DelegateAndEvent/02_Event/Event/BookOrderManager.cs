using System;

namespace SmartLin.LearningCSharp.DelegateAndEvent
{
    /// <summary>
    /// 教材订购服务；
    /// </summary>
    public class BookOrderManager
    {
        /// <summary>
        /// 教材订购数量；
        /// </summary>
        public int BookOrderCount
        {
            get;
            private set;
        }
        /// <summary>
        /// 增订教材；
        /// </summary>
        /// <param name="sender">事件发送方</param>
        /// <param name="e">选课事件参数</param>
        public void AddBookOrder(object sender, SelectCourseEventArgs e)            //注册至事件的函数的签名必须与委托定义一致；
        {
            this.BookOrderCount++;
            Student student = sender as Student;
            Console.WriteLine
                ("\n已为学生{0}增订教材，当前共需订购教材{1}本。"
                , student.Name
                , this.BookOrderCount);
        }
    }
}
