using System;
using System.Text;

namespace SmartLin.LearningCSharp.FormAndControl
{
    /// <summary>
    /// 课程；
    /// </summary>
    public class Course
    {
        /// <summary>
        /// 课程号；
        /// </summary>
        public string Number { get; set; }
        /// <summary>
        /// 名称；
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 学分；
        /// </summary>
        public float Credit { get; set; }
        /// <summary>
        /// 是否启用；
        /// </summary>
        public bool IsAvailable { get; set; }
        /// <summary>
        /// 是否包含实验教学；
        /// </summary>
        public bool HasExperiment { get; set; }
        /// <summary>
        /// 是否包含慕课教学；
        /// </summary>
        public bool HasMooc { get; set; }
        /// <summary>
        /// 形成性评价；
        /// </summary>
        public string[] FormativeAssessments { get; set; }
        /// <summary>
        /// 类型；
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 修读类型
        /// </summary>
        public string LearningType { get; set; }
        /// <summary>
        /// 考核类型；
        /// </summary>
        public string AppraisalType { get; set; }
        /// <summary>
        /// 考核形式；
        /// </summary>
        public string AppraisalForm { get; set; }
        /// <summary>
        /// 描述；
        /// </summary>
        public string Description
        {
            get
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendFormat
                    ($"课程编号{this.Number}，名称《{this.Name}》，学分{this.Credit}分。{Environment.NewLine}" +
                     $"课程目前{(this.IsAvailable ? "已" : "未")}启用。" +
                     $"{(this.HasExperiment ? "" : "不")}包含实验教学；" +
                     $"{(this.HasMooc ? "" : "不")}包含慕课教学。{Environment.NewLine}" +
                     $"形成性评价包括");
                if (this.FormativeAssessments != null)
                {
                    foreach (var formativeAssessments in this.FormativeAssessments)
                    {
                        stringBuilder.Append($"{formativeAssessments}、");
                    }
                }
                stringBuilder.Remove(stringBuilder.Length - 1, 1).Append($"。{Environment.NewLine}");
                stringBuilder.AppendFormat($"类型为{this.Type.Substring(0, this.Type.Length - 1)}{this.LearningType}。");
                stringBuilder.AppendFormat($"考核类型为{this.AppraisalType}，考试形式为{this.AppraisalForm}。");
                return stringBuilder.ToString();
            }
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">课程号</param>
        /// <param name="name">名称</param>
        /// <param name="credit">；</param>
        public Course(string number, string name, float credit)
        {
            this.Number = number;
            this.Name = name;
            this.Credit = credit;
        }
    }
}
