namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
    /// <summary>
    /// 课程；
    /// </summary>
    public class Course
    {
        /// <summary>
        /// 课程号；
        /// </summary>
        public string Number { get; private set; }
		/// <summary>
		/// 名称；
		/// </summary>
		public string Name { get; private set; }
		/// <summary>
		/// 学分；
		/// </summary>
		public double Credit { get; private set; }
		/// <summary>
		/// 构造函数；
		/// </summary>
		/// <param name="number">课程号</param>
		/// <param name="name">名称</param>
		/// <param name="credit">；</param>
		public Course(string number, string name,double credit)
        {
            this.Number = number;
            this.Name = name;
            this.Credit = credit;
        }
    }
}
