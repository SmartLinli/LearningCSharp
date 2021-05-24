using System;
using System.Collections.Generic;

namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
    /// <summary>
    /// 课程；
    /// </summary>
    public class Course
    {
        /// <summary>
        /// 课程号；
        /// </summary>
        public string Number
        {
            get;
            private set;
        }
        private string _Name;
        /// <summary>
        /// 名称历史记录；
        /// </summary>
        private Stack<string> _NameHistory;                                     //定义泛型栈；
        /// <summary>
        /// 名称；
        /// </summary>
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._NameHistory.Push(this._Name);                             //向栈顶推送一个元素；
                this._Name = value;
                Console.WriteLine("课程名称更改为：《{0}》", this._Name);
            }
        }
        /// <summary>
        /// 还原名称；
        /// </summary>
        public void RestoreName()
        {
            Console.Write("课程名称");
            if (this._NameHistory.Count > 0)
            {
                this._Name = this._NameHistory.Pop();                           //从栈顶弹出一个元素；
                Console.Write("还原为");
            }
            Console.WriteLine("：《{0}》", this._Name);
        }
        /// <summary>
        /// 学分；
        /// </summary>
        public float Credit
        {
            get;
            set;
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">课程号</param>
        /// <param name="name">名称</param>
        /// <param name="credit">学分</param>
        public Course(string number, string name, float credit)
        {
            this.Number = number;
            this._Name = name;
            this.Credit = credit;
            this._NameHistory = new Stack<string>();
        }
    }
}
