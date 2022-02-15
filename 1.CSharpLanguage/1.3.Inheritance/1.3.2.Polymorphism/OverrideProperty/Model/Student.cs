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
				if (base.PhoneNumber == null)							//访问基类的属性；
				{
					return null;
				}
				var maskedPhoneNumber = base.PhoneNumber.Substring(0, 3) + "****" + base.PhoneNumber.Substring(7, 4);
				return maskedPhoneNumber;
			}
			set
			{
				base.PhoneNumber = value;                               //访问基类的属性；
            }
		}
		/// <summary>
		/// 学籍；
		/// </summary>
		public string Status { get; protected set; }					
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
