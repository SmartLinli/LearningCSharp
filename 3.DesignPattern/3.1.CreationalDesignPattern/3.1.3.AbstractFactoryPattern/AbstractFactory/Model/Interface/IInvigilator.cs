namespace SmartLin.LearningCSharp.FactoryPattern
{
    /// <summary>
    /// 监考；
    /// </summary>
    public interface IInvigilator
    {
        /// <summary>
        /// 工号；
        /// </summary>
        string Number { get; set; }
        /// <summary>
        /// 姓名；
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// 显示结果；
        /// </summary>
        void ShowResult();
    }
}
