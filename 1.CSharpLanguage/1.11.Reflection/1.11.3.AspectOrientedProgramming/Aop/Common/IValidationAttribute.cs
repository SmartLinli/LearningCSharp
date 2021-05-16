
namespace SmartLin.LearningCSharp.Reflection
{
    /// <summary>
    /// 验证特性；
    /// </summary>
    /// <typeparam name="T">输入类型</typeparam>
    public interface IValidationAttribute<T>
    {
        /// <summary>
        /// 属性描述；
        /// </summary>
        string Description { get; set; }
        /// <summary>
        /// 验证
        /// </summary>
        /// <param name="value">取值</param>
        /// <returns>是否有效</returns>
        bool Validate(T value);
    }
}
