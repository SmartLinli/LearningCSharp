using System.Collections.Generic;

namespace SmartLin.LearningCSharp.FactoryPattern
{
    /// <summary>
    /// 教师仓储；
    /// </summary>
    public class TeacherRepository
    {
        /// <summary>
        /// 获取所有；
        /// </summary>
        /// <returns>教师</returns>
        public static List<Teacher> GetAll()
        {
            List<Teacher> teachers = new List<Teacher>()
            {
               new Teacher()
               {
                   Number="2004034",
                   Name="林立"
               },
               new Teacher()
               {
                   Number="2004034",
                   Name="陈林"
               },
               new Teacher()
               {
                   Number="2004013",
                   Name="林翰"
               },
               new Teacher()
               {
                   Number="2005003",
                   Name="陈斯歆"
               }
            };
            return teachers;
        }
    }
}
