namespace SmartLin.LearningCSharp.Inheritance
{
	/// <summary>
	/// 学生；
	/// </summary>
	public class Student : User                                                 
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
		}
		/// <summary>
		/// 构造函数；
		/// </summary>
		/// <param name="number">学号</param>
		/// <param name="name">姓名</param>
		/// <param name="gender">性别</param>
		public Student(string number, string name, string gender)               //定义派生类的构造函数；	
			: base(number, name, gender)                                        //调用基类的构造函数；
		{
			;
		}
	}
}
