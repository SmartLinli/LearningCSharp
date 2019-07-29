using static System.Console;

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
        public Department Department
        {
            get;
            private set;
        }
        /// <summary>
        /// 专长；
        /// </summary>
        public string Speciality
        {
            get;
            set;
        }
		/// <summary>
		/// 介绍；
		/// </summary>
		public override void Intro()                                                        //重写基类中的虚方法；
		{
			Write($"我是{this.Name.Substring(0, 1)}老师");
			if (this.Department != null)
			{
				Write($"，来自{this.Department.Name}");
			}
			else
			{
				Write("，今天刚入职");
			}
			Write($"，专长是{this.Speciality}。");
		}
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">工号</param>
        /// <param name="name">姓名</param>
        /// <param name="gender">性别</param>
        public Faculty(string number, string name, string gender)
            : base(number, name, gender)                                                    //调用基类的构造函数；
        {
            ;
        }
        /// <summary>
        ///  构造函数；
        /// </summary>
        /// <param name="number">工号</param>
        /// <param name="name">姓名</param>
        /// <param name="gender">性别</param>
        /// <param name="department">部门</param>
        public Faculty(string number, string name, string gender, Department department)
            : this(number, name, gender)                                                    //调用本类的构造函数；
        {
            this.Department = department;
        }                                                 
    }
}
