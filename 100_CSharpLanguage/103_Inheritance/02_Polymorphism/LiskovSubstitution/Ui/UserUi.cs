using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
    /// <summary>
    /// 用户界面；
    /// </summary>
    public static class UserUi
    {
        /// <summary>
        /// 显示用户；
        /// </summary>
        /// <param name="user">用户</param>
        public static void Display(User user)
        {
			WriteLine
				($"用户信息：\n"
				+ $"编号：{user.Number,-15}姓名：{user.Name}\n"                               //基类的对象只能访问基类成员；
				+ $"性别：{user.Gender,-14}生日：{user.BirthDate:D}\n"
				+ $"手机号：{user.PhoneNumber}");
            user.Intro();
            WriteLine("\n");
        }
    }
}
