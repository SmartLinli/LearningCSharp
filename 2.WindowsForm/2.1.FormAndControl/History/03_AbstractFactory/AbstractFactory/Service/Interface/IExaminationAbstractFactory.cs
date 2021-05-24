
namespace SmartLin.LearningCSharp.FactoryPattern
{
    /// <summary>
    /// 考试抽象工厂；
    /// </summary>
    public interface IExaminationAbstractFactory
    {
        /// <summary>
        /// 创建考场；
        /// </summary>
        /// <returns>考场</returns>
        IExaminationRoom CreateExaminationRoom();
        /// <summary>
        /// 创建监考；
        /// </summary>
        /// <returns>监考</returns>
        IInvigilator CreateInvigilator();
        /// <summary>
        /// 创建考试；
        /// </summary>
        /// <param name="courseName">课程名称</param>
        /// <returns>考试</returns>
        IExamination CreateExamination(string courseName);
    }
}
