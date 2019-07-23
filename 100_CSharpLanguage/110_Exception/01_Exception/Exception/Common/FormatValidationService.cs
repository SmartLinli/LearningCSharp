using System;
using System.Text.RegularExpressions;

namespace SmartLin.LearningCSharp.ErrorAndException
{
    /// <summary>
    /// 无效格式异常；
    /// </summary>
    public class InvalidFormatException : ApplicationException                                                  //定义自定义异常类，并派生于ApplicationException类；
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="message">异常消息</param>
        public InvalidFormatException(string message)
            : base(message)
        {
            ;
        }
    }
    /// <summary>
    /// 格式验证服务；
    /// </summary>
    public class FormatValidationService
    {
        /// <summary>
        /// 验证学号/工号；
        /// </summary>
        /// <param name="number">学号/工号</param>
        /// <returns>是否有效</returns>
        public static bool ValidateNumber(string number)
        {
            if (!Regex.IsMatch(number, @"^(\d{10}|\d{7})$"))
            {
                throw new InvalidFormatException("用户账号应为10位学号或7位工号，且应全为数字！");              //抛出自定义异常，并传递异常消息；
            }
            return true;
        }
        /// <summary>
        /// 验证密码；
        /// </summary>
        /// <param name="password">密码</param>
        /// <returns>是否有效</returns>
        public static bool ValidatePassword(string password)
        {
            if (!Regex.IsMatch(password, @"^(?![A-Z]+$)(?![a-z]+$)(?![0-9]+$)[A-Za-z0-9]{6,20}$"))
            {
                throw new InvalidFormatException("用户密码应为6～20位，支持大、小写字母与数字，不能全为大、小写字母或数字！");
            }
            return true;
        }
        /// <summary>
        /// 验证电子邮件地址；
        /// </summary>
        /// <param name="emailAddress">电子邮件地址</param>
        /// <returns>是否有效</returns>
        public static bool ValidateEmailAddress(string emailAddress)
        {
            if (!Regex.IsMatch(emailAddress, @"^[A-Za-z\d]+[A-Za-z\d_]*@[A-Za-z\d]+[A-Za-z\d-]*(\.[A-Za-z]{2,4})+$"))
            {
                throw new InvalidFormatException("用户电子邮件地址应符合合法电子邮件地址与域名的格式！");
            }
            return true;
        }
    }
}
