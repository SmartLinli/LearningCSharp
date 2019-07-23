using System;

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
        /// <param name="student">研究生</param>
        public static void Display(Postgraduate student)
        {
            Console.WriteLine
                ("研究生信息：\n学号：{0,-15}姓名：{1}\n性别：{2,-14}生日：{3:D}\n年龄：{4,-15}手机号：{5}\n导师：{6,-12}方向：{7}"
                , student.Number
                , student.Name
                , student.Gender == Gender.MALE ? "男" : "女"
                , student.BirthDate
                , student.Age
                , student.PhoneNumber
                , student.Supervisor.Name
                , student.Direction);
            student.Intro();
            Console.WriteLine("\n");
        }
    }
}
