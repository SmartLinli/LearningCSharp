using System;

namespace SmartLin.LearningCSharp.BuilderPattern
{
    /// <summary>
    /// 教室
    /// </summary>
    public class ClassRoom
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
    }
}
