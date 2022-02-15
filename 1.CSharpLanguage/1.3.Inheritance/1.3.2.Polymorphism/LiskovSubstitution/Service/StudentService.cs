namespace SmartLin.LearningCSharp.Inheritance
{
    /// <summary>
    /// 学生服务；
    /// </summary>
    public class StudentService
    {
        /// <summary>
        /// 批量注册；
        /// </summary>
        /// <param name="students">多名学生</param>
        public static void RegisterAll(params Student[] students)               //使用params关键字指定采用数目可变的参数；
        {
            for (int i = 0; i < students.Length; i++)
            {
                students[i].Register();
            }
        }
    }
}
