namespace SmartLin.LearningCSharp.ChainOfResponsibilityPattern
{
    /// <summary>
    /// 抽象审批者；
    /// </summary>
    public abstract class AbstractApprover : Faculty                        //定义抽象审批者；
    {
        /// <summary>
        /// 下一审批者；
        /// </summary>
        public AbstractApprover NextApprover { get; set; }                  //定义下一审批者，用于转交本审批者无法处理的请求；
        /// <summary>
        /// 处理；
        /// </summary>
        /// <param name="request">请求</param>
        public abstract void Handle(Request request);                       //处理请求；
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">工号</param>
        /// <param name="name">姓名</param>
        public AbstractApprover(string number, string name)
            : base(number, name)
        {
            ;
        }
    }
}
