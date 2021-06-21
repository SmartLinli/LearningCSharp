namespace SmartLin.LearningCSharp.StatePattern
{
    /// <summary>
    /// 考生；
    /// </summary>
    public class Examinee : Student                                     //定义上下文；
    {
        /// <summary>
        /// 成绩；
        /// </summary>
        public decimal Score { get; set; }
        /// <summary>
        /// 是否及格； 
        /// </summary>
        public bool IsPassed
        =>  this.Score >= 60;
        /// <summary>
        /// 状态； 
        /// </summary>
        public AbstractState State { get; set; }                                    //引用具体状态；
        /// <summary>
        /// 评分
        /// </summary>
        /// <param name="score">成绩</param>
        public void Grading(decimal score)
        {
            this.State.Grading(score);
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number"></param>
        /// <param name="name"></param>
        public Examinee(string number, string name)
            : base(number, name)
        {
            this.State = new NormalState(this);
        }
    }
}
