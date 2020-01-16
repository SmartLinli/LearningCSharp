using System;

namespace SmartLin.LearningCSharp.ArrayClass
{
    /// <summary>
    /// 学生；
    /// </summary>
    public class Student : IComparable                                      //该类实现IComparable接口，用于排序；
    {
        /// <summary>
        /// 学号；
        /// </summary>
        public string Number { get; private set; }
        /// <summary>
        /// 姓名；
        /// </summary>
        public string Name { get; private set; }
		/// <summary>
		/// 比较；
		/// </summary>
		/// <param name="obj">对象</param>
		/// <returns>大小</returns>
		public int CompareTo(object obj)                                    //实现IComparable接口的CompareTo方法，用于排序；
        {
            Student otherStudent = obj as Student;                          //使用as实现显式类型转换；
            int result = this.Number.CompareTo(otherStudent.Number);        //字符串类型已实现IComparable接口，可进行比较；
            if (result == 0)
            {
                result = this.Name.CompareTo(otherStudent.Name);
            }
            return result;
        }
        /// <summary>
        /// 构造函数；
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