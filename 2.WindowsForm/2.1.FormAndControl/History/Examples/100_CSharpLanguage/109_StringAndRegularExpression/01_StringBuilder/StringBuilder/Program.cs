using System;

namespace SmartLin.LearningCSharp.StringAndRegularExpression
{
    class Program
    {
        static void Main()
        {
            User newUser = User.Create("3180707001", "MyPassword7001");
            Console.WriteLine
                ("用户{0}注册成功，加密后的密码为：{1}\n"
                ,newUser.Number
                , newUser.Password);
            newUser.ModifyPassword("NewPassword2019");
            Console.WriteLine
                ("用户{0}修改密码成功，加密后的新密码为：{1}\n"
                , newUser.Number
                , newUser.Password);
            Console.Read();
        }
    }
}
