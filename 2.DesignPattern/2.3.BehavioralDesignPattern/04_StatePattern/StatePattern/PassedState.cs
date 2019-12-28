using System;

namespace SmartLin.LearningCSharp.StatePattern
{
    /// <summary>
    /// 及格状态；
    /// </summary>
    public class PassedState : AbstractState                                            //定义具体状态；
    {
        /// <summary>                                                                   
        /// 评分；                                                                      
        /// </summary>                                                                  
        /// <param name="score">成绩</param>                                            
        public override void Grading(decimal score)                                     //实现抽象方法，用于改变上下文对象的状态；
        {
            throw new ApplicationException(string.Format("考生{0}}已及格！", this.Examinee.Name));
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="examinee">考生</param>
        public PassedState(Examinee examinee)
            : base(examinee)
        {
            ;
        }
    }
}
