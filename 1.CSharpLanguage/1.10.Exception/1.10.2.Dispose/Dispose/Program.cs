using System;

namespace SmartLin.LearningCSharp.ErrorAndException
{
    class Program
    {
        static void Main()
        {
            User newUser = User.Create("3230707001", "MyPassword7001", "3230707001@fjtcm.edu.cn");
            try
            {
                newUser.Activate();
            }
            catch (SendEmailException ex)
            {
                Console.WriteLine("邮件发送失败：{0}！", ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("错误：{0}\n源自{1}。\n该错误已存入日志。", ex.Message, ex.Source);
            }
            finally                                                                                     //若定义finally语句块，则不论try语句块是否出现异常（即不论是否进入catch语句块），最终都将进入finally语句块；
            {
                if (newUser != null)
                {
                    newUser.Dispose();                                                                  //清除对象；
                }
            }
            Console.WriteLine
                 ("用户{0}{1}。\n"
                 , newUser.Number
                 , newUser.IsActivated ? "激活成功" : "激活失败");
            Console.Read();
        }
    }
}
