using static System.Console;

namespace ConditionalStatement
{
    class Program
    {
        static void Main()
        {
            int MinRate = 0, MaxRate = 5;
			bool
				isNumeral = false,
				isValidFraction = false,
				isWithinRange = false;
            Write("请输入评教成绩：");
            var input = ReadLine();
            isNumeral = float.TryParse(input, out float rate);
			if (!isNumeral)
			{
				WriteLine("评教成绩应为数值！");
				Read();
				return;
			}
			isValidFraction = (rate % 1) == 0.5 || (rate % 1) == 0;
			if (!isValidFraction)
			{
				WriteLine("评教成绩小数部分只能为.5！");
				Read();
				return;
			}
			isWithinRange = rate >= MinRate && rate <= MaxRate;
			if (!isWithinRange)
			{
				WriteLine($"评教成绩应介于{MinRate}～{MaxRate}分之间！");
				Read();
				return;
			}
			WriteLine("评教成绩已保存。");
            Read();
        }
    }
}
