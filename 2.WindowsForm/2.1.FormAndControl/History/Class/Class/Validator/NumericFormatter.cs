using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.Oop
{
    public class NumericFormatter : AbstractFormatter<string, float>
    {
        public override float Output()
        {
            bool isValid = float.TryParse(this._Input, out this._Output);
            if (!isValid)
            {
                throw new ValidationException("请输入数值！");
            }
            return this._Output;
        }
        public NumericFormatter(string input)
            : base(input)
        {
            //this._Warning = "";
            //this._NextValidator = nextValidator;
            //this._IsValid = true;
            //this._Output = 0;
        }
    }
}
