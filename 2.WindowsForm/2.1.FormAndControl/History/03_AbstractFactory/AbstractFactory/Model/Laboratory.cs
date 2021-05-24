using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        /// 是否装有隔板；
        /// </summary>
        public bool HasClapboard
        {
            get;
            set;
        }
        public void ShowResult()
        {
            Console.WriteLine("\n上机考试考场定于{0}机房（座位数：{1}）", this.Number, this.SeatAmount);
        }
    }
}
