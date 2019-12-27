namespace SmartLin.LearningCSharp.Inheritance
{
    /// <summary>
    /// 研究生；
    /// </summary>
    public class Postgraduate : Student
    {
        /// <summary>
        /// 导师；
        /// </summary>
        public Faculty Supervisor { get; private set; }
		/// <summary>
		/// 研究方向；
		/// </summary>
		public string Direction { get; private set; }
        /// <summary>
        /// 指定研究方向；
        /// </summary>
        /// <param name="direction">方向</param>
        public void AssignDirection(string direction)
        =>	this.Direction = direction;
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="gender">性别</param>
        public Postgraduate(string number, string name, string gender)
            : base(number, name, gender)                                                    //调用基类的构造函数；
        {
            ;
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="gender">性别</param>
        /// <param name="supervisor">导师</param>
        public Postgraduate(string number, string name, string gender, Faculty supervisor)
            : this(number, name, gender)                                                    //调用本类的构造函数；
        {
            this.Supervisor = supervisor;
        }
    }
}
