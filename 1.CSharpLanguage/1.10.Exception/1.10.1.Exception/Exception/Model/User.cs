using System;

namespace SmartLin.LearningCSharp.ErrorAndException
{
    /// <summary>
    /// 用户；
    /// </summary>
    public class User
    {
        /// <summary>
        /// 学号/工号；
        /// </summary>
        public string Number { get; private set; }
        /// <summary>
        /// 密码；
        /// </summary>
        public string Password { get; private set; }
        /// <summary>
        /// 电子邮件地址；
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// 是否激活；
        /// </summary>
        public bool IsActivated { get; private set; }
        /// <summary>
        /// 注册；
        /// </summary>
        /// <param name="number">学号/工号</param>
        /// <param name="password">密码</param>
        /// <param name="emailAddress">电子邮件地址</param>
        /// <returns>新用户</returns>
        public static User Register(string number, string password, string emailAddress)
        {
            try                                                                             //若try语句块正常结束，则将跳过catch语句块，走向后续语句；
            {
                FormatValidationService.ValidateNumber(number);
                FormatValidationService.ValidatePassword(password);
                FormatValidationService.ValidateEmailAddress(emailAddress);
            }
            catch (InvalidFormatException ex)                                               //若try语句块出现异常，则将进入catch语句块，捕捉并处理异常；                                                     
            {
                throw new ApplicationException("用户注册失败：格式错误！", ex);               //抛出新的异常，并包含被捕捉的自定义异常；
            }                                                                               //除了自定义异常，还可使用应用程序异常；
            User newUser = new User();
            newUser.Number = number;
            newUser.Password = CryptoHelper.Encrypt(password);
            newUser.EmailAddress = emailAddress;
            newUser.IsActivated = false;
            return newUser;
        }
        /// <summary>
        /// 激活；
        /// </summary>
        public void Activate()
        {
            try
            {
                EmailService.SendEmail(this.EmailAddress);
                this.IsActivated = true;
            }
            catch (SendEmailException ex)
            {
                throw new ApplicationException("用户激活失败：邮件错误！", ex);
            }
        }
    }
}