﻿namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
    /// <summary>
    /// 调查问题；
    /// </summary>
    /// <typeparam name="T">回答类型</typeparam>
    public class SurveyQuestion<T>                  //定义泛型类，并定义类型参数；
    {
        /// <summary>
        /// 问题；
        /// </summary>
        public string Question { get; set; }
        /// <summary>
        /// 回答；
        /// </summary>
        public T Answer { get; set; }               //使用类型参数，避免值类型与引用类型之间转换导致的装箱与开箱；
    }
}
