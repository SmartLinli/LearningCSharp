namespace SmartLin.LearningCSharp.Inheritance
{

	/// <summary>
	/// 用户；
	/// </summary>
	public abstract class User                                                      
    {
        /// <summary>
        /// 编号；
        /// </summary>
        public string Number { get; private set; }                                                       
        /// <summary>
        /// 姓名；
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// 构造函数 
        /// </summary>
        /// <param name="number">编号</param>
        /// <param name="name">姓名</param>
        public User(string number, string name)                      
        {
            this.Number = number;
            this.Name = name;
        }
    }
}
