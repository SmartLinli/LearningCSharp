using System;

namespace SmartLin.LearningCSharp.Basics
{
    class Program                                                       
    {
        static void Main()
        {
            const int MinRate = 0, MaxRate = 5;
            const string
                RateSavedInfo = "评教成绩已保存。",
                NonNumeralWarning = "评教成绩应为数值！",
                InvalidDecimalWarning = "评教成绩小数部分只能为.5！";
            string outOfRangeWarning = "评教成绩应介于"
                                        + MinRate.ToString() + "～"
                                        + MaxRate.ToString() + "分之间！";
            string[] courseNames = { "计算机导论", "C语言程序设计" };
            float[] rates = new float[2];
            bool isNumeral, isWithinRange, isValidDecimal;
            Console.WriteLine("您有{0}门课程需要评教。", rates.Length);
            for (int i = 0; i < rates.Length; i++)
            {
                while (true)
                {
                    Console.WriteLine("请输入第{0}门课程《{1}》的评教成绩：", i + 1, courseNames[i]);
                    var input = Console.ReadLine();
                    isNumeral = float.TryParse(input, out rates[i]);
                    if (isNumeral)
                    {
                        isWithinRange = rates[i] >= MinRate && rates[i] <= MaxRate;
                        if (isWithinRange)
                        {
                            isValidDecimal = (rates[i] % 1) == 0.5 || (rates[i] % 1) == 0;
                            if (isValidDecimal)
                            {
                                Console.WriteLine(RateSavedInfo);
                                break;
                            }
                            else
                            {
                                Console.WriteLine(InvalidDecimalWarning);
                            }
                        }
                        else
                        {
                            Console.WriteLine(outOfRangeWarning);
                        }
                    }
                    else
                    {
                        Console.WriteLine(NonNumeralWarning);
                    }
                }
            }
            Console.Read();
        }
    }
}
