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
		public string Status { get; protected set; }					//只有派生类实例才能访问基类的受保护成员；
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="gender">性别</param>
        public Student(string number, string name, string gender)
            : base(number, name, gender)
        {
            ;
        }
    }
}
