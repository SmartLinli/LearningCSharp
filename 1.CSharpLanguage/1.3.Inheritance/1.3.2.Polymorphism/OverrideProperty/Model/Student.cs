namespace SmartLin.LearningCSharp.Inheritance
{
	/// <summary>
	/// 学生；
	/// </summary>
	public class Student : User
    {
		/// <summary>
		/// 电话号码；
		/// </summary>
		public override string PhoneNumber                              //重写基类中的虚属性；
		{
			get
			{
				if (base.PhoneNumber != null)							//访问基类的属性；
				{
					return base.PhoneNumber.Substring(0, 3) + "****" + base.PhoneNumber.Substring(7, 4);
				}
				else
				{
					return null;
				}
			}
			set
			{
				base.PhoneNumber = value;
			}
		}
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
