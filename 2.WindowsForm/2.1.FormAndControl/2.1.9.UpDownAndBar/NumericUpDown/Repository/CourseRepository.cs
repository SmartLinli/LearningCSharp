
namespace SmartLin.LearningCSharp.FormAndControl
{
    /// <summary>
    /// 课程仓储；
    /// </summary>
    public class CourseRepository
    {
        /// <summary>
        /// 获取；
        /// </summary>
        /// <returns>课程</returns>
        public static Course Get()
        {
            return
                new Course("2060316", "面向对象程序设计", 4.5m)
                {
                    IsAvailable = true,
                    HasExperiment = true,
                    HasMooc = false,
                    FormativeAssessments = new string[]
                    {
                        "课后作业",
                        "实验报告",
                        "课程设计"
                    },
                    Type = CourseType.PROFESSIONAL,
                    LearningType = CourseLearningType.COMPULSORY,
                    AppraisalType = CourseAppraisalType.EXAMINATION,
                    AppraisalForm = CourseAppraisalType.Examination.COMPUTER,
                };
        }
    }
}
