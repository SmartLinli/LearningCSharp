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
        /// 描述；
        /// </summary>
        public string Description => $"课程编号{this.Number}，名称《{this.Name}》，学分{this.Credit}分。";
        /// <summary>
        /// 课程号最大长度；
        /// </summary>
        public const int MaxLengthOfNumber = 7;
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