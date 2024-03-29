﻿using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
	/// <summary>
	/// 研究生；
	/// </summary>
	public class Postgraduate : Student
	{
		/// <summary>
		/// 导师；
		/// </summary>
		public Faculty Supervisor { get; private set; }
		/// <summary>
		/// 方向；
		/// </summary>
		public string Direction { get; private set; }
		/// <summary>
		/// 指定研究方向；
		/// </summary>
		/// <param name="direction">方向</param>
		public void AssignDirection(string direction)
		{
			this.Direction = direction;
		}
		/// <summary>
		/// 注册；
		/// </summary>
		public sealed override void Register()                                              //密封方法不能被重写；
		{
			this.Status = "已注册";
			WriteLine($"研究生{this.Name}当前学籍为“{this.Status}”");
		}
        /// <summary>
        /// 介绍；
        /// </summary>
        public override void Intro()
        {
            base.Intro();
			var postgraduateIntroduction =
				this.Supervisor == null ? "，是研究生。" : $"，是{ this.Supervisor.Name}老师的研究生" +
				$"，研究方向是{this.Direction}。";
			Write(postgraduateIntroduction);
		}
		/// <summary>
		/// 构造函数；
		/// </summary>
		/// <param name="number">学号</param>
		/// <param name="name">姓名</param>
		/// <param name="gender">性别</param>
		/// <param name="supervisor">导师</param>
		public Postgraduate(string number, string name, string gender, Faculty supervisor)
			: base(number, name, gender)
		{
			this.Supervisor = supervisor;
		}
	}
}
