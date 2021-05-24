
namespace SmartLin.LearningCSharp.FactoryPattern
{
    /// <summary>
    /// 考试；
    /// </summary>
    public interface IExamination
    {
        /// <summary>
        /// 课程名称；
        /// </summary>
        string CourseName
        {
            get;
            set;
        }
        /// <summary>
        /// 考场；
        /// </summary>
        IExaminationRoom Room
        {
            get;
            set;
        }
        /// <summary>
        /// 监考
        /// </summary>
        IInvigilator Invigilator
        {
            get;
            set;
        }
        /// <summary>
        /// 显示结果；
        /// </summary>
        void ShowResult();
    }
}
