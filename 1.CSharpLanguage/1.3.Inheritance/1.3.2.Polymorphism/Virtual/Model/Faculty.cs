namespace SmartLin.LearningCSharp.Inheritance
{
    /// <summary>
    /// 教职工；
    /// </summary>
    public class Faculty : User
	{
		/// <summary>
		/// 部门；
		/// </summary>
		public string Department { get; set; }
		/// <summary>
		/// 构造函数；
		/// </summary>
		/// <param name="number">工号</param>
		/// <param name="name">姓名</param>
		/// <param name="gender">性别</param>
		public Faculty(string number, string name, string gender)
			: base(number, name, gender)                                                    
		{
			;
		}
	}
}
