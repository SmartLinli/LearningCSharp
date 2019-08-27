namespace SmartLin.LearningCSharp.Inheritance
{
	/// <summary>
	/// 学生；
	/// </summary>
	public abstract class Student : User                                //定义抽象类，派生于另一个（抽象）类；
    {
        /// <summary>
        /// 学籍；
        /// </summary>
        public string Status
        {
            get;
            protected set;                                              //只有在派生类对象中才能访问基类的受保护成员；在基类中亦无法访问受保护成员；
        }
        /// <summary>
        /// 注册；
        /// </summary>
        public abstract void Register();                                //定义抽象方法；抽象方法不能包含实现代码，且必须在（非抽象的）派生类中通过重写来实现；
                                                                        //此处未重写基类User的虚方法Intro，则隐式继承该虚方法；
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
