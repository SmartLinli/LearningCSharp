using System;                                                                       //调用命名空间System中的类型；
using static System.Console;                                                        //导入静态类，以便于直接调用其静态方法；

namespace SmartLin.LearningCSharp.Basics                                            //声明命名空间；
{
    class Program                                                                   //声明类；Main所在类的名称不限；
    {
        enum Gender                                                                 //声明枚举
        {                                                                           //枚举实质为用户定义的整数类型；
            FEMALE = 0,                                                             //枚举名称及其值；默认值为0；
            MALE = 1
        }
        static void Main()                                                          //声明静态方法Main，这是程序的唯一起点；注意大小写；作为可执行程序的起点，Main所在类不应也不必实例化，故Main应为静态方法；
        {
            WriteLine("请分别输入学号、姓名、性别、生日、身高、体重、是否注册：");           //调用Console的WriteLine方法，将字符串输出至控制台，以行终止符结束；
            var number = int.Parse(ReadLine());                                     //调用Console的ReadLine方法，从控制台读取输入流，以回车结束，并返回字符串；调用int类型的Parse方法将字符串转为整型；
            var name = ReadLine();                                                  //调用Console的ReadLine方法，从控制台读取输入流，以回车结束，并返回字符串；
            var gender = (Gender)int.Parse(ReadLine());                             //输入字符串转为整型后，通过强制类型转换，按照枚举值转为相应的枚举名称；
            var birthDate = DateTime.Parse(ReadLine());
            var height = float.Parse(ReadLine());
            var weight = decimal.Parse(ReadLine());
            var isRegistered = bool.Parse(ReadLine());
            WriteLine($"输入完成，新生{name}信息如下：");                               //$符号可实现内插字符串，其中包含若干占位符，占位符基本格式为｛变量名｝；
            WriteLine($"学号：{number}姓名：{name}");                                 //占位符完整格式为｛内插表达式，对齐方式与长度：格式说明符｝；详见https://docs.microsoft.com/zh-cn/dotnet/csharp/language-reference/tokens/interpolated
            WriteLine($"性别：{gender,-10}生日：{birthDate:d}");                      //可通过占位符中的格式说明符，指定日期时间的输出格式；例如d表示短日期；复杂内插表达式还需加上（）；                  
            WriteLine($"身高：{height,-10:F1}体重：{weight:F1}");                     //F1表示含1位小数的定点数；                 
            WriteLine($"是否注册：{isRegistered}");
            Read();                                                                 //从标准输入流读取下一个字符；
        }
    }
}
