using System;

namespace SmartLin.LearningCSharp.Inheritance
{
	/// <summary>
	/// 学生；
	/// </summary>
	public class Student : User
    {
		/// <summary>
		/// 学籍；
		/// </summary>
		public string Status { get; protected set; }					//只有派生类实例才能访问基类的受保护成员；
        /// <summary>
        /// 注册；
        /// </summary>
        public virtual void Register()                                  //若各派生类中对该方法的实现完全不同，难以复用代码，则基类的虚方法可不提供具体实现；
        {
            throw new NotImplementedException();                        //为约束各派生类必须实现该虚方法，可在虚方法中直接抛出异常；一旦某派生类由于开发人员疏忽等情况导致未重写该虚方法，将直接继承该虚方法并随即出错；
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
