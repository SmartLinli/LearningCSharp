using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
    /// <summary>
    /// 研究生界面；
    /// </summary>
    public static class PostgraduateUi
    {
        /// <summary>
        /// 显示研究生；
        /// </summary>
        /// <param name="postgraduate">研究生</param>
        public static void Display(Postgraduate postgraduate)
        {
            var postgraduateIntroduction =
                $"研究生信息：\n" +
                $"学号：{postgraduate.Number,-15}姓名：{postgraduate.Name}\n" +
                $"性别：{ postgraduate.Gender,-14} 生日：{ postgraduate.BirthDate:D}\n" +
                $"手机号：{postgraduate.PhoneNumber}\n" +
                $"导师：{postgraduate.Supervisor.Name,-12}方向：{postgraduate.Direction}";
            WriteLine(postgraduateIntroduction);
            postgraduate.Intro();
            WriteLine("\n");
        }
    }
}
