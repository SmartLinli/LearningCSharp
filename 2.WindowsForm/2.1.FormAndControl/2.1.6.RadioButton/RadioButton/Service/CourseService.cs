namespace SmartLin.LearningCSharp.FormAndControl
{
    /// <summary>
    /// 课程类型；
    /// </summary>
    public class CourseType
    {
        public const string PUBLIC = "公共课";
        public const string PROFESSIONAL = "专业课";
    }
    /// <summary>
    /// 课程修读类型；
    /// </summary>
    public class CourseLearningType
    {
        public const string COMPULSORY = "必修课";
        public const string OPTIONAL = "选修课";
    }
    /// <summary>
    /// 课程服务；
    /// </summary>
    public class CourseService
    {
        /// <summary>
        /// 获取所有形成性评价；
        /// </summary>
        /// <returns></returns>
        public static string[] AllFormativeAssessment =>
            new string[]
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
