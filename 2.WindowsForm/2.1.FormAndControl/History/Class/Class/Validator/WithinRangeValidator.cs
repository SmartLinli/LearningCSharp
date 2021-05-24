using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.Oop
{
    public class WithinRangeValidator : AbstractValidator<float>
    {
        private float _MinValue;
        private float _MaxValue;
        protected override bool SelfCheck()
        {
            bool isValid = this._Input >= this._MinValue && this._Input <= _MaxValue;
            if (!isValid)
            {
                throw new ValidationException("应介于" + this._MinValue.ToString() + "～" + this._MaxValue.ToString() + "之间！");
            }
            return isValid;
        }
        public WithinRangeValidator(float minValue, float maxValue, float input)
            : base(input)
        {
            this._MinValue = minValue;
            this._MaxValue = maxValue;
            this._Input = input;
        }
    }
}
