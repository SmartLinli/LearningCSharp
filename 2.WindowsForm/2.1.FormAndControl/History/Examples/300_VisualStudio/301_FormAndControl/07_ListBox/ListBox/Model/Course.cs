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
        [StringValidation(7, Description = "课程号")]
        public string Number
        {
            get;
            set;
        }
        /// <summary>
        /// 名称；
        /// </summary>
        [StringValidation(10, Description = "课程名称")]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// 学分；
        /// </summary>
        public float Credit
        {
            get;
            set;
        }
        /// <summary>
        /// 是否启用；
        /// </summary>
        public bool IsAvailable
        {
            get;
            set;
        }
        /// <summary>
        /// 包含实验教学；
        /// </summary>
        public bool HasExperiment
        {
            get;
            set;
        }
        /// <summary>
        /// 包含慕课教学；
        /// </summary>
        public bool HasMooc
        {
            get;
            set;
        }
        /// <summary>
        /// 形成性评价；
        /// </summary>
        public string[] FormativeAssessments
        {
            get;
            set;
        }
        /// <summary>
        /// 类型；
        /// </summary>
        public string Type
        {
            get;
            set;
        }
        /// <summary>
        /// 修读类型
        /// </summary>
        public string LearningType
        {
            get;
            set;
        }
        /// <summary>
        /// 考核类型；
        /// </summary>
        public string AppraisalType
        {
            get;
            set;
        }
        /// <summary>
        /// 考核形式；
        /// </summary>
        public string AppraisalForm
        {
            get;
            set;
        }
        /// <summary>
        /// 描述；
        /// </summary>
        public string Description
        {
            get
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendFormat
                    ("课程编号{0}，名称《{1}》，学分{2}分。\r\n课程目前{3}启用。{4}包含实验教学；{5}包含慕课教学。\r\n形成性评价包括"
                    , this.Number
                    , this.Name
                    , this.Credit
                    , this.IsAvailable ? "已" : "未"
                    , this.HasExperiment ? "" : "不"
                    , this.HasMooc ? "" : "不");
                if (this.FormativeAssessments != null)
                {
                    foreach (var formativeAssessments in this.FormativeAssessments)
                    {
                        stringBuilder.Append(formativeAssessments + "、");
                    }
                }
                stringBuilder.Remove(stringBuilder.Length - 1, 1).Append("。\r\n");
                stringBuilder.AppendFormat("类型为{0}{1}。", this.Type.Substring(0, this.Type.Length - 1), this.LearningType);
                stringBuilder.AppendFormat("考核类型为{0}，考试形式为{1}。", this.AppraisalType, this.AppraisalForm);
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
