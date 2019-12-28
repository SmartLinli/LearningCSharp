﻿using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
    /// <summary>
    /// 交换生；
    /// </summary>
    public sealed class ExchangeStudent : Undergraduate                                     //定义密封类；密封类不能被继承；
    {
        /// <summary>
        /// 学校；
        /// </summary>
        public string School { get; set; }
        /// <summary>
        /// 注册；
        /// </summary>
        public override void Register()                                                     //重写基类方法；
        {
            this.Status = "交换生";                                                         //只有派生类实例能访问基类的受保护成员；
            WriteLine
                ($"交换生{this.Name}当前学籍为“{this.Status}”");
        }
        /// <summary>
        /// 介绍；
        /// </summary>
        public override void Intro()                                                        //重写基类方法；
        {
            base.Intro();                                                                   //调用基类方法；
			Write(this.School == null ?
					"今天刚到福建中医药大学。"
					: $"同时也是来自{this.School}的交换生。");
		}
		/// <summary>
		/// 转专业
		/// </summary>
		/// <param name="newClass">新班级</param>
		public new void TransferToMajor(string newClass)									//定义新方法，隐藏基类方法；
        {
            WriteLine("交换生必须在指定专业就读，不能转专业。\n");
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="gender">性别</param>
        private ExchangeStudent(string number, string name, string gender)
            : base(number, name, gender)
        {
            ;
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="gender">性别</param>
        /// <param name="currentClass">班级</param>
        /// <param name="school">学校</param>
        public ExchangeStudent(string number, string name, string gender, string currentClass, string school)
            : base(number, name, gender, currentClass)
        {
            this.School = school;
        }
    }
}