using System;

namespace SmartLin.LearningCSharp.ChainOfResponsibilityPattern
{
    /// <summary>
    /// 教研室审批者；
    /// </summary>
    public class StaffRoomApprover : AbstractApprover                                               //定义具体审批者；
    {
        /// <summary>
        /// 处理；
        /// </summary>
        /// <param name="request">请求</param>
        public override void Handle(Request request)                                                //实现处理方法；
        {
            Console.WriteLine
                ("是否批准学生{0}关于“{1}”的请求？（Y/N）"
                , request.Applicant.Name
                , request.Content);
            if (Console.ReadLine().ToUpper() == "Y")                                                //若本审批者批准请求，则完成请求处理；
            {
                Console.WriteLine("教研室主任{0}已批准该请求。\n", this.Name);
                return;
            }
            if (this.NextApprover != null)                                                          //若本审批者无法批准请求，则将请求转交下一审批者；
            {
                Console.WriteLine("教研室主任{0}已将该请求转交上一级主管领导。\n", this.Name);      
                this.NextApprover.Handle(request);
                return;
            }
            Console.WriteLine("请向上一级主管领导提出请求。\n");                                    //若无下一审批者，则予以回复；
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="number">工号</param>
        /// <param name="name">姓名</param>
        public StaffRoomApprover(string number, string name)
            : base(number, name)
        {
            ;
        }
    }
}
