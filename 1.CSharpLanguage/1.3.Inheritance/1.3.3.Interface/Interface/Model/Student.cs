namespace SmartLin.LearningCSharp.Inheritance
{
	/// <summary>
	/// 学生；
	/// </summary>
	public class Student : User										
    {
		/// <summary>
		/// 构造函数； 
		/// </summary>
		/// <param name="number">学号</param>
		/// <param name="name">姓名</param>
		public Student(string number, string name)
            : base(number, name)
        {
            ;
        }
    }
}
