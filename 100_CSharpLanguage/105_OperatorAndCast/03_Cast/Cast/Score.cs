using System;

namespace SmartLin.LearningCSharp.OperatorAndCast
{
    /// <summary>
    /// 成绩；
    /// </summary>
    public class Score
    {
        /// <summary>
        /// 最小值；
        /// </summary>
        private static decimal Min = 0;
        /// <summary>
        /// 最大值；
        /// </summary>
        private static decimal Max = 100;
        /// <summary>
        /// 数值；
        /// </summary>
        public decimal Numeral
        {
            get;
            private set;
        }
        /// <summary>
        /// 输入数值；
        /// </summary>
        /// <param name="input">输入</param>
        public void InputNumeral(decimal input)
        {
            if (input < Min)
            {
                this.Numeral = Min;
                return;
            }
            if (input > Max)
            {
                this.Numeral = Max;
                return;
            }
            decimal decimalPart = input - (int)input;
            if (decimalPart < 0.5m)
            {
                decimalPart = 0;
            }
            else
            {
                decimalPart = 0.5m;
            }
            this.Numeral = (int)input + decimalPart;
        }
        /// <summary>
        /// 隐式转为双精度值；
        /// </summary>
        /// <param name="value">成绩</param>
        /// <returns>双精度值</returns>
        public static implicit operator double(Score value)             //定义源类型为Score、目标类型为的隐式类型转换；
        {
            return (double)value.Numeral;
        }
        /// <summary>
        /// 显式转为成绩；
        /// </summary>
        /// <param name="value">双精度值</param>
        /// <returns>成绩</returns>
        public static explicit operator Score(double value)             //定义源类型为双精度浮点数、目标类型为Score的显式类型转换；
        {
            Score score = new Score(Min, Max);
            score.InputNumeral((Decimal)value);
            return score;
        }
        /// <summary>
        /// 转为字符串；
        /// </summary>
        /// <returns>字符串</returns>
        public override string ToString()
        {
            return this.Numeral.ToString();
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="min">最小值</param>
        /// <param name="max">最大值</param>
        public Score(decimal min, decimal max)
        {
            Min = min;
            Max = max;
        }
    }
}
