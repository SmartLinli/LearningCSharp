using System;

namespace SmartLin.LearningCSharp.FactoryPattern
{
    /// <summary>
    /// 教师；
    /// </summary>
    public class Teacher : IInvigilator
    {
        /// <summary>
        /// 工号；
        /// </summary>
        public string Number
        {
            get;
            set;
        }
        /// <summary>
        /// 姓名；
        /// </summary>
        public string Name
        {
            get;
            set;
        }
        public void ShowResult()
        {
            Console.WriteLine("\n笔试监考人员为：{0}\n", this.Name);
        }
    }
}
