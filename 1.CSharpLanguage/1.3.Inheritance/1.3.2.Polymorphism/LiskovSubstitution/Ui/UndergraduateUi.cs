using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
    /// <summary>
    /// 本科生界面；
    /// </summary>
    public static class UndergraduateUi
    {
        /// <summary>
        /// 显示本科生；
        /// </summary>
        /// <param name="undergraduate">本科生</param>
        public static void Display(Undergraduate undergraduate)
        {
            var undergraduateIntroduction =
                $"本科生信息：\n学号：{undergraduate.Number,-15}姓名：{undergraduate.Name}\n" +
                $"性别：{undergraduate.Gender,-14}生日：{undergraduate.BirthDate:D}\n" +
                $"手机号：{undergraduate.PhoneNumber}\n" +
                $"班级：{undergraduate.Class,-13}本科生导师：{undergraduate.Instructor.Name}";
            WriteLine(undergraduateIntroduction);
            undergraduate.Intro();
            WriteLine("\n");
        }
    }
}
