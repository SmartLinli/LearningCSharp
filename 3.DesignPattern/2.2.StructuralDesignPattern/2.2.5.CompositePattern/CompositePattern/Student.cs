
namespace SmartLin.LearningCSharp.CompositePattern
{
    /// <summary>
    /// 学生；
    /// </summary>
    public abstract class Student
    {
        /// <summary>
        /// 学号；
        /// </summary>
        public string Number
        {
            get;
            private set;
        }
        /// <summary>
        /// 姓名；
        /// </summary>
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// 介绍；
        /// </summary>
        /// <param name="level"></param>
        public abstract void Intro(int level);
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">学号</param>
        /// <param name="name">姓名</param>
        public Student(string number, string name)
        {
            this.Number = number;
            this.Name = name;
        }
    }
}
