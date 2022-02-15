﻿using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
	/// <summary>
	/// 交换生；
	/// </summary>
	public sealed class ExchangeStudent : Undergraduate                                     //定义密封类；密封类不能被继承；
	{
		/// <summary>
		/// 来源学校；
		/// </summary>
		public string SourceSchool { get; private set; }
		/// <summary>
		/// 注册；
		/// </summary>
		public override void Register()
		{
			this.Status = "交换生";
			WriteLine($"交换生{this.Name}当前学籍为“{this.Status}”");
		}
        /// <summary>
        /// 介绍；
        /// </summary>
        public override void Intro()                                                        
        {
            base.Intro();
			var exchangeStudentIntroduction =
				this.SourceSchool == null ? "我还是交换生。" : $"我还是来自{this.SourceSchool}的交换生。";
			Write(exchangeStudentIntroduction);
		}
		/// <summary>
		/// 构造函数；
		/// </summary>
		/// <param name="number">学号</param>
		/// <param name="name">姓名</param>
		/// <param name="gender">性别</param>
		/// <param name="currentClass">班级</param>
		/// <param name="sourceSchool">学校</param>
		public ExchangeStudent(string number, string name, string gender, string currentClass, string sourceSchool)
			: base(number, name, gender, currentClass)
		{
			this.SourceSchool = sourceSchool;
		}
	}
}
