using System;

namespace SmartLin.LearningCSharp.ErrorAndException
{
    /// <summary>
    /// 用户；
    /// </summary>
    public class User : IDisposable                                                  //实现IDisposable接口，用于释放非托管资源；
    {
        /// <summary>
        /// 学号/工号；
        /// </summary>
        public string Number
        {
            get;
            private set;
        }
        /// <summary>
        /// 密码；
        /// 由大小写字母与数字构成；
        /// </summary>
        public string Password
        {
            get;
            private set;
        }
        /// <summary>
        /// 电子邮件地址；
        /// </summary>
        public string EmailAddress
        {
            get;
            set;
        }
        /// <summary>
        /// 是否激活；
        /// </summary>
        public bool IsActivated
        {
            get;
            private set;
        }
        /// <summary>
        /// 对象是否已被清理；
        /// </summary>
        private bool _IsDisposed = false;
        /// <summary>
        /// 创建；
        /// </summary>
        /// <param name="number">学号/工号</param>
        /// <param name="password">密码</param>
        /// <param name="emailAddress">电子邮件地址</param>
        /// <returns>新用户</returns>
        public static User Create(string number, string password, string emailAddress)
        {
            FormatValidationService.ValidateNumber(number);                                         
            FormatValidationService.ValidatePassword(password);
            FormatValidationService.ValidateEmailAddress(emailAddress);
            User newUser = new User();
            newUser.Number = number;
            newUser.Password = CryptoService.Encrypt(password);
            newUser.EmailAddress = emailAddress;
            newUser.IsActivated = false;
            return newUser;
        }
        /// <summary>
        /// 激活；
        /// </summary>
        public void Activate()
        {
            EmailService.SendEmail(this.EmailAddress);
            this.IsActivated = true;
        }
        /// <summary>
        /// 清理；
        /// </summary>
        /// <param name="disposing">是否正在清理</param>
        protected virtual void Dispose(bool disposing)
        {
            if (this._IsDisposed)
            {
                return;
            }
            if (disposing)                                                          //若由Dispose方法调用；
            {
                this.Number = null;                                                 //则显式释放相关的托管/非托管资源（例如调用各对象的Dispose方法、将对象引用设为null等）；
                this.Password = null;
                this.EmailAddress = null;
            }
            this._IsDisposed = true;
        }
        /// <summary>
        /// 清理；
        /// </summary>
        public void Dispose()                                                       //实现IDisposable接口的Dispose方法，用于显式释放资源；
        {
            this.Dispose(true);                                                     //Dispose方法负责释放与该对象相关的资源；
            GC.SuppressFinalize(this);                                              //垃圾回收器不再调用该对象的析构函数；
        }
        /// <summary>
        /// 析构函数；
        /// </summary>
        ~User()                                                                     //析构函数由垃圾回收器调用；
        {
            this.Dispose(false);                                                    //析构函数不负责释放与该对象相关的资源；
        }
    }
}