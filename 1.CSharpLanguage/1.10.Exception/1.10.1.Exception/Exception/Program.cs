using System;
using static System.Console;

namespace SmartLin.LearningCSharp.ErrorAndException
{
    class Program
    {
        static void Main()
        {
            User newUser = null;
            try                                                                                         //若try语句块正常结束，则将跳过catch语句块，走向后续语句；
            {
                newUser = User.Register("3210707001", "MyPassword7001", "3210707001@fjtcm.edu.cn");
                newUser.Activate();
            }                                                                                           //若try语句块出现异常，则将进入catch语句块，捕捉并处理异常；
            catch (ApplicationException ex)                                                             //每个catch语句块将捕捉类型最匹配的异常；
            {                                                                                           //派生层次最低、针对性最强的异常类型，宜最先捕捉；
                WriteLine(ex.Message);
                WriteLine(ex.InnerException.Message);                                                   //访问异常所包含的内部异常；
                Read();
                return;
            }
            catch (Exception ex)                                                                        //派生层次最高、通用性最强的异常类型，宜最后捕捉；
            {
                WriteLine("发生其它错误。错误消息已存入日志。请联系技术人员。", ex.Message);
                Read();
                return;
            }
            WriteLine($"用户{newUser.Number}完成注册并激活。");                                           //后续语句；
            Read();
        }
    }
}
