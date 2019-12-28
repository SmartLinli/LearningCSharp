using System;
using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
	/// <summary>
	/// 性别；
	/// </summary>
	public class Gender
	{
		public static readonly string MALE = "男";
		public static readonly string FEMALE = "女";
	}
	/// <summary>
	/// 用户；
	/// </summary>
	public class User                                                                                                 
	{
		/// <summary>
		/// 编号；
		/// </summary>
		public string Number { get; private set; }									//基类的私有成员无法被派生类访问；
		/// <summary>
		/// 姓名；
		/// </summary>
		public string Name { get; private set; }
		/// <summary>
		/// 性别；
		/// </summary>
		public string Gender { get; private set; }
		/// <summary>
		/// 生日；
		/// </summary>
		public DateTime BirthDate { get; set; }
		/// <summary>
		/// 电话；
		/// </summary>
		public string PhoneNumber { get; set; }                                
		/// <summary>
		/// 介绍；
		/// </summary>
		public void Intro()
		=>	WriteLine($"我叫{this.Name}，来自福建中医药大学。\n");
		/// <summary>
		/// 发送短信；
		/// </summary>
		/// <param name="message">消息</param>
		public void SendSms(string message)
		{
			if (this.PhoneNumber != null)
			{
				WriteLine($"发送短信至用户手机{this.PhoneNumber}：{message}\n");
			}
			else
			{
				WriteLine("用户尚未登记手机号。\n");
			}
		}
		/// <summary>
		/// 构造函数；
		/// </summary>
		/// <param name="number">编号</param>
		/// <param name="name">姓名</param>
		/// <param name="gender">性别</param>
		public User(string number, string name, string gender)
		{
			this.Number = number;                                                   //基类的私有成员无法被派生类访问，从而将相关操作封装在基类中；				
			this.Name = name;														//若派生类构造函数需要初始化基类的私有成员，只能通过调用基类的构造函数来实现；
			this.Gender = gender;
		}
	}
}
