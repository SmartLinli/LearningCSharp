using System;

namespace SmartLin.LearningCSharp.FileAndRegistry
{
    /// <summary>
    /// 字符串验证特性；
    /// </summary>
    public class StringValidationAttribute : Attribute, IValidationAttribute        //定义特性；继承Attribute类；
    {
        /// <summary>
        /// 最大长度；
        /// </summary>
        public int MaxLength
        {
            get;
            private set;
        }
        /// <summary>
        /// 描述；
        /// </summary>
        public string Description
        {
            get;
            set;
        }
        /// <summary>
        /// 验证；
        /// </summary>
        /// <param name="value">取值</param>
        /// <returns>是否有效</returns>
        public bool Validate(object obj)
        {
            var value = obj as string;
            if (value.Length > this.MaxLength)
            {
                throw new ApplicationException
                    (string.Format
                        ("{0}当前长度为{1}，超出最大长度{2}"
                        , this.Description
                        , value.Length                        
                        , this.MaxLength));
            };
            return true;
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="maxLength">最大长度</param>
        public StringValidationAttribute(int maxLength)
        {
            this.MaxLength = maxLength;
        }
    }
}
