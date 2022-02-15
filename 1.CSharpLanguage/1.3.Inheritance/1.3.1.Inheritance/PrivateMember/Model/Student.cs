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
		/// 修改学号；
		/// </summary>
		/// <param name="newNumber">新学号</param>
		public void ModifyNumber(string newNumber)
        {
			/*
			this.Number = newNumber;											//派生类无法修改基类的私有成员；
			*/
        }
		/// <summary>
		/// 构造函数；
		/// </summary>
		/// <param name="number">学号</param>
		/// <param name="name">姓名</param>
		/// <param name="gender">性别</param>
		public Student(string number, string name, string gender)                       
			: base(number, name, gender)										//若派生类构造函数需要初始化基类的私有成员，只能通过调用基类的构造函数来实现；                       
		{
			;
		}
	}
}
