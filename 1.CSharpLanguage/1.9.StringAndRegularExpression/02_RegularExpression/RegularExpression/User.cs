using System;
using System.Text;
using System.Text.RegularExpressions;

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
        /// 邮箱；
        /// </summary>
        public string Email
        {
            get;
            set;
        }
        /// <summary>
        /// 加密；
        /// 将密码中每个字符替换为前1个字符；
        /// </summary>
        /// <param name="plainText">明文</param>
        /// <returns>密文</returns>
        private static string Encrypt(string plainText)        
        {
            StringBuilder cipherTextBuilder = new StringBuilder(plainText);                 
            for (int i = 'a'; i <= 'z'; i++)
            {
                char
                    oldLowerCaseLetter = (char)i
                    , newLowerCaseLetter = (char)(i - 1);
                cipherTextBuilder =
                    cipherTextBuilder.Replace(oldLowerCaseLetter, newLowerCaseLetter);      
            }
            for (int i = 'A'; i <= 'Z'; i++)
            {
                char
                    oldUpperCaseLetter = (char)i
                    , newUpperCaseLetter = (char)(i - 1);
                cipherTextBuilder =
                    cipherTextBuilder.Replace(oldUpperCaseLetter, newUpperCaseLetter);
            }
            for (int i = '0'; i <= '9'; i++)
            {
                char
                    oldDigit = (char)i
                    , newDigit = (char)(i - 1);
                cipherTextBuilder =
                    cipherTextBuilder.Replace(oldDigit, newDigit);
            }
            return cipherTextBuilder.ToString();                                            
        }                                                                                   
        /// <summary>
        /// 检查学号/工号；
        /// </summary>
        /// <param name="number">学号/工号</param>
        /// <returns>是否有效</returns>
        private static bool CheckNumber(string number)
        {   
            return Regex.IsMatch
                (number, @"^(\d{10}|\d{7})$");                                                      //调用Regex类的IsMatch静态方法，判断字符串与模式是否匹配；
        }
        /// <summary>
        /// 检查密码；
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
                Console.WriteLine("错误：用户账号应为10位学号或7位工号，且应全为数字！");
                return null;
            }
            if (!CheckPassword(password))
            {
                Console.WriteLine("错误：用户密码应为6～20位，支持大、小写字母与数字，不能全为大、小写字母或数字！");
                return null;
            }
            if (!CheckEmail(email))
            {
                Console.WriteLine("错误：用户邮箱应为正确的邮箱格式！");
                return null;
            }
            User newUser = new User();
            newUser.Number = number;
            newUser.Password = Encrypt(password);
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
                Console.WriteLine("错误：用户密码应为6～20位，支持大小写字母与数字，不能全为字母或数字！");
                return false;
            }
            this.Password = Encrypt(newPassword);
            return true;
        }
    }
}