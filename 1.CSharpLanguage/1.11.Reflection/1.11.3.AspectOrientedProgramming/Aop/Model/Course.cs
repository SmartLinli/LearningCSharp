using System;

namespace SmartLin.LearningCSharp.Reflection
{
    /// <summary>
    /// 课程；
    /// </summary>
    [Validation("Course")]
    public class Course : ContextBoundObject                                    //继承ContextBoundObject类，用于远程应用访问该对象；
    {
        /// <summary>
        /// 课程号；
        /// </summary>
        public string Number
        {
            get;
            [StringValidation(7, Description = "课程号")]
            private set;
        }
        /// <summary>
        /// 名称；
        /// </summary>
        public string Name
        {
            get;
            [StringValidation(10, Description = "课程名称")]
            private set;
        }
        /// <summary>
        /// 学分；
        /// </summary>
        public float Credit
        {
            get;
            set;
        }
        /// <summary>
        /// 创建；
        /// </summary>
        /// <param name="number">课程号</param>
        /// <param name="name">名称</param>
        /// <param name="credit">学分</param>
        public static Course Create(string number, string name, float credit)
        {
            Course newCourse = new Course();
            newCourse.Number = number;
            newCourse.Name = name;
            newCourse.Credit = credit;
            return newCourse;
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        private Course()
        {
            ;
        }
    }
}
