using static System.Console;

namespace SmartLin.LearningCSharp.ObserverPattern
{
    /// <summary>
    /// 成绩；
    /// </summary>
    public class Score
    {
        /// <summary>
        /// 数值；
        /// </summary>
        private decimal _Numeral;
        /// <summary>
        /// 是否已评教；
        /// </summary>
        public bool HasEvaluated { get; private set; }
        /// <summary>
        /// 查询成绩；
        /// </summary>
        public void GetScore()
        {
            if (this.HasEvaluated)
            {
                WriteLine($"成绩查询结果：{this._Numeral}。\n");
            }
            else
            {
                WriteLine($"尚未评教，无法查询成绩！\n");
            }
        }
        /// <summary>
        /// 开放查询；
        /// </summary>
        /// <param name="sender">事件发送器</param>
        /// <param name="e">评教事件参数</param>
        public void Open(object sender, EvaluateEventArgs e)
        {
            this.HasEvaluated = true;
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="numeral">数值</param>
        public Score(decimal numeral)
        {
            this._Numeral = numeral;
            this.HasEvaluated = false;
        }
    }
}
