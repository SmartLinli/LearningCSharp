using System;

namespace SmartLin.LearningCSharp.Intro
{
    static class ProcedureOrientedProgramming
    {
        const int MinRate = 0, MaxRate = 5;
        const string 
            InvalidDecimalWarning = "评教成绩小数部分只能为.5。",
            NonNumeralWarning = "请输入数值。";
        static string
            outOfRangeWarning = "评教成绩应介于"
                            + MinRate.ToString() + "～"
                            + MaxRate.ToString() + "分之间。",
            Result,
            Warning;
        static float Rate;
        static string InputRate()
        {
            Console.Write("请输入评教成绩：");
            var input = Console.ReadLine();
            return input;
        }
        static bool ValidateNumeral(string input)
        {
            bool isNumeral;
            isNumeral = float.TryParse(input, out Rate);
            Warning += isNumeral ? "" : NonNumeralWarning;
            return isNumeral;
        }
        static bool ValidateRange()
        {
            bool isWithinRange;
            isWithinRange = Rate >= MinRate && Rate <= MaxRate;
            Warning += isWithinRange ? "" : outOfRangeWarning;
            return isWithinRange;
        }
        static bool ValidateDecimal()
        {
            bool isValidDecimal;
            isValidDecimal = (Rate % 1) == 0 || (Rate % 1) == 0.5;
            Warning += isValidDecimal ? "" : InvalidDecimalWarning;
            return isValidDecimal;
        }
        static void Rating()
        {
            bool isCompleted = false;
            DateTime now = DateTime.Now;
            while (!isCompleted)
            {
                Result = "结果：";
                Warning = "";
                string input = InputRate();
                if (ValidateNumeral(input) && ValidateRange() && ValidateDecimal())
                {
                    Result += "评教成绩已于" + now.ToLongDateString() + "成功保存。";
                    isCompleted = true;
                }
                else
                {
                    Result += "评教成绩未保存。";

                }
                Warning = Warning == "" ? Warning : "\n警告：" + Warning + "\n";
                Console.Write(Result + Warning);
            }
            Console.Read();
        }
        static void Main()
        {
            Rating();          
        }
    }
}
