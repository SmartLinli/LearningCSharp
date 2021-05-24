using System;

namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
    /// <summary>
    /// 课程界面；
    /// </summary>
    public class CourseUi : IDisplay<Course>                        //实现泛型接口；
    {
        /// <summary>
        /// 显示；
        /// </summary>
        /// <param name="course">课程</param>
        public void Display(Course course)                          //实现泛型接口中的方法；
        {
            Console.WriteLine
                ("课程信息：\n编号：{0}\n名称：{1}\n学分：{2}\n"
                , course.Number
                , course.Name
                , course.Credit);
        }
    }
}
