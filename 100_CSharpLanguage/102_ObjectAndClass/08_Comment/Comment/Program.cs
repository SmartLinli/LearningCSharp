using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    class Program
    {
        static void Main()
        {
            /*定义专业、班级；*/
            Major infomationManagement = new Major("信息管理与信息系统", "信管");
            Class im18 = new Class(infomationManagement, 2018);
            /*定义学生；显示；*/
            Student boy = Student.Create("3180707000", "张三", Gender.MALE, im18);          //调用类的静态方法；    
            StudentUi.Display(boy);                                                         //调用静态类的静态方法；
            /*定义新生；录取；显示；*/
            Student girl = Student.Create("3190707000", "李四", Gender.FEMALE);
            girl.EnrollByMajor(infomationManagement);
            StudentUi.Display(girl);
            /*学生转专业；*/
            Major acupuncture = new Major("针灸学", "针灸");
            boy.TransferToMajor(acupuncture);
            /*发送短信；*/
            boy.PhoneNumber = "18900001111";
            MessageService.SendSms(boy.PhoneNumber, "请抓紧评教。");                         
            MessageService.SendSms(girl.PhoneNumber, "请抓紧评教。");
            Read();
        }
    }
}
