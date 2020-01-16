using System;

namespace SmartLin.LearningCSharp.FormAndControl
{
    /// <summary>
    /// 高精度数值验证特性；
    /// </summary>
    public class DecimalValidationAttribute : Attribute, IValidationAttribute
    {
        /// <summary>
        /// 最小值；
        /// </summary>
        public decimal MinValue
        {
            get;
            set;
        }
        /// <summary>
        /// 最大值；
        /// </summary>
        public decimal MaxValue
        {
            get;
            set;
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
            var value = (decimal)obj;
            if (value == this.MinValue)
            {
                throw new ApplicationException
                    (string.Format
                        ("{0}已达最小值{1}"
                        , this.Description
                        , this.MinValue));
            };
            if (value == this.MaxValue)
            {
                throw new ApplicationException
                    (string.Format
                        ("{0}已达最大值{1}"
                        , this.Description
                        , this.MaxValue));
            };
            return true;
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="minValue">最小值</param>
        /// /// <param name="maxValue">最大值</param>
        public DecimalValidationAttribute(float minValue, float maxValue)           //特性参数类型仅支持部分基本类型，不支持decimal；
        {
            this.MinValue = (decimal)minValue;
            this.MaxValue = (decimal)maxValue;
        }
    }
}
