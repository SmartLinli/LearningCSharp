namespace SmartLin.LearningCSharp.TemplateMethod
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
    }
}
