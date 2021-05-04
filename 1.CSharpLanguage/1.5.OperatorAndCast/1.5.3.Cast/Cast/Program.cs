using static System.Console;

namespace SmartLin.LearningCSharp.OperatorAndCast
{
	class Program
	{
		static void Main()
		{
			Score score = new Score(85.6);
			double scoreDoublePrecision = score;                    //调用自定义的隐式类型转换；
			Score scoreCopy = (Score)scoreDoublePrecision;          //调用自定义的显式类型转换；
			WriteLine($"成绩：{score}");								//由于第一个参数提供了格式字符串，第二个参数将被隐式调用其ToString方法；
			WriteLine($"成绩：{scoreCopy}");
			Read();
		}
	}
}
