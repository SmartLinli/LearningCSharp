using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.Oop
{
    public class ValidatorAfterInput:AbstractValidator<object>
    {
        protected override bool SelfCheck()
        {
            return true;
        }
        public static ValidatorAfterInput ValidatorProvider(float rate)
        {
            ValidatorAfterInput validator = new ValidatorAfterInput();
            const int MinRate = 0, MaxRate = 5;
            WithinRangeValidator withinRangeValidator = new WithinRangeValidator(MinRate, MaxRate, rate);
            DecimalValidator decimalValidator = new DecimalValidator(rate);
            decimalValidator.NextValidator = withinRangeValidator;
            validator.NextValidator = decimalValidator;
            return validator;
        }
        public ValidatorAfterInput()
            : base()
        {
            ;
        }
    }
}
