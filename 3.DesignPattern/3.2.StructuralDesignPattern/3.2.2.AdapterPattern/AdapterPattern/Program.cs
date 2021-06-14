using System;
using static System.Console;

namespace SmartLin.LearningCSharp.AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            User newUser = User.Create
                ("3210707001"
                , "MyPassword7001"
                , new CryptographyAdapter(new Md5Cryptography()));           //使用通用适配器；需传入被适配者；
            WriteLine($"用户{newUser.Number}注册成功，加密后的密码为：{newUser.Password}\n");

            User newUser2 = User.Create
                ("3210707002"
                , "MyPassword7002"
                , CryptoService.Create("Sha1CryptographyAdapter"));         //使用专用适配器；使用方式与适配目标一致；
            WriteLine($"用户{newUser2.Number}注册成功，加密后的密码为：{newUser2.Password}\n");

            User newUser3 = User.Create
                ("3210707003"
                , "MyPassword7003"
                , CryptoService.Create("Sha512CryptographyAdapter"));       //使用专用适配器；使用方式与适配目标一致；
            WriteLine($"用户{newUser3.Number}注册成功，加密后的密码为：{newUser3.Password}\n");
            Read();
        }
    }
}
