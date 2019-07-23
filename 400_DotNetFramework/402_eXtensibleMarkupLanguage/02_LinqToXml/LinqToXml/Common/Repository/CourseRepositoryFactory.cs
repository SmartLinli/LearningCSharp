using System;
using System.Reflection;

namespace SmartLin.LearningCSharp.eXtensibleMarkupLanguage
{
    /// <summary>
    /// 课程仓储工厂；
    /// </summary>
    public class CourseRepositoryFactory
    {
        /// <summary>
        /// 创建仓储；
        /// </summary>
        /// <returns>课程仓储</returns>
        public static IRepository<Course> CreateRepository()
        {
            string repositoryTypeName = "XmlCourseRepository";
            string currentNamespace = MethodBase.GetCurrentMethod().DeclaringType.Namespace;
            Type repositoryType = Type.GetType(currentNamespace + "." + repositoryTypeName);
            IRepository<Course> courseRepository = (IRepository<Course>)Activator.CreateInstance(repositoryType);
            return courseRepository;
        }
    }
}
