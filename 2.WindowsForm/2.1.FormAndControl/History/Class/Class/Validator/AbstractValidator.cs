using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.Oop
{
    public abstract class AbstractValidator<I> : IValidator
    {
        protected I _Input;
        public IValidator NextValidator
        {
            get;
            set;
        }
       protected virtual bool SelfCheck()
        {
            bool isValid = true;
            if (!isValid)
            {
                throw new ValidationException("");
            }
            return isValid;
        }
        public virtual bool Check()
        {
            bool isValid = this.SelfCheck() && this.NextValidator.Check();
            return isValid;
        }
        public AbstractValidator()
        {
            this._Input = default(I);
        }
        public AbstractValidator(I input) : this()
        {
            //this._Warning = "";
            this._Input = input;
        }
        public AbstractValidator(I input, IValidator nextValidator)
            : this(input)
        {
            //this._Warning = "";
            //this._Input = input;
            this.NextValidator = nextValidator;
        }
    }
    public class ValidationException : ApplicationException
    {
        public ValidationException(string message)
            : base(message)
        {
            ;
        }
    }
}
