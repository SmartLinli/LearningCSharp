
namespace SmartLin.LearningCSharp.BridgePattern
{
    /// <summary>
    /// 课程运行；
    /// </summary>
    public interface ICourseOperation                               //定义实现者接口；
    {
        /// <summary>
        /// 作业；
        /// </summary>
        void Exercise();
        /// <summary>
        /// 考试；
        /// </summary>
        void Examine();
    }
}
