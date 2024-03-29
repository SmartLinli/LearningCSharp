﻿using static System.Console;

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
            var userIntroduction =
                $"用户信息：\n" +
                $"编号：{user.Number,-15}姓名：{user.Name}\n" +
                $"性别：{user.Gender,-14}生日：{user.BirthDate:D}\n" +
                $"手机号：{user.PhoneNumber}";
            WriteLine(userIntroduction);
            user.Intro();
            WriteLine("\n");
        }
    }
}
