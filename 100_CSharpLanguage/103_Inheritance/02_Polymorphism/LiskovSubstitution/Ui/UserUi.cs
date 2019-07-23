using System;

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
            Console.WriteLine
                ("用户信息：\n编号：{0,-15}姓名：{1}\n性别：{2,-14}生日：{3:D}\n年龄：{4,-15}手机号：{5}"
                , user.Number                                                                   //基类的对象只能访问基类成员；
                , user.Name
                , user.Gender == Gender.MALE ? "男" : "女"
                , user.BirthDate
                , user.Age
                , user.PhoneNumber);
            user.Intro();
            Console.WriteLine("\n");
        }
    }
}
