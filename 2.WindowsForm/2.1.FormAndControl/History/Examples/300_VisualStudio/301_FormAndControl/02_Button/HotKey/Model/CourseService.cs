using System.Collections.Generic;

namespace SmartLin.LearningCSharp.FormAndControl
{
    /// <summary>
    /// 课程服务；
    /// </summary>
    public class CourseService
    {
        /// <summary>
        /// 课程；
        /// </summary>
        private static List<Course> _Courses;
        /// <summary>
        /// 最小序号；
        /// </summary>
        private static readonly int _MinIndex ;
        /// <summary>
        /// 最大序号；
        /// </summary>
        private static  readonly int _MaxIndex;
        /// <summary>
        /// 当前序号；
        /// </summary>
        private static int _Index = 0;
        /// <summary>
        /// 是否存在下一条；
        /// </summary>
        public static bool HasNext
        {
            get
            {
                return _Index < _MaxIndex;
            }
        }
        /// <summary>
        /// 是否存在上一条；
        /// </summary>
        public static bool HasPrevious
        {
            get
            {
                return _Index > _MinIndex;
            }
        }
        /// <summary>
        /// 下一条；
        /// </summary>
        /// <returns></returns>
        public static Course Next()
        {
            if (!HasNext)
            {
                return _Courses[_MaxIndex];
            }
            _Index++;
            return _Courses[_Index];
        }
        /// <summary>
        /// 上一条；
        /// </summary>
        /// <returns></returns>
        public static Course Previous()
        {
            if (!HasPrevious)
            {
                return _Courses[_MinIndex];
            }
            _Index--;
            return _Courses[_Index];
        }
        /// <summary>
        /// 获取当前课程；
        /// </summary>
        /// <returns></returns>
        public static Course GetCurrentCourse()
        {
            return _Courses[_Index];
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        static CourseService()
        {
            _Courses = new List<Course>()
            {
                  new Course("2060316","高等数学"),
                  new Course("2060310","线性代数"),
                  new Course("2060241","军事理论"),
                  new Course("2060089","英语1")
            };
            _MinIndex = 0;
            _MaxIndex = _Courses.Count - 1;
            _Index = 0;
        }
    }
}
