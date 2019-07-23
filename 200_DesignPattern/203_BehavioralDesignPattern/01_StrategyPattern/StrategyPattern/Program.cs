using System;

namespace SmartLin.LearningCSharp.StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            User newUser = User.Create
                ("3180707001"
                , "MyPassword7001"
                , new ReverseCrypto());  
            Console.WriteLine
                ("用户{0}注册成功，加密后的密码为：{1}\n"
                , newUser.Number
                , newUser.Password);

            User newUser2 = User.Create
                ("3180707002"
                , "MyPassword7002"
                , new LeftShiftCrypto());
            Console.WriteLine
                ("用户{0}注册成功，加密后的密码为：{1}\n"
                , newUser2.Number
                , newUser2.Password);

            User newUser3 = User.Create
                ("3180707003"
                , "MyPassword7003"
                , new HexadecimalCrypto());
            Console.WriteLine
                ("用户{0}注册成功，加密后的密码为：{1}\n"
                , newUser3.Number
                , newUser3.Password);
            Console.Read();
        }
    }
}
