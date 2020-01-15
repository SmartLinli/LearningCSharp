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
        public string SourceSchool { get; set; }
		/// <summary>
		/// 转专业
		/// </summary>
		/// <param name="newClass">新班级</param>
		public new void TransferToMajor(string newClass)                                    //定义新方法，隐藏基类方法；
		{
			WriteLine("交换生必须在指定专业就读，不能转专业。\n");
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
