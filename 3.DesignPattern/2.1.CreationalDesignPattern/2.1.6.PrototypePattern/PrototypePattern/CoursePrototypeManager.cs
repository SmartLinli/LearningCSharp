using System.Collections.Generic;

namespace SmartLin.LearningCSharp.PrototypePattern
{
    /// <summary>
    /// 课程原型管理器；
    /// </summary>
    public class CoursePrototypeManager
    {
        /// <summary>
        /// 课程栈；
        /// </summary>
        private Stack<Course> _Courses = new Stack<Course>();
        /// <summary>
        /// 是否存在备份；
        /// </summary>
        public bool HasBackup
        {
            get
            {
                return this._Courses.Count > 0;
            }
        }
        /// <summary>
        /// 备份
        /// </summary>
        /// <param name="currentCourse">当前课程</param>
        /// <returns>课程复制品</returns>
        public Course Backup(Course currentCourse)
        {
            this._Courses.Push(currentCourse);
            return (Course)currentCourse.Clone();
        }
        /// <summary>
        /// 还原
        /// </summary>
        /// <returns>课程备份</returns>
        public Course Restore()
        {
            return this._Courses.Pop();
        }
    }
}
