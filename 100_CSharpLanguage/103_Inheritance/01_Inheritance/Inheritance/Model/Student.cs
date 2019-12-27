using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
	/// <summary>
	/// 学生；
	/// </summary>
	public class Student : User                                                 //定义类，派生于指定的基类；
    {
        /// <summary>
        /// 学籍；
        /// </summary>
        public string Status { get; private set; }
		/// <summary>
		/// 注册；
		/// </summary>
		public void Register()
		{
			this.Status = "在读";
			WriteLine($"{this.Name}当前学籍：{this.Status}\n");
		}
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="gender">性别</param>
        public Student(string number, string name, string gender)               
            : base(number, name, gender)                                        //调用基类的构造函数；
        {
            ;
        }                                                 
    }
}
