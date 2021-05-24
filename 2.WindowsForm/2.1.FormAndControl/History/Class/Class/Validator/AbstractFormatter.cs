using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.Oop
{
    public class AbstractFormatter<I,O>:IFormatter<O>
    {
        protected I _Input;
        protected O _Output;
        public virtual O Output()
        {
            this._Output = default(O);
            return this._Output;
        }
        public AbstractFormatter()
        {
            this._Input = default(I);
        }
        public AbstractFormatter(I input)
        {
            this._Input = input;
        }
    }
}
