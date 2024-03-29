﻿
namespace SmartLin.LearningCSharp.Linq
{
    /// <summary>
    /// 专业；
    /// </summary>
    public class Major
    {
        /// <summary>
        /// 名称；
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// 简称；
        /// </summary>
        public string ShortName { get; private set; }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="shortName">简称</param>
        public Major(string name, string shortName)
        {
            this.Name = name;
            this.ShortName = shortName;
        }
    }
}