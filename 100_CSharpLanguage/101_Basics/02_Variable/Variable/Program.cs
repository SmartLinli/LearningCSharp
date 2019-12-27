using System;                                                           //调用命名空间System中的类型；
using static System.Console;                                            //导入静态类，以便于直接调用其静态方法；

namespace SmartLin.LearningCSharp.Basics                                //声明命名空间；
{
    class Program                                                       //声明类；Main所在类的名称不限；
    {
        enum Gender                                                     //声明枚举
        {                                                               //枚举实质为用户定义的整数类型；
            FEMALE = 0,                                                 //枚举名称及其值；默认值为0；
            MALE = 10                                                   //枚举值之间若留有较大余地，可便于增加新枚举；
        }
        static void Main()                                              
        {                                                               //C#没有内置预定义类型，而是依赖.Net框架提供的通用类型系统（CTS）；
            const string title = "新生信息：";							//使用const声明常量（即使用过程中不会发生变化的变量）；
            int number = 31907001;                                      //int类型的变量实际为System.Int32结构的实例；此类类型为值类型；
            string name = "张三";										//string类型的变量实际为System.String类的实例；此类类型为引用类型；
            Gender gender = Gender.MALE;                                //枚举将实例化为派生于System.Enum的结构；
            DateTime birthDate = DateTime.Parse("2000-01-02");          //调用DateTime结构提供的Parse方法，将字符串转为日期时间；
            float height = 170;                                         //float类型的变量实际为System.Single结构的实例；整型值可被隐式转为（精度更高）的单精度值；但若输入170.0，将被识别为双精度值，进而无法被隐式转为（精度更低）的单精度值，此时应输入170.0F（或f）；
            var weight = 60.5m;                                         //隐式类型根据初始化值进行类型推断；初始化器不能为空，也不能再改变变量类型；Decimal类型为128位高精度十进制数，但非基本类型；
            bool isRegistered = true;                                   //bool类型的变量实际为System.Boolean结构的实例；
            WriteLine(title);                                           //将指定的字符串值（后跟当前行终止符）写入标准输出流；
            WriteLine(number.ToString());                               //int等基本数据类型提供ToString方法，实现转换字符串；
            WriteLine(name);
            WriteLine(gender.ToString());
            WriteLine(birthDate.ToShortDateString());                   //DateTime类型提供更多字符串格式的转换方法；
            WriteLine(height.ToString());
            WriteLine(weight.ToString());
            WriteLine(isRegistered);
            Read();
        }
    }
}
