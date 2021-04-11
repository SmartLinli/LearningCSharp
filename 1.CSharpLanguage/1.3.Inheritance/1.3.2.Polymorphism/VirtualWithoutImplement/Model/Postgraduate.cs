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
		public string Supervisor { get; private set; }
        /// <summary>
        /// 注册；
        /// </summary>
        public override void Register()                                                 //重写基类中的虚方法；
        {
            this.Status = "已注册";
            WriteLine
                ($"研究生{this.Name}当前学籍为“{this.Status}”");
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="gender">性别</param>
        /// <param name="supervisor">导师</param>
        public Postgraduate(string number, string name, string gender, string supervisor)
			: base(number, name, gender)
		{
			this.Supervisor = supervisor;
		}
	}
}
