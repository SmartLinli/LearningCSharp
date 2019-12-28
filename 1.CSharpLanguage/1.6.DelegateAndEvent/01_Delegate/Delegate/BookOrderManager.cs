using static System.Console;

namespace SmartLin.LearningCSharp.DelegateAndEvent
{
    /// <summary>
    /// 教材订购管理；
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
        /// <param name="student">学生</param>
        /// <param name="courseName">课程名称</param>
        public void AddBookOrder(Student student, string courseName)            //注册至委托对象的函数的签名必须与委托定义一致；
        {
            this.BookOrderCount++;
			WriteLine($"\n已为学生{student.Name}增订教材，当前共需订购教材{this.BookOrderCount}本。");
		}
    }
}
