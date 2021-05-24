
namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
    /// <summary>
    /// 显示；
    /// </summary>
    /// <typeparam name="T">显示对象类型</typeparam>
    public interface IDisplay<T>                            //定义泛型接口；
    {
        /// <summary>
        /// 显示；
        /// </summary>
        /// <param name="t">显示对象</param>
        void Display(T t);
    }
}
