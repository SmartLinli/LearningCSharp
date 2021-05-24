
namespace SmartLin.LearningCSharp.CommandPattern
{
    /// <summary>
    /// 教务处命令；
    /// </summary>
    public class TeachingAffairCommand : ICommand                               //定义具体命令，用于执行教务处命令；
    {
        /// <summary>
        /// 教务处；
        /// </summary>
        private TeachingAffair _TeachingAffair;                                 //引用教务处对象；
        /// <summary>
        /// 执行；
        /// </summary>
        public void Execute()                                       
        {
            this._TeachingAffair.EvaluationAggregate();                         //执行实际命令；
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="teachingAffair">教务处</param>
        public TeachingAffairCommand(TeachingAffair teachingAffair)
        {
            this._TeachingAffair = teachingAffair;
        }
    }
}
