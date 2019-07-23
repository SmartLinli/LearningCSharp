using System;

namespace SmartLin.LearningCSharp.Inheritance
{
    /// <summary>
    /// 学生；
    /// </summary>
    public class Student : User                                                 //定义类，派生于另一个类；
    {
        /// <summary>
        /// 学籍；
        /// </summary>
        public string Status
        {
            get;
            private set;
        }
        /// <summary>
        /// 注册；
        /// </summary>
        public void Register()
        {
            this.Status = "在读";
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="gender">性别</param>
        public Student(string number, string name, Gender gender)               //该构造函数不可缺少，因为本类的派生类只能通过本类的构造函数，间接调用本类的基类的构造函数；
            : base(number, name, gender)                                        //调用基类的构造函数；
        {
            ;
        }                                                 
    }
}
