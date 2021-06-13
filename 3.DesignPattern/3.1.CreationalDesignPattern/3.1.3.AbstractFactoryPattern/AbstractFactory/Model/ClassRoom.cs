using System;
using static System.Console;

namespace SmartLin.LearningCSharp.FactoryPattern
{
    /// <summary>
    /// 教室
    /// </summary>
    public class ClassRoom : IExaminationRoom
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
        /// 被占用星期；
        /// </summary>
        public DayOfWeek OccupiedWeekDay { get; set; }
        /// <summary>
        /// 显示结果；
        /// </summary>
        public void ShowResult()
        {
            WriteLine($"{Environment.NewLine}笔试考场定于{this.Number}教室（座位数{this.SeatAmount}）");
        }
    }
}
