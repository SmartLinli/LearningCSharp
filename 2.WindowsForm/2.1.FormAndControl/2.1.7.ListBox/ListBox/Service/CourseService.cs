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
    /// 课程考核类型；
    /// </summary>
    public class CourseAppraisalType
    {
        public const string EXAMINATION = "考试";
        public const string TEST = "考查";
        /// <summary>
        /// 考试；
        /// </summary>
        public static class Examination
        {
            public const string CLOSED_BOOK = "闭卷";
            public const string OPEN_BOOK = "开卷";
            public const string COMPUTER = "上机";
            public const string ORAL = "口试";
        }
        /// <summary>
        /// 考查；
        /// </summary>
        public static class Test
        {
            public const string PAPER = "论文";
            public const string REPORT = "报告";
            public const string DESIGN = "设计";
            public const string OPERATION = "操作";
            public const string CERTIFICATE = "证书";
        }
        /// <summary>
        /// 获取所有课程考核类型；
        /// </summary>
        /// <returns>课程考核类型</returns>
        public static string[] AllTypes =>
            new string[] { EXAMINATION, TEST };
        /// <summary>
        /// 获取课程考核形式；
        /// </summary>
        /// <param name="typeName">课程考核类型名称</param>
        /// <returns>课程考核形式</returns>
        public static string[] GetForms(string typeName)
        {
            switch (typeName)
            {
                case EXAMINATION:
                    {
                        return new string[] { Examination.CLOSED_BOOK, Examination.OPEN_BOOK, Examination.COMPUTER, Examination.ORAL };
                    }
                case TEST:
                    {
                        return new string[] { Test.PAPER, Test.REPORT, Test.DESIGN, Test.OPERATION, Test.CERTIFICATE };
                    }
            }
            return null;
        }
    }
    /// <summary>
    /// 课程服务；
    /// </summary>
    public class CourseService
    {
        /// <summary>
        /// 获取所有形成性评价；
        /// </summary>
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
