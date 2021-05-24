using System;

namespace SmartLin.LearningCSharp.StringBuilder
{
    class Program
    {
        static void Main()
        {
            User newUser = UserService.SignUp("3180707001", "MyPassword7001");
            Console.WriteLine
                ("用户{0}注册成功，加密后的用户密码为：{1}\n"
                ,newUser.Number
                , newUser.Password);
            User user = UserService.Login("3180707001", "MyPassword7001");
            if (user != null)
            {
                Console.WriteLine("用户{0}登录成功。", user.Number);
            }
            else
            {
                Console.WriteLine("登录失败！");
            }
            Console.Read();
        }
    }
}
