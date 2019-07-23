using static System.Console;

namespace SmartLin.LearningCSharp.Basics
{
    class Program
    {
        static void Main()
        {
            bool isValid = false;
            string[] courseNames = { "计算机导论", "C语言程序设计" };               //声明并初始化数组；
            float[] rates = { 0, 0 };
            WriteLine($"您有{courseNames.Length}门课程需要评教。");                //每个数组均为派生于抽象基类Array的类；Array提供length等属性；
            for (int i = 0; i < courseNames.Length; i++)                        //for适用于循环次数已知的场景；
            {
                isValid = false;
                while (!isValid)                                                //while适用于循环次数未知的场景；
                {
                    WriteLine($"请输入第{i + 1}门课程《{courseNames[i]}》的评教成绩：");
                    var input = ReadLine();
                    isValid = float.TryParse(input, out rates[i]);              //float等类型提供TryParse方法，将字符串转为float等类型，并输出至声明为out的实参，最后返回转换是否成功；
                }
                WriteLine($"评教成绩{rates[i]}已保存。");
            }
            Read();
        }
    }
}
