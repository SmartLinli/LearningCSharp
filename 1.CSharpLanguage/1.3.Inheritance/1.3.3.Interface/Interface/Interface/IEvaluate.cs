namespace SmartLin.LearningCSharp.Inheritance
{
    /// <summary>
    /// 评教；
    /// </summary>
    public interface IEvaluate                                  //定义接口；
    {
        /// <summary>
        /// 评教；
        /// </summary>
        /// <param name="faculty">被评教的教职工</param>
        void Evaluate(Faculty faculty);                         //接口成员默认公有,且不能更改访问级别；
    }                                                           //接口成员只能包含签名，不能包含实现代码；
}
