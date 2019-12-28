using System;

namespace SmartLin.LearningCSharp.Reflection
{
    /// <summary>
    /// 字符串验证特性；
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Method)]      //该特性仅用于属性、字段、方法；
    public class StringValidationAttribute : Attribute, IValidationAttribute<string>
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
        public bool Validate(string value)
        {
            if (value.Length > this.MaxLength)
            {
                throw new ApplicationException
                    (string.Format
                        ("{0}“{1}”长度为{2}，超过最大长度{3}"
                        , this.Description
                        , value
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
