using System;
using static System.Console;

namespace SmartLin.LearningCSharp.FactoryPattern
{
    /// <summary>
    /// 机房；
    /// </summary>
    public class Laboratory : IExaminationRoom
    {
        /// <summary>
        /// 门牌号；
        /// </summary>
        public string Number { get; set; }
        /// <summary>
        /// 座位数；
        /// </summary>
        public int SeatAmount { get; set; }
        /// <summary>
        /// 是否装有隔板；
        /// </summary>
        public bool HasClapboard { get; set; }
        /// <summary>
        /// 显示结果；
        /// </summary>
        public void ShowResult()
        {
            WriteLine($"{Environment.NewLine}上机考试考场定于{this.Number}机房（机位数：{this.SeatAmount}）");
        }
    }
}
