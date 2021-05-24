using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.Oop
{
    public abstract class AbstractConvertor<I,O> : AbstractValidator<I,O>, IConvertor<O>
    {
        protected O _Output;
        public O Output
        {
            get
            {
                return this._Output;
            }
        }
        public abstract O Convert();
        protected override bool SelfCheck()
        {
            this.Convert();
            this.NextValidator.Input(this._Output);
            return this._IsValid;
        }       
        //public AbstractConvertor(I input)
        //    : base(input)
        //{
        //    ;
        //}
        public AbstractConvertor(I input, IValidator<O> nextValidator)
            : base(input, nextValidator)
        {
            this._Output = default(O);
        }
    }
}
