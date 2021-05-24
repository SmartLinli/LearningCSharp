using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.Oop
{
    public class MultiValidator:AbstractValidator<string>
    {
        public IValidator[] Validators
        {
            get;
            set;
        }
        public override bool SelfCheck()
        {
            bool isValid = true;
            foreach (IValidator validator in this.Validators)
            {
                isValid = isValid && validator.Check();
                if (!isValid)
                {
                    this._Warning += validator.Warning;
                    break;
                }
            }
            return isValid;
        }
        public MultiValidator():base()
        {
            ;
        }
        public MultiValidator(string input)
            : base(input)
        {
            this._Warning = "";
            this._Input = input;
        }
    }
}
