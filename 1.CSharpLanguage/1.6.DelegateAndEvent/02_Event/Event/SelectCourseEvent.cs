using System;

namespace SmartLin.LearningCSharp.DelegateAndEvent
{
    /// <summary>
    /// 选课事件参数；
    /// </summary>
    public class SelectCourseEventArgs : EventArgs
    {
        /// <summary>
        /// 课程名称；
        /// </summary>
        public string CourseName
        {
            get;
            private set;
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="courseName">课程名称</param>
        public SelectCourseEventArgs(string courseName)
        {
            this.CourseName = courseName;
        }
    }
    /// <summary>
    /// 选课事件委托；
    /// </summary>
    /// <param name="sender">事件发送方</param>
    /// <param name="e">选课事件参数</param>
    public delegate void SelectCourseEventHandler(object sender, SelectCourseEventArgs e);
}