using System;

namespace SmartLin.LearningCSharp.StatePattern
{
    /// <summary>
    /// 补考状态；
    /// </summary>
    public class ResitState : AbstractState                                             //定义具体状态；
    {
        /// <summary>                                                                       
        /// 评分；                                                                          
        /// </summary>                                                                      
        /// <param name="score">成绩</param>                                                
        public override void Grading(decimal score)                                     //实现抽象方法，用于改变上下文对象的状态；
        {
            this.Examinee.Score = score;
            Console.WriteLine
                ("考生{0}：补考{1}及格{2}。"
                , this.Examinee.Name
                , this.Examinee.IsPassed ? "已" : "未"
                , this.Examinee.IsPassed ? "" : "，应参加重修");
            if (this.Examinee.IsPassed)
            {
                this.Examinee.State = new PassedState(this.Examinee);
            }
            else
            {
                this.Examinee.State = new RetakingState(this.Examinee);
            }
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="examinee">考生</param>
        public ResitState(Examinee examinee)
            : base(examinee)
        {
            ;
        }
    }
}
