using System.Collections.Generic;

namespace SmartLin.LearningCSharp.BuilderPattern
{
    /// <summary>
    /// 课程仓储；
    /// </summary>
    public class CourseRepository
    {
        /// <summary>
        /// 获取所有；
        /// </summary>
        /// <returns>课程</returns>
        public static List<Course> GetAll()
        {
            List<Course> courses = new List<Course>()
            {
                new Course("2060089", "英语1", 4f),
                new Course("1190012", "军事理论", 2f),
                new Course("2020136", "线性代数", 2.5f)
            };
            return courses;
        }
    }
}
