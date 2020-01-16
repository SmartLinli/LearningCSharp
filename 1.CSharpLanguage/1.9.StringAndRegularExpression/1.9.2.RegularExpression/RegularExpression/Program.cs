using System;

namespace SmartLin.LearningCSharp.StringAndRegularExpression
{
    class Program
    {
        static void Main()
        {
            User newUser = User.Create("3180707001", "MyPassword", "3180707001@fjtcm.edu.cn");
            if (newUser != null)
            {
                Console.WriteLine
                ("用户{0}注册成功，加密后的密码为：{1}\n"
                , newUser.Number
                , newUser.Password);
            }
            Console.Read();
        }
    }
}
