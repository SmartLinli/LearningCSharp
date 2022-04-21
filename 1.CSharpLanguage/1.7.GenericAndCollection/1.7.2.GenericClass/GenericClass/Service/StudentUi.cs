using static System.Console;

namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
    /// <summary>
    /// 学生界面；
    /// </summary>
    public static class StudentUi
    {
        /// <summary>
        /// 显示学生；
        /// </summary>
        /// <param name="student">学生</param>
        private static void Display(Student student)
        {
            WriteLine
                ($"学号：{student.Number,-15}姓名：{student.Name}\n"
                + $"性别：{student.Gender,-14}生日：{student.BirthDate:D}\n"
                + $"年龄：{student.Age,-15}学籍：{student.Status}");
        }
        /// <summary>
        /// 显示学生；
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="student">学生</param>
        public static void Display(string title, Student student)
        {
            WriteLine($"{title}：");
            if (student == null)
            {
                WriteLine("查无此人");
                return;
            }
            Display(student);
        }
        /// <summary>
        /// 显示多名学生；
        /// </summary>
        /// <param name="students">多名学生</param>
        private static void Display(GenericContainer<Student> students)
        {
            if (students.IsEmpty)
            {
                WriteLine("查无此人");
                return;
            }
            int i = 1;
            foreach (Student student in students)
            {
                Display($"{i}", student);
                i++;
            }
        }
        /// <summary>
        /// 显示多名学生；
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="students">多名学生</param>
        public static void Display(string title, GenericContainer<Student> students)
        {
            WriteLine($"\n{title}：");
            Display(students);
        }
    }
}
