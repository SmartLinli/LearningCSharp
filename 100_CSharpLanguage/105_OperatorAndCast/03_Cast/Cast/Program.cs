using System;

namespace SmartLin.LearningCSharp.OperatorAndCast
{
	class Program
    {
        static void Main()
        {
            Score score = new Score(0, 100);
            score.InputNumeral(85.6m);
            double scoreDoublePrecision = score;                    //调用自定义的隐式类型转换；
            Score score2 = (Score)scoreDoublePrecision;             //调用自定义的显式类型转换；
            Console.WriteLine("成绩：{0}", score);					//由于第一个参数提供了格式字符串，第二个参数将被隐式调用其ToString方法；
            Console.WriteLine("成绩：{0}", score2);
            Console.Read();
        }
    }
}
