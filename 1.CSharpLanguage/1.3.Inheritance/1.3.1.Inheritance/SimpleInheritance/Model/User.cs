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
	public class User                                                               //定义类；该类将作为基类，被其它类继承；                                  
    {
        /// <summary>
        /// 编号；
        /// </summary>
        public string Number { get; set; }
		/// <summary>
		/// 姓名；
		/// </summary>
		public string Name { get; set; }
        /// <summary>
        /// 性别；
        /// </summary>
        public string Gender { get; set; }
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
    }
}
