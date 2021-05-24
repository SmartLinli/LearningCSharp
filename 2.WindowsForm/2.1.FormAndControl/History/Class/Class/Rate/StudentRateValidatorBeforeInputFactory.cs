using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.Oop
{
    public class StudentRateValidatorBeforeInputFactory //: IRateValidatorFactory<LearningTask>
    {
        public static IValidator Create(StudentRate rate)
        {
            ClosingDateValidator closingDateValidator = new ClosingDateValidator(rate.ClosingDate);
            LearningStatusValidator learningStatusValidator = new LearningStatusValidator(rate.Target.Status);
            learningStatusValidator.NextValidator = closingDateValidator;
            return learningStatusValidator;
        }
    }
}
