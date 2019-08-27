using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
    /// <summary>
    /// 本科生；
    /// </summary>
    public class Undergraduate : Student
    {
        /// <summary>
        /// 班级
        /// </summary>
        public Class Class
        {
            get;
            private set;
        }
        /// <summary>
        /// 本科生导师；
        /// </summary>
        public Faculty Instructor
        {
            get;
            set;
        }
        /// <summary>
        /// 注册；
        /// </summary>
        public override void Register()                                                     //重写基类中的抽象方法；
        {
            this.Status = "在读";                                                            //只有在派生类中才能访问基类的受保护成员；
        }
        /// <summary>
        /// 介绍；
        /// </summary>
        public override void Intro()                                                        //重写基类中的虚方法；
        {
            base.Intro();                                                                   //调用基类的虚方法；基类Student未重写更高一层基类User的虚方法Intro，即隐式继承该虚方法，故此处最终调用基类User的虚方法Intro；
			Write(this.Class == null ?
					"，今天刚入学。"
					: $"，来自{this.Class.ShortName}。");
		}
		/// <summary>
		/// 转专业
		/// </summary>
		/// <param name="newMajor">新专业</param>
		/// <param name="year">年级</param>
		public void TransferToMajor(Major newMajor, int year)                               
        {
            if (this.Class != null)
            {
                Class newClass = new Class(newMajor,year);
                this.Class = newClass;
                WriteLine("{this.Name}已转至{newMajor.Name}专业，并分配至{newClass.ShortName}班。");
            }
            else
            {
                WriteLine("{this.Name}尚未被任何专业录取，无法转专业。");
            }
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="gender">性别</param>
        public Undergraduate(string number, string name, string gender)
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
        public Undergraduate(string number, string name, string gender, Class currentClass)
            : this(number, name, gender)                                                    
        {
            this.Class = currentClass;
        }
    }
}
