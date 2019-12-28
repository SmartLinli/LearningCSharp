
namespace SmartLin.LearningCSharp.BuilderPattern
{
    /// <summary>
    /// 考试建造者；
    /// </summary>
    public interface IExaminationBuilder
    {
        /// <summary>
        /// 建造考试；
        /// </summary>
        /// <returns>考试</returns>
        IExamination Build();
    }
}
