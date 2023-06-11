using System;

namespace SmartLin.LearningCSharp.Reflection
{
    /// <summary>
    /// 字符串长度验证特性；
    /// </summary>
    public class StringLengthAttribute : Attribute, IValidationAttribute        //定义特性；自定义特性应继承Attribute类；
    {
        /// <summary>
        /// 最大长度；
        /// </summary>
        public int MaxLength { get; private set; }
        /// <summary>
        /// 描述；
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 验证；
        /// </summary>
        /// <param name="value">取值</param>
        /// <returns>是否有效</returns>
        public bool Validate(object obj)
        {
            string value = obj as string;
            if (value.Length > this.MaxLength)
            {
                throw new ApplicationException
                    ($"{this.Description}当前长度为{value.Length}，超过最大长度{this.MaxLength}");
            }
            return true;
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="maxLength">最大长度</param>
        public StringLengthAttribute(int maxLength)
        {
            this.MaxLength = maxLength;
        }
    }
}