namespace SmartLin.LearningCSharp.FormAndControl
{
    /// <summary>
    /// 课程仓储；
    /// </summary>
    public class CourseRepository
    {
        /// <summary>
        /// 查找；
        /// </summary>
        /// <param name="number">课程号</param>
        /// <returns>课程</returns>
        public static Course Find(string number)
        {
            return
                new Course("2060316", "面向对象程序设计", 4.5m)
                {
                    TheoreticalHour = 36,
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
                    Syllabus = @"{\rtf1\ansi\ansicpg936\deff0\nouicompat\deflang1033\deflangfe2052{\fonttbl{\f0\fnil\fcharset134 \'cb\'ce\'cc\'e5;}}{\*\generator Riched20 6.3.9600 }\viewkind4\uc1 \pard\b\f0\fs18\lang2052\'d5\'c6\'ce\'d5\b0\'a3\'ba\ul\'c0\'e0\'ba\'cd\'b6\'d4\'cf\'f3\ulnone\'a3\'bb\par\b\'c0\'ed\'bd\'e2\b0\'a3\'ba\'bc\'cc\'b3\'d0\'ba\'cd\'b6\'e0\'cc\'ac\'a3\'bb\par\b\'c1\'cb\'bd\'e2\b0\'a3\'ba\i\'d5\'fd\'d4\'f2\'b1\'ed\'b4\'ef\'ca\'bd\i0\'a3\'bb\par}"
                };
        }        
    }
}
