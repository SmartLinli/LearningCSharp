using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.Oop
{
    public class Score
    {
        private float _Value;
        public float Value
        {
            get
            {
                return this._Value;
            }
        }
        public string Result
        {
            get;
            set;
        }
        public string Warning
        {
            get;
            set;
        }
        public bool Save()
        {
            float score;
            bool isCompleted = false, isNumeral, isWithinRange, isValidDecimal;
            string result = "", warning = "";
            DateTime now = DateTime.Now;
            while (true)
            {
                Console.Write("\t成绩：");
                var input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                isNumeral = float.TryParse(input, out score);
                if (isNumeral)
                {
                    isWithinRange = score >= 0 && score <= 100;
                    isValidDecimal = (score * 10 % 5) == 0;
                    result = "成绩" + input;
                    if (isWithinRange && isValidDecimal)
                    {
                        this._Value = score;
                        result += "已于" + now.ToLongDateString() + "成功保存。";
                        isCompleted = true;
                    }
                    else
                    {
                        result += "未保存。";
                    }
                    warning = isWithinRange ? "" : "成绩应介于0～100之间。";
                    warning += isValidDecimal ? "" : "成绩小数部分只能为.5。";
                }
                else
                {
                    result = "无法保存" + input;
                    warning = "请输入数值。";
                }
                result = "\t结果：" + result + "\n";
                warning = warning == "" ? warning : "\t警告：" + warning + "\n";
                Console.Write(result + warning);
                if (isCompleted)
                {
                    break;
                }
            }
            return isCompleted;
        }
    }
}
