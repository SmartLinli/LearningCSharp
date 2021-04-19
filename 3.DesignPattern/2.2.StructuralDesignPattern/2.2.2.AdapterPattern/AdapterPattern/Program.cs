using System;

namespace SmartLin.LearningCSharp.AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            User newUser = User.Create
                ("3180707001"
                , "MyPassword7001"
                ,new CryptographyAdapter(new Md5Cryptography()));           //使用通用适配器；需传入被适配者；
            Console.WriteLine
                ("用户{0}注册成功，加密后的密码为：{1}\n"
                , newUser.Number
                , newUser.Password);

            User newUser2 = User.Create
                ("3180707002"
                , "MyPassword7002"
                , CryptoService.Create("Sha1CryptographyAdapter"));         //使用专用适配器；使用方式与适配目标一致；
            Console.WriteLine
                ("用户{0}注册成功，加密后的密码为：{1}\n"
                , newUser2.Number
                , newUser2.Password);

            User newUser3 = User.Create
                ("3180707003"
                , "MyPassword7003"
                , CryptoService.Create("Sha512CryptographyAdapter"));       //使用专用适配器；使用方式与适配目标一致；
            Console.WriteLine
                ("用户{0}注册成功，加密后的密码为：{1}\n"
                , newUser3.Number
                , newUser3.Password);
            Console.Read();
        }
    }
}
