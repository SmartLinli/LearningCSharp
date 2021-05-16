using System.Text;

namespace SmartLin.LearningCSharp.Reflection
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
        /// 加密器；
        /// </summary>
        public ICrypto Crypto { get; set; }
        /// <summary>
        /// 注册；
        /// </summary>
        /// <param name="number">学号/工号</param>
        /// <param name="password">密码</param>
        /// <param name="crypto">加密器</param>
        /// <returns>新用户</returns>
        public static User Register(string number, string password, ICrypto crypto)
        {
            User newUser = new User();
            newUser.Number = number;
            newUser.Crypto = crypto;
            newUser.Password = crypto.Encrypt(password);
            return newUser;
        }
        /// <summary>
        /// 修改密码；
        /// </summary>
        /// <param name="newPassword">新密码</param>
        public void ModifyPassword(string newPassword)
        {
            this.Password = this.Crypto.Encrypt(newPassword);
        }
    }
}