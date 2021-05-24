using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.Basics
{
    /// <summary>
    /// 公有类：学生；
    /// </summary>
    public class Student
    {
        /// <summary>
        /// 公有属性：学号；
        /// </summary>
        public string Number
        {
            get;
            set;
        }
        /// <summary>
        /// 公有属性：姓名
        /// </summary>
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// 公有方法：保存；
        /// </summary>
        public void Save()
        {
            Console.Write("{0}号{1}同学已保存。",this.Number,this.Name);
            Console.Read();
        }
        /// <summary>
        /// 公有方法：构造函数
        /// </summary>
        /// <param name="number">学号</param>
        /// <param name="name">姓名</param>
        public Student(string number, string name)
        {
            this.Number = number;
            this.Name = name;
        }
    }
}
