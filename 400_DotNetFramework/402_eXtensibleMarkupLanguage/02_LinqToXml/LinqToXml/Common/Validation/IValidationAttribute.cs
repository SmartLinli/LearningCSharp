
namespace SmartLin.LearningCSharp.eXtensibleMarkupLanguage
{
    /// <summary>
    /// 验证特性；
    /// </summary>
    public interface IValidationAttribute
    {
        /// <summary>
        /// 属性描述；
        /// </summary>
        string Description
        {
            get;
            set;
        }
        /// <summary>
        /// 验证
        /// </summary>
        /// <param name="value">取值</param>
        /// <returns>是否有效</returns>
        bool Validate(object obj);
    }
}
