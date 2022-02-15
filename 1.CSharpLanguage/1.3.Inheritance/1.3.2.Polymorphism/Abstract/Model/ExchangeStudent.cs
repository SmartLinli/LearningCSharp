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
		public override void Register()                                                     //基类重写过的抽象方法，还可在派生类中被重写；
		{
			this.Status = "交换生";
			WriteLine($"交换生{this.Name}当前学籍为“{this.Status}”");
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
