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
        /// 介绍；
        /// </summary>
        public override void Intro()                                                        //重写基类方法；
        {
            var introduction =
                $"我叫{this.Name}" +
                $"{(this.Class == null ? "，今天刚入学。" : $"，来自{this.Class}。")}" +
                $"{(this.SourceSchool == null ? "我还是交换生。" : $"我还是来自{this.SourceSchool}的交换生。")}";
            WriteLine(introduction);
        }
		/// <summary>
		/// 构造函数；
		/// </summary>
		/// <param name="number">学号</param>
		/// <param name="name">姓名</param>
		/// <param name="gender">性别</param>
		/// <param name="currentClass">班级</param>
		/// <param name="sourceSchool">来源学校</param>
		public ExchangeStudent(string number, string name, string gender, string currentClass, string sourceSchool)
            : base(number, name, gender, currentClass)
        {
            this.SourceSchool = sourceSchool;
        }
    }
}
