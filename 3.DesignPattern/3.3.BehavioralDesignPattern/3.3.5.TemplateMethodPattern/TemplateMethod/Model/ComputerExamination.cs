namespace SmartLin.LearningCSharp.TemplateMethod
{

    /// <summary>
    /// 上机考试；
    /// </summary>
    public class ComputerExamination : IExamination
    {
        /// <summary>
        /// 课程；
        /// </summary>
        public Course Course { get; set; }
        /// <summary>
        /// 考场；
        /// </summary>
        public IExaminationRoom Room { get; set; }
        /// <summary>
        /// 监考人员；
        /// </summary>
        public IFaculty Invigilator { get; set; }
    }
}