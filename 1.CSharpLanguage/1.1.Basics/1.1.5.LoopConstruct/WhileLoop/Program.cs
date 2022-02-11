using static System.Console;

namespace SmartLin.LearningCSharp.Basics
{
	class Program
	{
		static void Main()
		{
			bool isValid = false;
			float rate = 0;
			while (!isValid)                                                //while适用于循环次数未知的场景；
			{
				Write($"请输入评教成绩：");
				var input = ReadLine();
				isValid = float.TryParse(input, out rate);                  
			}
			Write($"评教成绩{rate}已保存。");
			Read();
		}
	}
}
