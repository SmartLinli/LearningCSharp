using static System.Console;

namespace ConditionalStatement
{
    class Program
    {
        static void Main()
        {
            int MinRate = 0, MaxRate = 5;
            const string
                InputRateTip = "请输入评教成绩：",
                RateSavedTip = "评教成绩已保存。",
                NonNumeralWarning = "评教成绩应为数值！",
                InvalidDecimalWarning = "评教成绩小数部分只能为.5！";
            string outOfRangeWarning = $"评教成绩应介于{MinRate}～{MaxRate}分之间！";
            bool
                isNumeral = false,
                isWithinRange = false,
                isValidDecimal = false;
            WriteLine(InputRateTip);
            var input = ReadLine();
            isNumeral = float.TryParse(input, out float rate);                        //可以在方法调用的参数列表中声明out变量；
            if (isNumeral)
            {
                isWithinRange = rate >= MinRate && rate <= MaxRate;
                if (isWithinRange)
                {
                    isValidDecimal = (rate % 1) == 0.5 || (rate % 1) == 0;
                    if (isValidDecimal)
                    {
                        WriteLine(RateSavedTip);
                    }
                    else
                    {
                        WriteLine(InvalidDecimalWarning);
                    }
                }
                else
                {
                    WriteLine(outOfRangeWarning);
                }
            }
            else
            {
                WriteLine(NonNumeralWarning);
            }
            Read();
        }
    }
}
