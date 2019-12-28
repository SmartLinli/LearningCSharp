using static System.Console;

namespace SmartLin.LearningCSharp.Basics
{
	class Program
	{
		static void Main()
		{
			bool isValid = false;
			float rate = 0;
			while (true)                                                //while适用于循环次数未知的场景；
			{
				Write($"请输入评教成绩：");
				var input = ReadLine();
				isValid = float.TryParse(input, out rate);                  //float等类型提供TryParse方法，将字符串转为float等类型，并输出至声明为out的实参，最后返回转换是否成功；
				if (!isValid)
				{
					continue;
				}
				break;
			}
			WriteLine($"评教成绩{rate}已保存。");
			Read();
		}
	}
}
