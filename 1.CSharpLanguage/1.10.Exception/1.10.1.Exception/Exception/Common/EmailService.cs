using System;
using static System.Console;

namespace SmartLin.LearningCSharp.ErrorAndException
{
    /// <summary>
    /// 发送邮件异常；
    /// </summary>
    public class SendEmailException : ApplicationException                                          //定义自定义异常类，并派生于ApplicationException类；
    {
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="message">异常消息</param>
        public SendEmailException(string message)
            : base(message)
        {
            ;
        }
    }
    /// <summary>
    /// 电子邮件服务；
    /// </summary>
    public class EmailService
    {
        /// <summary>
        /// 发送电子邮件；
        /// </summary>
        /// <param name="emailAddress">电子邮件地址</param>
        public static void SendEmail(string emailAddress)
        {
            if (string.IsNullOrEmpty( emailAddress) || emailAddress.Contains("_invalid"))    
            {
                throw new SendEmailException("邮件地址无效！");                                     //抛出自定义异常，并传递异常消息；                     
            }
            else
            {
                WriteLine("已发送邮件至{0}。", emailAddress);
            }
        }
    }
}