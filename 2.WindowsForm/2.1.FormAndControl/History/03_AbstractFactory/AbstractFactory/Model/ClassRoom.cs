using System;

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
        public string Number
        {
            get;
            set;
        }
        /// <summary>
        /// 座位数；
        /// </summary>
        public int SeatAmount
        {
            get;
            set;
        }
        /// <summary>
        /// 被占用星期；
        /// </summary>
        public DayOfWeek OccupiedWeekDay
        {
            get;
            set;
        }
        public void ShowResult()
        {
            Console.WriteLine("\n笔试考场定于{0}教室（座位数{1}）", this.Number, this.SeatAmount);
        }
    }
}
