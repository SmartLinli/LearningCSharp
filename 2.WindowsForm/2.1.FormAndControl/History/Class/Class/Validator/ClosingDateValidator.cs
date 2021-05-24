using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.Oop
{
    public class ClosingDateValidator : AbstractValidator<DateTime>
    {
        protected override bool SelfCheck()
        {
            bool isValid = DateTime.Now <= this._Input;
            if (!isValid)
            {
                throw new ValidationException("已超过截止日期！");
            }
            return isValid;
        }
        public ClosingDateValidator(DateTime closingDate)
            : base(closingDate)
        {
            ;
        }
    }
}
