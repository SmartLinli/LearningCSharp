using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
	/// <summary>
	/// 学生；
	/// </summary>
	public class Student : User                                                 
    {
		/// <summary>
		/// 修改电话号码；
		/// </summary>
		/// <param name="newPhoneNumber">新电话号码</param>
		public void ModifyPhoneNumber(string newPhoneNumber)
		{
			WriteLine("请输入短信验证码……");
			this.PhoneNumber = newPhoneNumber;                                  //基类的受保护成员只能被派生类实例访问，从而将相关操作封装在派生类中；
		}
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
		public Student(string number, string name, string gender)
			: base(number, name, gender)                                        
		{
			;
		}
	}
}
