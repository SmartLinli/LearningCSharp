﻿
namespace SmartLin.LearningCSharp.FormAndControl
{
    /// <summary>
    /// 课程仓储；
    /// </summary>
    public class CourseRepository
    {
        /// <summary>
        /// 获取；
        /// </summary>
        /// <returns>课程</returns>
        public static Course Get()
        {
            return new Course("2060316", "面向对象程序设计", 4.5f);
        }
    }
}
