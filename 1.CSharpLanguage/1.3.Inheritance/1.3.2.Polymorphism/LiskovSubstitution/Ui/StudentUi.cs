using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
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
        public static void Display(Student student)
        {
            var studentIntroduction =
                $"学生信息：\n" +
                $"学号：{student.Number,-15}姓名：{student.Name}\n" +
                $"性别：{student.Gender,-14}生日：{student.BirthDate:D}\n" +
                $"手机号：{student.PhoneNumber}\n" +
                $"学籍：{student.Status}";
            WriteLine(studentIntroduction);
            student.Intro();
            WriteLine("\n");
        }
    }
}
