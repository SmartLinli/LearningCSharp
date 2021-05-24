
namespace SmartLin.LearningCSharp.Inheritance
{
    /// <summary>
    /// 部门；
    /// </summary>
    public class Department
    {
        /// <summary>
        /// 名称；
        /// </summary>
        public string Name
        {
            get;
            private set;
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="name">名称</param>
        public Department(string name)
        {
            this.Name = name;
        }
    }
}
