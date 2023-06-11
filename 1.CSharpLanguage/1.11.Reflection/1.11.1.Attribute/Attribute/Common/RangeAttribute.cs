using System;

namespace SmartLin.LearningCSharp.Reflection
{
    /// <summary>
    /// 取值范围验证特性；
    /// </summary>
    public class RangeAttribute : Attribute, IValidationAttribute         //定义特性；自定义特性应继承Attribute类；
    {
        /// <summary>
        /// 最小值；
        /// </summary>
        public float MinValue { get; private set; }
        /// <summary>
        /// 最大值；
        /// </summary>
        public float MaxValue { get; private set; }
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
            float value = (float)obj;
            if (value < this.MinValue || value > this.MaxValue)
            {
                throw new ApplicationException
                    ($"{this.Description}当前值为{value}，超过范围{this.MinValue}～{this.MaxValue}");
            }
            return true;
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="minValue">最小值</param>
        /// <param name="maxValue">最大值</param>
        public RangeAttribute(float minValue, float maxValue)
        {
            this.MinValue = minValue;
            this.MaxValue = maxValue;
        }
    }
}
