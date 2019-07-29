using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
    /// <summary>
    /// 用户服务；
    /// </summary>
    public class UserService
    {
        /// <summary>
        /// 介绍所有用户；
        /// </summary>
        /// <param name="users">多个用户</param>
        public static void IntroduceAll(User[] users)
        {
            for (int i = 0; i < users.Length; i++)
            {
                users[i].Intro();
                WriteLine("。");
            }
        }
    }
}
