using static System.Console;

namespace SmartLin.LearningCSharp.ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main()
        {
            Student student = new Student("3180707001", "周林好");
            Request request = new Request()                                         //定义请求；
            {
                Applicant = student,
                Content = "申请免修《面向对象程序设计》"
            };
            TeachingAffairOfficeApprover mrJiang =                                  //定义各级审批者；
                new TeachingAffairOfficeApprover("1997023", "江澍");
            CollegeApprover mrJin = 
                new CollegeApprover("1994001", "金浪")
            {
                NextApprover = mrJiang
            };
            StaffRoomApprover msYang = 
                new StaffRoomApprover("2002010", "杨雪梅")
            {
                NextApprover = mrJin
            };
            msYang.Handle(request);                                                 //从基层审批者开始处理请求；
            ReadLine();
        }
    }
}
