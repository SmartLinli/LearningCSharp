using static System.Console;
namespace SmartLin.LearningCSharp.Basics
{
	class Program
	{
		static void Main()
		{
			const int MinRate = 0, MaxRate = 5;
			bool
				isNumeral,
				isValidFraction,
				isWithinRange;
			float rate;
			string input;
			Write("请输入评教成绩：");
			input = ReadLine();
			isNumeral = float.TryParse(input, out rate);
			if (!isNumeral)
			{
				Write("评教成绩应为数值！");
				Read();
				return;
			}
			isValidFraction = (rate % 1) == 0.5 || (rate % 1) == 0;
			if (!isValidFraction)
			{
				Write("评教成绩小数部分只能为.5！");
				Read();
				return;
			}
			isWithinRange = rate >= MinRate && rate <= MaxRate;
			if (!isWithinRange)
			{
				Write($"评教成绩应介于{MinRate}～{MaxRate}分之间！");
				Read();
				return;
			}
			Write("评教成绩已保存。");
			Read();
		}
	}
}
