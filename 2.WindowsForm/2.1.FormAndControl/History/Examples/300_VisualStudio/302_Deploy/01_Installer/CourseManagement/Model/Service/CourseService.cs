using System;

namespace SmartLin.LearningCSharp.Installer
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
    /// 课程考核类型；
    /// </summary>
    public class CourseAppraisalType
    {
        /// <summary>
        /// 考试；
        /// </summary>
        public const string EXAMINATION = "考试";
        /// <summary>
        /// 考查；
        /// </summary>
        public const string TEST = "考查";
        /// <summary>
        /// 考试；
        /// </summary>
        public static class Examination
        {
            /// <summary>
            /// 闭卷；
            /// </summary>
            public const string CLOSED_BOOK = "闭卷";
            /// <summary>
            /// 开卷；
            /// </summary>
            public const string OPEN_BOOK = "开卷";
            /// <summary>
            /// 上机；
            /// </summary>
            public const string COMPUTER = "上机";
            /// <summary>
            /// 口试；
            /// </summary>
            public const string ORAL = "口试";
        }
        /// <summary>
        /// 考查；
        /// </summary>
        public static class Test
        {
            /// <summary>
            /// 论文；
            /// </summary>
            public const string PAPER = "论文";
            /// <summary>
            /// 报告；
            /// </summary>
            public const string REPORT = "报告";
            /// <summary>
            /// 设计；
            /// </summary>
            public const string DESIGN = "设计";
            /// <summary>
            /// 操作；
            /// </summary>
            public const string OPERATION = "操作";
        }
        /// <summary>
        /// 获取课程考核类型；
        /// </summary>
        /// <returns>课程考核类型</returns>
        public static string[] GetTypes()
        {
            return new string[] { EXAMINATION, TEST };
        }
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
                        return new string[] { Test.PAPER, Test.REPORT, Test.DESIGN, Test.OPERATION };
                    }
            }
            return null;
        }
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
    /// <summary>
    /// 课程服务；
    /// </summary>
    public class CourseService
    {
        /// <summary>
        /// 设置默认学分；
        /// </summary>
        /// <param name="credit">学分</param>
        public static void SetDefaultCredit(decimal credit)
        {
            RegistryService.SetValue("CourseCreditDefault", credit);
        }
        /// <summary>
        /// 获取默认学分；
        /// </summary>
        /// <returns>学分</returns>
        public static decimal GetDefaultCredit()
        {
            decimal credit =
                Convert.ToDecimal(RegistryService.GetValue("CourseCreditDefault"));
            return credit;
        }
    }
}
