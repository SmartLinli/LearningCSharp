
namespace SmartLin.LearningCSharp.FormAndControl
{
    /// <summary>
    /// 课程类型；
    /// </summary>
    public class CourseType
    {
        /// <summary>
        /// 公共课；
        /// </summary>
        public const string PUBLIC = "公共课";
        /// <summary>
        /// 专业课；
        /// </summary>
        public const string PROFESSIONAL = "专业课";
    }
    /// <summary>
    /// 课程修读类型；
    /// </summary>
    public class CourseLearningType
    {
        /// <summary>
        /// 必修课
        /// </summary>
        public const string COMPULSORY = "必修课";
        /// <summary>
        /// 选修课；
        /// </summary>
        public const string OPTIONAL = "选修课";
    }    
    /// <summary>
    /// 形成性评价
    /// </summary>
    public class FormativeAssessment
    {
        /// <summary>
        /// 获取形成性评价；
        /// </summary>
        /// <returns></returns>
        public static string[] All
        {
            get
            {
                return new string[]
                {
                    "课后作业",
                    "实验报告",
                    "课程设计",
                    "学习笔记",
                    "论文综述",
                    "课堂小测",
                    "小组讨论",
                    "自主学习",
                    "汇报答辩"
                };
            }
        }
    }
}
