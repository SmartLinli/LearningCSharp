using System;

namespace SmartLin.LearningCSharp.Inheritance
{
    /// <summary>
    /// 教职工界面；
    /// </summary>
    public static class FacultyUi
    {
        /// <summary>
        /// 显示教职工；
        /// </summary>
        /// <param name="faculty">教职工</param>
        public static void Display(Faculty faculty)
        {
            Console.WriteLine
                ("教职工信息：\n工号：{0,-15}姓名：{1}\n性别：{2,-14}生日：{3:D}\n年龄：{4,-15}手机号：{5}\n部门：{6}\n专长：{7}"
                , faculty.Number
                , faculty.Name
                , faculty.Gender == Gender.MALE ? "男" : "女"
                , faculty.BirthDate
                , faculty.Age
                , faculty.PhoneNumber
                , faculty.Department.Name
                , faculty.Speciality);
            faculty.Intro();
            Console.WriteLine("\n");
        }
    }
}
