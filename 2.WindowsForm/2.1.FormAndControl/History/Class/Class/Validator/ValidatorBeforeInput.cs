using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.Oop
{
    public class ValidatorBeforeInputRate : AbstractValidator<object>
    {
        protected override bool SelfCheck()
        {
            return true;
        }
        public override bool Check()
        {
            try
            {
                return base.Check();
            }
            catch (ValidationException ex)
            {
                throw new ValidationBeforeInputException(ex.Message);
            }

        }
        public static ValidatorBeforeInputRate PreValidatorProvider(ValidationItemBeforeInputRate validationItem)
        {
            ValidatorBeforeInputRate preValidator = new ValidatorBeforeInputRate();
            ClosingDateValidator closingDateValidator = new ClosingDateValidator(validationItem.ClosingDate);
            LearningStatusValidator learningStatusValidator = new LearningStatusValidator(validationItem.LearningStatus);
            learningStatusValidator.NextValidator = closingDateValidator;
            preValidator.NextValidator = learningStatusValidator;
            return preValidator;
        }
        public ValidatorBeforeInputRate()
            : base()
        {
            ;
        }
    }
    public class ValidationBeforeInputException : ApplicationException
    {
        public ValidationBeforeInputException(string message)
            : base(message)
        {
            ;
        }
    }
}
