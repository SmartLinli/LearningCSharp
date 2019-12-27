using System.Diagnostics;
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
			/*if (!isNumeral)
			{
				WriteLine("评教成绩应为数值！");
				Read();
				return;
			}*/
			#region 调试断言
			Debug.Assert                                                                //调试断言将在表达式为假的情况下中断程序，并将信息显示在输出窗口与对话框；
				(isNumeral
				, $"当前输入{input}未能转为数值，流程不应通过if语句。"
				, "请检查if语句。");
			#endregion
			isValidFraction = (rate % 1) == 0.5 || (rate % 1) == 0;
			if (!isValidFraction)
			{
				WriteLine("评教成绩小数部分只能为.5！");
				Read();
				return;
			}
			isWithinRange = rate >= MinRate ||/*&&*/ rate <= MaxRate;
			if (!isWithinRange)
			{
				WriteLine($"评教成绩应介于{MinRate}～{MaxRate}分之间！");
				Read();
				return;
			}
			#region 调试信息
			Debug.WriteLine                                                         //调试信息将显示在输出窗口，且不会被编译至发布程序；                                    
				($"评教成绩{rate}{(isWithinRange ? "未" : "")}超出{MinRate}～{MaxRate}范围。请确认是否属实。"
				, "自定义调试信息：");
			#endregion
			WriteLine("评教成绩已保存。");
			Read();
        }
    }
}
