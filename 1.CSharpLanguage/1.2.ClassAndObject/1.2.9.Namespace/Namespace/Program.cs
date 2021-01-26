using SmartLin.LearningCSharp.ClassAndObject.Common;                                        //对项目默认命名空间以外的资源访问，可通过添加调用获得便利；
using SmartLin.LearningCSharp.ClassAndObject.Model;
using SmartLin.LearningCSharp.ClassAndObject.Ui;
using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
	class Program
    {
        static void Main()
        {
            /*定义专业、班级；*/
            Major infomationManagement = new Major("信息管理与信息系统", "信管");
            Class im20 = new Class(infomationManagement, 2020);
            /*定义学生并显示*/
            Student girl = new Student("3200707002", "储艺", Gender.FEMALE, im20);
            StudentUi.Display(girl);
            /*定义新生；录取；显示；*/
            Student newGuy = new Student("3210707001", "张三", Gender.MALE);
            newGuy.EnrollByMajor(infomationManagement);
            StudentUi.Display(newGuy);
            /*发送短信*/
            girl.PhoneNumber = "18900001111";
            MessageService.SendSms(girl.PhoneNumber, "请按时钉钉打卡。");
            MessageService.SendSms(newGuy.PhoneNumber, "请按时钉钉打卡。");
            Read();
        }
    }
}
