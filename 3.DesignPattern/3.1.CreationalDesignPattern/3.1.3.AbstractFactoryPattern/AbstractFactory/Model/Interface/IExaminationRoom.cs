namespace SmartLin.LearningCSharp.FactoryPattern
{
    /// <summary>
    /// 考场；
    /// </summary>
    public interface IExaminationRoom
    {
        /// <summary>
        /// 门牌号；
        /// </summary>
        string Number { get; set; }
        /// <summary>
        /// 座位数；
        /// </summary>
        int SeatAmount { get; set; }
        /// <summary>
        /// 显示结果；
        /// </summary>
        void ShowResult();
    }
}
