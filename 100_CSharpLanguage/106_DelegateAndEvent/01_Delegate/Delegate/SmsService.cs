using System;

namespace SmartLin.LearningCSharp.DelegateAndEvent
{
    /// <summary>
    /// 短信服务；
    /// </summary>
    public class SmsService
    {
        /// <summary>
        /// 通知；
        /// </summary>
        /// <param name="student">学生</param>
        /// <param name="courseName">课程名称</param>
        public static void InformAfterSelectCourse(Student student, string courseName)             //注册至委托对象的函数的签名必须与委托定义一致；
        {
            Console.WriteLine
                ("\n发送短信至手机{0}：已成功选修《{1}》。\n"
                , student.PhoneNumber
                , courseName);
        }
    }
}
