using System.Collections.Generic;

namespace SmartLin.LearningCSharp.eXtensibleMarkupLanguage
{
    /// <summary>
    /// 模拟课程仓储；
    /// </summary>
    public class MockCourseRepository : IRepository<Course>
    {
        /// <summary>
        /// 查找所有；
        /// </summary>
        /// <returns>课程列表</returns>
        public List<Course> FindAll()
        {
            return new List<Course>()
            {
                new Course("2020046", "高等数学", 5m)
                {
                    TheoreticalHour = 80,
                    IsAvailable = true,
                    HasExperiment = false,
                    HasMooc = false,
                    FormativeAssessments = new string[]
                    {
                        "课后作业",
                        "学习笔记",
                        "课堂小测"
                    },
                    Type = CourseType.PROFESSIONAL,
                    LearningType = CourseLearningType.COMPULSORY,
                    AppraisalType = CourseAppraisalType.EXAMINATION,
                    AppraisalForm = CourseAppraisalType.Examination.CLOSED_BOOK,
                },
                new Course("2060316", "面向对象程序设计", 4.5m)
                {
                    TheoreticalHour = 36,
                    IsAvailable = true,
                    HasExperiment = true,
                    HasMooc = false,
                    FormativeAssessments = new string[]
                    {
                        "课后作业",
                        "学习笔记",
                        "自主学习"
                    },
                    Type = CourseType.PROFESSIONAL,
                    LearningType = CourseLearningType.COMPULSORY,
                    AppraisalType = CourseAppraisalType.EXAMINATION,
                    AppraisalForm = CourseAppraisalType.Examination.COMPUTER,
                },
                new Course("2060310", "动态网站建设", 4.5m)
                {
                    TheoreticalHour = 36,
                    IsAvailable = true,
                    HasExperiment = true,
                    HasMooc = false,
                    FormativeAssessments = new string[]
                    {
                        "实验报告",
                        "课程设计",
                        "汇报答辩"
                    },
                    Type = CourseType.PROFESSIONAL,
                    LearningType = CourseLearningType.OPTIONAL,
                    AppraisalType = CourseAppraisalType.EXAMINATION,
                    AppraisalForm = CourseAppraisalType.Examination.COMPUTER,
                },
                new Course("2060089", "英语1", 4m)
                {
                    TheoreticalHour = 32,
                    IsAvailable = true,
                    HasExperiment = true,
                    HasMooc = true,
                    FormativeAssessments = new string[]
                    {
                        "课堂小测",
                        "小组讨论",
                        "自主学习"
                    },
                    Type = CourseType.PUBLIC,
                    LearningType = CourseLearningType.COMPULSORY,
                    AppraisalType = CourseAppraisalType.EXAMINATION,
                    AppraisalForm = CourseAppraisalType.Examination.CLOSED_BOOK,
                }
            };
        }
        /// <summary>
        /// 查找；
        /// </summary>
        /// <param name="number">编号</param>
        /// <returns>课程</returns>
        public Course FindBy(string number)
        {
            return this.FindAll().Find(c => c.Number == number);
        }
        /// <summary>
        /// 更新；
        /// </summary>
        /// <param name="oldNumber">旧编号</param>
        /// <param name="course">课程</param>
        public void Update(string oldNumber, Course course)
        {
            Course oldCourse = this.FindAll().Find(c => c.Number == oldNumber);
            oldCourse = course;
        }
    }
}
