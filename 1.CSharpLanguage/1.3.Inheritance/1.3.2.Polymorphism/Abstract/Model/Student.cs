namespace SmartLin.LearningCSharp.Inheritance
{
	/// <summary>
	/// 学生；
	/// </summary>
	public abstract class Student : User                                //定义抽象类，派生于指定（抽象）类；
    {
        /// <summary>
        /// 学籍；
        /// </summary>
        public string Status { get; protected set; }
        /// <summary>
        /// 注册；
        /// </summary>
        public abstract void Register();                                //定义抽象方法；抽象方法不能包含实现代码，且必须在（非抽象的）派生类中通过重写来实现；
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
