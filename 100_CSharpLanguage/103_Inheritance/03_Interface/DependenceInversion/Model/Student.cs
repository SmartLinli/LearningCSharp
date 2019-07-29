namespace SmartLin.LearningCSharp.Inheritance
{
	/// <summary>
	/// 学生；
	/// </summary>
	public abstract class Student : User                                //定义抽象类，派生于另一个类以及一个（或若干）接口；
    {
        /// <summary>
        /// 学籍；
        /// </summary>
        public string Status
        {
            get;
            protected set;                                              
        }
        /// <summary>
        /// 注册；
        /// </summary>
        public abstract void Register();                                
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number"></param>
        /// <param name="name"></param>
        /// <param name="gender"></param>
        public Student(string number, string name, string gender)
            : base(number, name, gender)
        {
            ;
        }
    }
}
