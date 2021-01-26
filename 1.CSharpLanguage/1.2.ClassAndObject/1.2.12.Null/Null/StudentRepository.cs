namespace SmartLin.LearningCSharp.ClassAndObject
{
    /// <summary>
    /// 学生仓储；
    /// </summary>
    public class StudentRepository
    {
        /// <summary>
        /// 查询学生；
        /// </summary>
        /// <param name="number">学号</param>
        /// <returns>学生</returns>
        public static Student GetStudent(string number)
        {
            if (number == "3210707001")
                return new Student("3210707001", "张三");
            else
                return null;
        }
    }
}
