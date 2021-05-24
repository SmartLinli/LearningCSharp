using System.Collections.Generic;

namespace SmartLin.LearningCSharp.TemplateMethod
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
                new Course("2060316","面向对象程序设计",4.5f)
                ,new Course("2060310","动态网站建设",4.5f)
                ,new Course("2060241","计算机网络",4f)
            };
            return courses;
        }
    }
}
