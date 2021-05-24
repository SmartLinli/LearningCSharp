using System.Text;
using System.ComponentModel;

namespace SmartLin.LearningCSharp.FormAndControl
{
    /// <summary>
    /// 课程；
    /// </summary>
    public class Course : INotifyPropertyChanged                                        //继承INotifyPropertyChanged接口，用于向执行绑定的客户端发出某一属性值已更改的通知；
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
        private decimal _Credit;
        /// <summary>
        /// 学分；
        /// </summary>
        [DecimalValidation(1, 10, Description = "学分")]
        public decimal Credit
        {
            get
            {
                return this._Credit;
            }
            set
            {
                this._Credit = value;
                this.TheoreticalHour = this._TheoreticalHour;
                this.OnPropertyChanged("TotalHour");
            }
        }
        /// <summary>
        /// 总课时；
        /// </summary>
        public int TotalHour
        {
            get
            {
                return (int)(this.Credit * 16m);
            }
        }
        private int _TheoreticalHour;
        /// <summary>
        /// 理论课时；
        /// </summary>
        public int TheoreticalHour
        {
            get
            {
                return this._TheoreticalHour;
            }
            set
            {
                this._TheoreticalHour = (value > this.TotalHour ? this.TotalHour : value);
                this.OnPropertyChanged("CourseHourDistribution");
            }
        }
        /// <summary>
        /// 实验课时；
        /// </summary>
        public int ExperimentalHour
        {
            get
            {
                return this.TotalHour - this._TheoreticalHour;
            }
        }
        /// <summary>
        /// 课时分配；
        /// </summary>
        public string CourseHourDistribution
        {
            get
            {
                return string.Format
                    ("课时分配：理论课{0}节，实验课{1}节，共{2}节。"
                    , this.TheoreticalHour
                    , this.ExperimentalHour
                    , this.TotalHour);
            }
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
                    ("课程编号{0}，名称《{1}》，学分{2}分。\r\n总课时{3}节，其中理论课{4}节、实验课{5}节。\r\n课程目前{6}启用。{7}包含实验教学；{8}包含慕课教学。\r\n形成性评价包括"
                    , this.Number
                    , this.Name
                    , this.Credit
                    , this.TotalHour
                    , this.TheoreticalHour
                    , this.ExperimentalHour
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
        /// 属性更改事件；
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;                       //实现INotifyPropertyChanged接口的PropertyChanged事件；
        /// <summary>
        /// 当属性更改时；
        /// </summary>
        /// <param name="propertyName"></param>
        public void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">课程号</param>
        /// <param name="name">名称</param>
        /// <param name="credit">；</param>
        public Course(string number, string name, decimal credit)
        {
            this.Number = number;
            this.Name = name;
            this.Credit = credit;
            this.TheoreticalHour = this.TotalHour;
        }
    }
}
