
namespace SmartLin.LearningCSharp.StatePattern
{
    /// <summary>
    /// 抽象状态；
    /// </summary>
    public abstract class AbstractState                                 //定义抽象状态；
    {
        /// <summary>
        /// 考生；
        /// </summary>
        public Examinee Examinee                                        //引用上下文对象；
        {
            get;
            set;
        }
        /// <summary>
        /// 评分；
        /// </summary>
        /// <param name="score">成绩</param>
        public abstract void Grading(decimal score);                    //定义抽象方法，用于改变上下文对象的状态；
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="examinee">考生</param>
        public AbstractState(Examinee examinee)
        {
            this.Examinee = examinee;
        }
    }
}