namespace SmartLin.LearningCSharp.Inheritance
{
    /// <summary>
    /// 深入评教；
    /// </summary>
    public interface IDeepEvaluate : IEvaluate                  //定义接口，并继承其它接口；
    {
        /// <summary>
        /// 分析；
        /// </summary>
        /// <param name="faculty">教职工</param>
        void Analyse(Faculty faculty);
        /// <summary>
        /// 建议；
        /// </summary>
        /// <param name="faculty">教职工</param>
        void Propose(Faculty faculty);
    }
}
