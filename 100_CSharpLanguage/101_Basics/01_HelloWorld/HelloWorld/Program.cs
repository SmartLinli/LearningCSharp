using System;                                                           //调用命名空间System中的类型；可通过“组织using”来“移除未使用的using”；
                                                                        //System包含最常用的.Net类型；
namespace SmartLin.LearningCSharp.Basics                                //声明命名空间；命名空间非必需；
{
    class Program                                                       //声明类；Main所在类的名称不限；
    {
        static void Main()                                              //声明静态方法Main，这是程序的唯一起点；注意大小写；
        {                                                               //作为可执行程序的起点，Main所在类不应也不必实例化，故Main应为静态方法；
            Console.Write("Hello world!");                              //调用（命名空间System中的）Console（静态）类的Write方法，将字符串输出至控制台；
            Console.Read();                                             //C#没有内置输入输出，而是依赖.Net框架提供的各种类实现各种功能；
        }
    }
}
