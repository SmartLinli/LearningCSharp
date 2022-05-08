using System.Text.RegularExpressions;
using static System.Console;

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
        /// 邮箱；
        /// </summary>
        public string Email { get; private set; }
        /// <summary>
        /// 检查学号/工号；
        /// 学号应为10位数字；工号应为7位数字；
        /// </summary>
        /// <param name="number">学号/工号</param>
        /// <returns>是否有效</returns>
        private static bool CheckNumber(string number)
        {
            return Regex.IsMatch                                                                    //调用Regex类的IsMatch静态方法，判断字符串与模式是否匹配；
                (number, @"^(\d{10}|\d{7})$");                                                      //可参阅https://docs.microsoft.com/zh-cn/dotnet/api/system.text.regularexpressions.regex.ismatch
        }
        /// <summary>
        /// 检查密码；
        /// 密码应为6～20位，支持大、小写字母与数字，不能全为大、小写字母或数字；
        /// </summary>
        /// <param name="password">密码</param>
        /// <returns>是否有效</returns>
        private static bool CheckPassword(string password)
        {
            return Regex.IsMatch
                (password, @"^(?![A-Z]+$)(?![a-z]+$)(?![0-9]+$)[A-Za-z0-9]{6,20}$");                //?!实现正向否定预查；
        }
        /// <summary>
        /// 检查邮箱；
        /// 邮箱格式应为“用户名@域名.后缀”；
        /// </summary>
        /// <param name="email">邮箱</param>
        /// <returns>是否有效</returns>
        private static bool CheckEmail(string email)
        {
            return Regex.IsMatch
                (email, @"^[A-Za-z\d]+[A-Za-z\d_]*@[A-Za-z\d]+[A-Za-z\d-]*(\.[A-Za-z]{2,4})+$");    //\w等价于[_][A-Za-z\d]；
        }
        /// <summary>
        /// 创建；
        /// </summary>
        /// <param name="number">学号/工号</param>
        /// <param name="password">密码</param>
        /// <returns>新用户</returns>
        public static User Create(string number, string password, string email)
        {
            if (!CheckNumber(number))
            {
                WriteLine("错误：用户账号应为10位学号或7位工号，且应全为数字！");
                return null;
            }
            if (!CheckPassword(password))
            {
                WriteLine("错误：用户密码应为6～20位，支持大、小写字母与数字，不能全为大、小写字母或数字！");
                return null;
            }
            if (!CheckEmail(email))
            {
                WriteLine("错误：用户邮箱应为正确的邮箱格式！");
                return null;
            }
            User newUser = new User();
            newUser.Number = number;
            newUser.Password = CryptoHelper.Encrypt(password);
            return newUser;
        }
        /// <summary>
        /// 修改密码；
        /// </summary>
        /// <param name="newPassword">新密码</param>
        public bool ModifyPassword(string newPassword)
        {
            if (!CheckPassword(newPassword))
            {
                WriteLine("错误：用户密码应为6～20位，支持大小写字母与数字，不能全为字母或数字！");
                return false;
            }
            this.Password = CryptoHelper.Encrypt(newPassword);
            return true;
        }
    }
}