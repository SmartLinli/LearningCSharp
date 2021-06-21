using static System.Console;

namespace SmartLin.LearningCSharp.ChainOfResponsibilityPattern
{
    /// <summary>
    /// 学院审批者；
    /// </summary>
    public class CollegeApprover : AbstractApprover                                                 //定义具体审批者；
    {
        /// <summary>                                                                               
        /// 处理；                                                                                  
        /// </summary>                                                                              
        /// <param name="request">请求</param>                                                      
        public override void Handle(Request request)                                                //实现处理方法；
        {
            WriteLine($"是否批准学生{request.Applicant.Name}关于“{request.Content}”的请求？（Y/N）");
            if (ReadLine().ToUpper() == "Y")                                                        //若本审批者批准请求，则完成请求处理；
            {
                WriteLine($"学院分管领导{this.Name}已批准该请求。\n");
                return;
            }
            if (this.NextApprover != null)                                                          //若本审批者无法批准请求，则将请求转交下一审批者；
            {
                WriteLine($"学院分管领导{this.Name}已将该请求转交上一级主管领导。\n");
                this.NextApprover.Handle(request);
                return;
            }
            WriteLine("请向上一级主管领导提出请求。\n");                                              //若无下一审批者，则予以回复；
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="number">工号</param>
        /// <param name="name">姓名</param>
        public CollegeApprover(string number, string name)
            : base(number, name)
        {
            ;
        }
    }
}
