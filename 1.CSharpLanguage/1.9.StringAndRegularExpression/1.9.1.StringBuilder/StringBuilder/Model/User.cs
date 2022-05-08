using System.Text;

namespace SmartLin.LearningCSharp.StringAndRegularExpression
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
        /// 由大小写字母与数字构成；
        /// </summary>
        public string Password { get; private set; }
        /// <summary>
        /// 创建；
        /// </summary>
        /// <param name="number">学号/工号</param>
        /// <param name="password">密码</param>
        /// <returns>新用户</returns>
        public static User Create(string number, string password)
        {
            User newUser = new User();
            newUser.Number = number;
            newUser.Password = CryptoHelper.Encrypt(password);
            return newUser;
        }
        /// <summary>
        /// 修改密码；
        /// </summary>
        /// <param name="newPassword">新密码</param>
        public void ModifyPassword(string newPassword)
        {
            this.Password = CryptoHelper.EncryptOptimized(newPassword);
        }
    }
}