namespace SmartLin.LearningCSharp.BuilderPattern
{
    /// <summary>
    /// 考试；
    /// </summary>
    public interface IExamination
    {
        /// <summary>
        /// 课程；
        /// </summary>
        Course Course { get; set; }
        /// <summary>
        /// 考场；
        /// </summary>
        ClassRoom Room { get; set; }
        /// <summary>
        /// 监考
        /// </summary>
        Faculty Invigilator { get; set; }
        /// <summary>
        /// 显示结果；
        /// </summary>
        void ShowResult();
    }
}