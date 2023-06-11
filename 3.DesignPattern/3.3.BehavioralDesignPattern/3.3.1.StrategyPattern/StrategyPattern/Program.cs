using static System.Console;

namespace SmartLin.LearningCSharp.StrategyPattern
{
    class Program
    {
        static void Main()
        {
            User newUser = User.Create
                ("3230707001"
                , "MyPassword7001"
                , new ReverseCrypto());
            WriteLine($"用户{newUser.Number}注册成功，加密后的密码为：{newUser.Password}");

            User newUser2 = User.Create
                ("3230707002"
                , "MyPassword7002"
                , new LeftShiftCrypto());
            WriteLine($"用户{newUser2.Number}注册成功，加密后的密码为：{newUser2.Password}");

            User newUser3 = User.Create
                ("3230707003"
                , "MyPassword7003"
                , new HexCrypto());
            WriteLine($"用户{newUser3.Number}注册成功，加密后的密码为：{newUser3.Password}");
            Read();
        }
    }
}
