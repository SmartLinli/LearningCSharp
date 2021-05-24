using System;
using SmartLin.LearningCSharp.ClassAndObject.Common;                                        //对项目默认命名空间以外的资源访问，可通过添加调用获得便利；
using SmartLin.LearningCSharp.ClassAndObject.Model;
using SmartLin.LearningCSharp.ClassAndObject.Ui;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    class Program
    {
        static void Main()
        {
            /*创建专业、班级*/
            Major infomationManagement = new Major("信息管理与信息系统", "信管");
            Class im18 = new Class(infomationManagement, 2018);
            /*创建学生并显示*/
            Student boy = Student.Create("3180707000", "张三", Gender.MALE, im18);          //调用类的静态方法；    
            StudentUi.Display(boy);                                                         //调用静态类的静态方法；
            /*创建新生、录取并显示*/
            Student girl = Student.Create("3190707000", "李四", Gender.FEMALE);
            girl.EnrollByMajor(infomationManagement);
            StudentUi.Display(girl);
            /*学生转专业*/
            Major acupuncture = new Major("针灸学", "针灸");
            boy.TransferToMajor(acupuncture);
            /*发送短信*/
            boy.PhoneNumber = "18900001111";
            MessageService.SendSms(boy.PhoneNumber, "请抓紧评教。");
            MessageService.SendSms(girl.PhoneNumber, "请抓紧评教。");
            Console.Read();
        }
    }
}
