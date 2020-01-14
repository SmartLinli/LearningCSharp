using static System.Console;

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
        public string Supervisor { get; set; }
		/// <summary>
		/// 研究方向；
		/// </summary>
		public string Direction { get; private set; }
		/// <summary>
		/// 指定研究方向；
		/// </summary>
		/// <param name="direction">方向</param>
		public void AssignDirection(string direction)
		{
			this.Direction = direction;
			WriteLine($"{this.Name}研究方向：{this.Direction}\n");
		}
		/// <summary>
		/// 构造函数；
		/// </summary>
		/// <param name="number">学号</param>
		/// <param name="name">姓名</param>
		/// <param name="gender">性别</param>
		public Postgraduate(string number, string name, string gender)
            : base(number, name, gender)                                                   
        {
            ;
        }
    }
}
