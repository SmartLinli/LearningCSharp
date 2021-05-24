using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.Oop
{
    public class LearningStatusValidator : AbstractValidator<LearningStatus>
    {
        protected override bool SelfCheck()
        {
            bool isValid = this._Input != LearningStatus.Retaking;
            if (!isValid)
            {
                throw new ValidationException("重修生不参与评教。");                
            }
            return isValid;
        }
        public LearningStatusValidator(LearningStatus learingStatus)
            : base(learingStatus)
        {

        }
        //public LearningStatusValidator(LearningStatus learningStatus, IValidator<I2> nextValidator)
        //    : base(learningStatus ,nextValidator)
        //{
        //    ;
        //}
    }
}
