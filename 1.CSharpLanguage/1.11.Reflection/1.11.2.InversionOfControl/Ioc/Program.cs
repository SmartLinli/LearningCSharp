using static System.Console;

namespace SmartLin.LearningCSharp.Reflection
{
    class Program
    {
        static void Main()
        {
            User newUser = User.Register
                ("3210707001"
                , "MyPassword7001"
                , CryptoService.Create());
            WriteLine($"用户{newUser.Number}注册成功，加密后的密码为：{newUser.Password}");

            User newUser2 = User.Register
                ("3210707002"
                , "MyPassword7002"
                , CryptoService.Create());
            WriteLine($"用户{newUser2.Number}注册成功，加密后的密码为：{newUser2.Password}");

            User newUser3 = User.Register
                ("3210707003"
                , "MyPassword7003"
                , CryptoService.Create());
            WriteLine($"用户{newUser3.Number}注册成功，加密后的密码为：{newUser3.Password}");
            Read();
        }
    }
}