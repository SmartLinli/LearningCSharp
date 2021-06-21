namespace SmartLin.LearningCSharp.TemplateMethod
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
        IExaminationRoom Room { get; set; }
        /// <summary>
        /// 监考人员；
        /// </summary>
        IFaculty Invigilator { get; set; }
    }
}