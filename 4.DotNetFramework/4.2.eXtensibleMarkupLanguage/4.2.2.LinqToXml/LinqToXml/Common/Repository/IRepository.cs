using System.Collections.Generic;

namespace SmartLin.LearningCSharp.eXtensibleMarkupLanguage
{
    /// <summary>
    /// 仓储；
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T>
    {
        /// <summary>
        /// 查找所有；
        /// </summary>
        /// <returns>对象列表</returns>
        List<T> FindAll();
        /// <summary>
        /// 查找；
        /// </summary>
        /// <param name="number">编号</param>
        /// <returns>对象</returns>
        T FindBy(string number);
        /// <summary>
        /// 更新；
        /// </summary>
        /// <param name="oldNumber">旧编号</param>
        /// <param name="t">对象</param>
        void Update(string oldNumber, T t);
    }
}
