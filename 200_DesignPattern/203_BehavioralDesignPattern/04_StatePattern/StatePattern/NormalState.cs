using System;

namespace SmartLin.LearningCSharp.StatePattern
{
    /// <summary>
    /// 正常状态；
    /// </summary>
    public class NormalState : AbstractState                                            //定义具体状态；
    {
        /// <summary>
        /// 评分；
        /// </summary>
        /// <param name="score">成绩</param>
        public override void Grading(decimal score)                                     //实现抽象方法，用于改变上下文对象的状态；
        {
            this.Examinee.Score = score;
            Console.WriteLine
                ("考生{0}：考试{1}及格{2}。"
                , this.Examinee.Name
                , this.Examinee.IsPassed ? "已" : "未"
                , this.Examinee.IsPassed ? "" : "，应参加补考");
            if (this.Examinee.IsPassed)
            {
                this.Examinee.State = new PassedState(this.Examinee);
            }
            else
            {
                this.Examinee.State = new ResitState(this.Examinee);
            }
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="examinee">考生</param>
        public NormalState(Examinee examinee)
            : base(examinee)
        {
            ;
        }
    }
}
