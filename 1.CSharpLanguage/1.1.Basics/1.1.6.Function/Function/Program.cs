using static System.Console;
namespace ConditionalStatement
{
    class Program
    {
		static bool ValidateNumeral(string input, out float rate)			//声明函数，指定其返回类型、名称、参数的类型与名称；由于主函数必须为静态函数，主函数所欲访问的函数亦须声明为静态函数；
		{
			bool isNumeral =  float.TryParse(input, out rate);
			if (!isNumeral)
			{
				WriteLine("评教成绩应为数值！");
			}
			return isNumeral;
		}			
		static bool ValidateFraction(float rate)
		{
			bool isValidFraction = (rate % 1) == 0.5 || (rate % 1) == 0;
			if (!isValidFraction)
			{
				WriteLine("评教成绩小数部分只能为.5！");
			}
			return isValidFraction;
		}
		static bool ValidateWithinRange(float rate)
		{
			int MinRate = 0, MaxRate = 5;
			bool isWithinRange = rate >= MinRate && rate <= MaxRate;
			if (!isWithinRange)
			{
				WriteLine($"评教成绩应介于{MinRate}～{MaxRate}分之间！");
			}
			return isWithinRange;
		}
		static void InputRate(string courseName)
		{
			float rate;
			while (true)
			{
				Write($"请输入《{courseName}》的评教成绩：");
				var input = ReadLine();
				if (!ValidateNumeral(input, out rate))
				{
					continue;
				}
				if (!ValidateFraction(rate))
				{
					continue;
				}
				if (!ValidateWithinRange(rate))
				{
					continue;
				}
				break;
			}
			WriteLine($"评教成绩{rate}已保存。\n");
		}
		static void InputRates(string[] courseNames)
		{
			WriteLine($"您有{courseNames.Length}门课程需要评教。");				
			for (int i = 0; i < courseNames.Length; i++)                        
			{
				WriteLine($"第{i+1}门：");
				InputRate(courseNames[i]);
			}
		}
		static void Main()
        {
			string courseName = "高等数学";
			string[] courseNames = { "计算机导论", "C语言程序设计" };              
			InputRate(courseName);												//调用函数；
			InputRates(courseNames);
            Read();
        }
    }
}
