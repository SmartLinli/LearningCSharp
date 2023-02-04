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
            Class im23 = new Class(infomationManagement, 2023);
            /*定义学生并显示*/
            Student girl = new Student("3230707002", "李四", Gender.FEMALE, im23);
            StudentUi.Display(girl);
            /*定义新生；录取；显示；*/
            Student newGuy = new Student("3230707001", "张三", Gender.MALE);
            newGuy.EnrollBy(infomationManagement);
            StudentUi.Display(newGuy);
            /*发送短信*/
            girl.PhoneNumber = "18900001111";
            SmsService.SendSms(girl.PhoneNumber, "请按时打卡。");
            SmsService.SendSms(newGuy.PhoneNumber, "请按时打卡。");
            Read();
        }
    }
}
