
namespace SmartLin.LearningCSharp.FormAndControl
{
    /// <summary>
    /// 用户服务；
    /// </summary>
    public class UserService
    {
        /// <summary>
        /// 用户；
        /// </summary>
        private static User User
        {
            get;
            set;
        }
        /// <summary>
        /// 获取用户；
        /// </summary>
        /// <param name="number">学号/工号</param>
        /// <param name="name">姓名</param>
        /// <returns>用户</returns>
        public static User GetUser(string number, string name)
        {
            if (User == null)
            {
                User = new User();
                User.Number = number;
                User.Name = name;
            }
            return User;
        }
    }
}
