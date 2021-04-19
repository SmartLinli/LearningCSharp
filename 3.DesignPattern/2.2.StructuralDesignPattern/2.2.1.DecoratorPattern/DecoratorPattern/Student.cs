using System;
using System.Collections.Generic;

namespace SmartLin.LearningCSharp.DecoratorPattern
{
    /// <summary>
    /// 学生；
    /// </summary>
    public class Student                                                    //被装饰者；
    {
        /// <summary>
        /// 学号；
        /// </summary>
        public string Number
        {
            get;
            private set;
        }
        /// <summary>
        /// 姓名；
        /// </summary>
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// 介绍；
        /// </summary>
        public virtual void Intro()
        {
            Console.WriteLine("我叫{0}。", this.Name);
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        public Student()
        {
            ;
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="gender">性别</param>
        public Student(string number, string name)
        {
            this.Number = number;
            this.Name = name;
        }
    }
}
