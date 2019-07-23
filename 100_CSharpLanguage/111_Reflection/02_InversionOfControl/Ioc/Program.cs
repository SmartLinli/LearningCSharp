using System;

namespace SmartLin.LearningCSharp.Reflection
{
    class Program
    {
        static void Main()
        {
            User newUser = User.Register
                ("3180707001"
                , "MyPassword7001"
                , CryptoService.Create("ReverseCrypto"));  
            Console.WriteLine
                ("用户{0}注册成功，加密后的密码为：{1}\n"
                , newUser.Number
                , newUser.Password);

            User newUser2 = User.Register
                ("3180707002"
                , "MyPassword7002"
                , CryptoService.Create("LeftShiftCrypto"));
            Console.WriteLine
                ("用户{0}注册成功，加密后的密码为：{1}\n"
                , newUser2.Number
                , newUser2.Password);

            User newUser3 = User.Register
                ("3180707003"
                , "MyPassword7003"
                , CryptoService.Create("HexadecimalCrypto"));
            Console.WriteLine
                ("用户{0}注册成功，加密后的密码为：{1}\n"
                , newUser3.Number
                , newUser3.Password);
            Console.Read();
        }
    }
}
