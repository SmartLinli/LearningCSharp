using static System.Console;

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
        public static void RegisterAll(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                students[i].Register();
                WriteLine
                    ($"{students[i].Name}当前学籍为“{students[i].Status}”");
            }
        }
    }
}
