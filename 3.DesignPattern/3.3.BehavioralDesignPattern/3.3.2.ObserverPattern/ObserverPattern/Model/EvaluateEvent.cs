using System;

namespace SmartLin.LearningCSharp.ObserverPattern
{
    /// <summary>
    /// 评教事件参数；
    /// </summary>
    public class EvaluateEventArgs : EventArgs
    {
        /// <summary>
        /// 教职工（评教对象）
        /// </summary>
        public Faculty Faculty { get; set; }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="faculty">教职工</param>
        public EvaluateEventArgs(Faculty faculty)
        {
            this.Faculty = faculty;
        }
    }
    /// <summary>
    /// 评教事件委托；
    /// </summary>
    /// <param name="sender">事件发送器</param>
    /// <param name="e">评教事件参数</param>
    public delegate void EvaluateEventHandler(object sender, EvaluateEventArgs e);  //定义事件委托；事件处理函数的签名应与事件委托一致；
}
