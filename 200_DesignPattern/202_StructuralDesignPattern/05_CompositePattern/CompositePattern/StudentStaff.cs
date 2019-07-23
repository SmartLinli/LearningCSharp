using System;

namespace SmartLin.LearningCSharp.CompositePattern
{
    /// <summary>
    /// 学生干事；
    /// </summary>
    public class StudentStaff : Student                                         //定义叶节点；
    {
        /// <summary>
        /// 介绍；
        /// </summary>
        /// <param name="level">层级</param>
        public override void Intro(int level)
        {
            Console.WriteLine
                  (new string('-', level)
                  + string.Format("{0}", this.Name));
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">学号</param>
        /// <param name="name">姓名</param>
        public StudentStaff(string number, string name)
            : base(number, name)
        {
            ;
        }
    }
}
