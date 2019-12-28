namespace SmartLin.LearningCSharp.Inheritance
{
	/// <summary>
	/// 学生；
	/// </summary>
	public class Student : User                                                 //定义类；该类将作为派生类，继承指定的基类；
	{
        /// <summary>
        /// 学籍；
        /// </summary>
        public string Status { get; set; }                                      //派生类可以定义自己的成员；
		/// <summary>
		/// 注册；
		/// </summary>
		public void Register()
		{
			this.Status = "在读";
		}                                                
    }
}
