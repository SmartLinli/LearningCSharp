
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
        /// 描述；
        /// </summary>
        public string Description
        {
            get
            {
                return string.Format
                    ("课程编号{0}，名称《{1}》，学分{2}分。"
                    , this.Number
                    , this.Name
                    , this.Credit);
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
