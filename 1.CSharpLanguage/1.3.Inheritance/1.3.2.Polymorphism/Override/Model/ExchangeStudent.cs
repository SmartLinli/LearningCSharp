using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
    /// <summary>
    /// 交换生；
    /// </summary>
    public sealed class ExchangeStudent : Undergraduate                                     //定义密封类；密封类不能被继承；
    {
        /// <summary>
        /// 来源学校；
        /// </summary>
        public string SourceSchool { get; set; }
        /// <summary>
        /// 注册；
        /// </summary>
        public override void Register()                                                     //重写基类方法；
        {
            this.Status = "交换生";                                                         //只有派生类实例能访问基类的受保护成员；
            WriteLine
                ($"交换生{this.Name}当前学籍为“{this.Status}”");
        }
		/// <summary>
		/// 介绍；
		/// </summary>
		public override void Intro()                                                        //重写基类方法；
		{
			Write($"我叫{this.Name}");
			Write(this.Class == null ?
						"，今天刚入学"
						: $"，来自{this.Class}");
			WriteLine(this.SourceSchool == null ?
						"，我还是交换生。"
						: $"，我还是来自{this.SourceSchool}的交换生。");
		}
		/// <summary>
		/// 构造函数；
		/// </summary>
		/// <param name="number">学号</param>
		/// <param name="name">姓名</param>
		/// <param name="gender">性别</param>
		private ExchangeStudent(string number, string name, string gender)
            : base(number, name, gender)
        {
            ;
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="gender">性别</param>
        /// <param name="currentClass">班级</param>
        /// <param name="school">学校</param>
        public ExchangeStudent(string number, string name, string gender, string currentClass, string school)
            : base(number, name, gender, currentClass)
        {
            this.SourceSchool = school;
        }
    }
}
