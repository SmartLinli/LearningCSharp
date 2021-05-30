﻿using System;

namespace SmartLin.LearningCSharp.FormAndControl
{
    /// <summary>
    /// 课程；
    /// </summary>
    public class Course
    {
        /// <summary>
        /// 课程号；
        /// </summary>
        public string Number { get; set; }
        /// <summary>
        /// 名称；
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 学分；
        /// </summary>
        public float Credit { get; set; }
        /// <summary>
        /// 是否启用；
        /// </summary>
        public bool IsAvailable { get; set; }
        /// <summary>
        /// 是否包含实验教学；
        /// </summary>
        public bool HasExperiment { get; set; }
        /// <summary>
        /// 是否包含慕课教学；
        /// </summary>
        public bool HasMooc { get; set; }
        /// <summary>
        /// 描述；
        /// </summary>
        public string Description =>
            $"课程编号{this.Number}，名称《{this.Name}》，学分{this.Credit}分。{Environment.NewLine}" + 
            $"课程目前{(this.IsAvailable ? "已" : "未")}启用。" +
            $"{(this.HasExperiment ? "" : "不")}包含实验教学；" +
            $"{(this.HasMooc ? "" : "不")}包含慕课教学。";
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">课程号</param>
        /// <param name="name">名称</param>
        /// <param name="credit">；</param>
        public Course(string number, string name, float credit)
        {
            this.Number = number;
            this.Name = name;
            this.Credit = credit;
        }
    }
}
