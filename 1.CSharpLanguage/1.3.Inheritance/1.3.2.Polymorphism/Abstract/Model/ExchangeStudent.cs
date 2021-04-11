using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
    /// <summary>
    /// 交换生；
    /// </summary>
    public class ExchangeStudent : Undergraduate                                     
    {
        /// <summary>
        /// 来源学校；
        /// </summary>
        public string SourceSchool { get; private set; }
		/// <summary>
		/// 注册；
		/// </summary>
		public override void Register()                                                     //重写基类中的虚方法；
		{
			this.Status = "交换生";                                                         
			WriteLine
				($"交换生{this.Name}当前学籍为“{this.Status}”");
		}
		/// <summary>
		/// 构造函数；
		/// </summary>
		/// <param name="number">学号</param>
		/// <param name="name">姓名</param>
		/// <param name="gender">性别</param>
		/// <param name="currentClass">班级</param>
		/// <param name="sourceSchool">学校</param>
		public ExchangeStudent(string number, string name, string gender, string currentClass, string sourceSchool)
            : base(number, name, gender, currentClass)
        {
            this.SourceSchool = sourceSchool;
        }
    }
}
