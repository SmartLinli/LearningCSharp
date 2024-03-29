﻿namespace SmartLin.LearningCSharp.ObserverPattern
{
    /// <summary>
    /// 教职工；
    /// </summary>
    public class Faculty
    {
        /// <summary>
        /// 工号；
        /// </summary>
        public string Number { get; private set; }
        /// <summary>
        /// 姓名；
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 电话；
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">工号</param>
        /// <param name="name">姓名</param>
        public Faculty(string number, string name)
        {
            this.Number = number;
            this.Name = name;
        }
    }
}
