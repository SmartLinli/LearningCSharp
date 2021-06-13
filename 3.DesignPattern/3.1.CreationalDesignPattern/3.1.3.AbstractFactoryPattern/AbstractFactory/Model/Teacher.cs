using System;
using static System.Console;

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
        public string Number { get; set; }
        /// <summary>
        /// 姓名；
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 显示结果；
        /// </summary>
        public void ShowResult()
        {
            WriteLine($"笔试监考人员为：{this.Name}{Environment.NewLine}");
        }
    }
}
