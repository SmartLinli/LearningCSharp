using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.Oop
{
    public class DecimalValidator : AbstractValidator<float>
    {
        protected override bool SelfCheck()
        {
            bool isValid = (this._Input % 1) == 0 || (this._Input % 1 == 0.5);
            if (!isValid)
            {
                throw new ValidationException("小数部分只能为.5！");
            }
            return isValid;
        }
        public DecimalValidator(float input)
            : base(input)
        {
            ;
        }
    }
}
