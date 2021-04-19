
namespace SmartLin.LearningCSharp.Inheritance
{
    /// <summary>
    /// 评教；
    /// </summary>
    public interface IEvaluate                                  
    {
        /// <summary>
        /// 评教
        /// </summary>
        /// <param name="faculty">被评教的教职工</param>
        void Evaluate(Faculty faculty);                         
    }                                                           
}
