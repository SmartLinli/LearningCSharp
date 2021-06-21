namespace SmartLin.LearningCSharp.ChainOfResponsibilityPattern
{
    /// <summary>
    /// 请求；
    /// </summary>
    public class Request                                                    //定义请求；
    {
        /// <summary>
        /// 申请人；
        /// </summary>
        public Student Applicant { get; set; }
        /// <summary>
        /// 内容；
        /// </summary>
        public string Content { get; set; }
    }
}