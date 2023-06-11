using static System.Console;

namespace SmartLin.LearningCSharp.ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main()
        {
            Student student = new Student("3230707001", "张三");
            Request request = new Request()                                         //定义请求；
            {
                Applicant = student,
                Content = "申请免修《面向对象程序设计》"
            };
            TeachingAffairOfficeApprover mrZhang =                                  //定义各级审批者；
                new TeachingAffairOfficeApprover("1997023", "张恒亮");
            CollegeApprover mrChen = 
                new CollegeApprover("2007001", "陈宪泽")
            {
                NextApprover = mrZhang
            };
            StaffRoomApprover msYang = 
                new StaffRoomApprover("2002010", "杨雪梅")
            {
                NextApprover = mrChen
            };
            msYang.Handle(request);                                                 //从基层审批者开始处理请求；
            ReadLine();
        }
    }
}
