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
        public string Status
        {
            get;
            protected set;                                              //只有在派生类中才能访问基类的受保护成员；在基类中亦无法访问受保护成员；
        }
        /// <summary>
        /// 注册；
        /// </summary>
        public virtual void Register()
        {
            ;
        }                                                   
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="gender">性别</param>
        public Student(string number, string name, Gender gender)
            : base(number, name, gender)
        {
            ;
        }
    }
}
