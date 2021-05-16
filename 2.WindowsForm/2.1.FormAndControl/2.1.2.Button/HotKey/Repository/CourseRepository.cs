namespace SmartLin.LearningCSharp.FormAndControl
{
    /// <summary>
    /// 课程仓储；
    /// </summary>
    public class CourseRepository
    {
        /// <summary>
        /// 查找课程；
        /// </summary>
        /// <param name="number">编号</param>
        /// <returns>课程</returns>
        public static Course Find(string number)
        {
            return new Course("2060316", "高等数学");
        }
    }
}
