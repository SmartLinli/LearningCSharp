using System;                                                                       
using static System.Console;

namespace SmartLin.LearningCSharp.Basics
{
    class Program
    {
        enum Gender
        {
            FEMALE = 0,                                                             //可为枚举名称指定值；
            MALE = 1
        }
        static void Main()
        {
            WriteLine("请分别输入学号、姓名、性别、生日、身高、体重、是否注册：");       //调用Console的WriteLine方法，将字符串输出至控制台，以行终止符结束；
            var number = ReadLine();                                                //调用Console的ReadLine方法，从控制台读取输入流，以回车结束，并返回字符串；
            var name = ReadLine();                                                  //调用Console的ReadLine方法，从控制台读取输入流，以回车结束，并返回字符串；
            var gender = (Gender)int.Parse(ReadLine());                             //先将输入字符串转为整型，再通过强制类型转换，按照枚举值转为相应的枚举名称；
            var birthDate = DateTime.Parse(ReadLine());                             //调用DateTime类的Parse方法将字符串转为日期时间型；
            var height = float.Parse(ReadLine());                                   //调用float结构体的Parse方法将字符串转为单精度浮点型；
            var weight = decimal.Parse(ReadLine());
            var isRegistered = bool.Parse(ReadLine());
            WriteLine
                ($"输入完成，新生{name}信息如下：\n"                                   //$符号可实现内插字符串，其中包含若干占位符，占位符基本格式为｛变量名｝；\n代表换行；
                + $"学号：{number,-10}姓名：{name}\n"                                 //加号可用于字符串拼接；占位符完整格式为｛内插表达式，对齐方式与长度：格式说明符｝；详见https://docs.microsoft.com/zh-cn/dotnet/csharp/language-reference/tokens/interpolated
                + $"性别：{gender,-10}生日：{birthDate:d}\n"                          //可通过占位符中的格式说明符，指定日期时间的输出格式；例如d表示短日期；复杂内插表达式还需加上（），例如(gender==Gender.MALE?"男":"女")；                  
                + $"身高：{height,-10:F1}体重：{weight:F1}\n"                         //F1表示含1位小数的定点数；
                + $"是否注册：{isRegistered}");
            Read();                                                                  //从标准输入流读取下一个字符；
        }
    }
}
