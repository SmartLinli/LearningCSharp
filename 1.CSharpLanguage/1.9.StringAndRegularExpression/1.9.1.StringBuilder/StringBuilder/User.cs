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
        /// 加密；
        /// 将明文中每个字符替换为前1个字符；
        /// </summary>
        /// <param name="plainText">明文</param>
        /// <returns>密文</returns>
        private static string Encrypt(string plainText)
        {
            string cipherText = plainText;
            for (int i = 'a'; i <= 'z'; i++)                                                //遍历26个小写字母对应的十进制ASCII码；
            {
                char
                    oldLowerCaseLetter = (char)i //b                                           //基于ASCII码创建原字母、对应的前1个字母；
                    , newLowerCaseLetter = (char)(i - 1);//a
                cipherText =
                    cipherText.Replace(oldLowerCaseLetter, newLowerCaseLetter);             //调用string类的Replace方法，将字符串中所有指定字符替换为新字符；
            }                                                                               //字符串对象是不可变对象，每次修改都将创建新字符串对象，导致消耗较多资源；
            for (int i = 'A'; i <= 'Z'; i++)
            {
                char
                    oldUpperCaseLetter = (char)i
                    , newUpperCaseLetter = (char)(i - 1);
                cipherText =
                    cipherText.Replace(oldUpperCaseLetter, newUpperCaseLetter);
            }
            for (int i = '0'; i <= '9'; i++)
            {
                char
                    oldDigit = (char)i
                    , newDigit = (char)(i - 1);
                cipherText =
                    cipherText.Replace(oldDigit, newDigit);
            }
            return cipherText;
        }
        /// <summary>
        /// 优化加密；
        /// 将密码中每个字符替换为前1个字符；
        /// </summary>
        /// <param name="plainText">明文</param>
        /// <returns>密文</returns>
        private static string EncryptOptimized(string plainText)
        {
            StringBuilder cipherTextBuilder = new StringBuilder(plainText);                 //定义字符串构建器；
            for (int i = 'a'; i <= 'z'; i++)
            {
                char
                    oldLowerCaseLetter = (char)i
                    , newLowerCaseLetter = (char)(i - 1);
                cipherTextBuilder =
                    cipherTextBuilder.Replace(oldLowerCaseLetter, newLowerCaseLetter);      //调用字符串构建器的Replace方法；
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
            return cipherTextBuilder.ToString();                                            //调用字符串构建器的ToString方法，生成最终字符串；
        }                                                                                   //字符串构建器在修改字符串时，能动态分配内存，无需创建新字符串对象；
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
            newUser.Password = Encrypt(password);
            return newUser;
        }
        /// <summary>
        /// 修改密码；
        /// </summary>
        /// <param name="newPassword">新密码</param>
        public void ModifyPassword(string newPassword)
        {
            this.Password = EncryptOptimized(newPassword);
        }
    }
}