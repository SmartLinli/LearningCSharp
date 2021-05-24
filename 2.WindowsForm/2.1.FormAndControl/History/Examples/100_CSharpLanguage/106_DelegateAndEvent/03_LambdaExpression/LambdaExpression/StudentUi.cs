using System;

namespace SmartLin.LearningCSharp.DelegateAndEvent
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
            Console.WriteLine
                ("学号：{0,-15}姓名：{1}\n性别：{2,-14}生日：{3:D}\n年龄：{4,-15}手机号：{5}"
                , student.Number
                , student.Name
                , student.Gender == Gender.MALE ? "男" : "女"
                , student.BirthDate
                , student.Age
                , student.PhoneNumber);
        }
        /// <summary>
        /// 显示学生；
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="student">学生</param>
        public static void Display(string title, Student student)
        {
            if (student != null)
            {
                Console.WriteLine(title + "：");
                Display(student);
            }
        }
        /// <summary>
        /// 显示多名学生；
        /// </summary>
        /// <param name="students">多名学生</param>
        private static void Display(Student[] students)
        {
            int i = 1;
            foreach (Student student in students)
            {
                string title = string.Format("{0}", i);
                Display(title, student);
                i++;
            }
        }
        /// <summary>
        /// 显示多名学生；
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="students">多名学生</param>
        public static void Display(string title, Student[] students)
        {
            Console.WriteLine("\n" + title + "：");
            Display(students);
        }
    }
}
