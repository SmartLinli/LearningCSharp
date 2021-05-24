using System;

namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
    /// <summary>
    /// 学生界面；
    /// </summary>
    public class StudentUi : IDisplay<Student>                              //实现泛型接口；
    {
        /// <summary>
        /// 显示；
        /// </summary>
        /// <param name="student">学生</param>
        public void Display(Student student)                                //实现泛型接口中的方法；
        {
            Console.WriteLine
                ("在校生信息：\n学号：{0,-15}姓名：{1,-15}性别：{2}"
                , student.Number
                , student.Name
                , student.Gender == Gender.MALE ? "男" : "女");
        }
    }
}
