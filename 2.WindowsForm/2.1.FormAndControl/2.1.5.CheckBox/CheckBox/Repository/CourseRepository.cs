namespace SmartLin.LearningCSharp.FormAndControl
{
    /// <summary>
    /// 课程仓储；
    /// </summary>
    public class CourseRepository
    {
        /// <summary>
        /// 查找；
        /// </summary>
        /// <param name="number">课程号</param>
        /// <returns>课程</returns>
        public static Course Find(string number)
        {
            return new Course("2060316", "面向对象程序设计", 4.5f) { IsAvailable = true, HasExperiment = true, HasMooc = false };
        }
    }
}
