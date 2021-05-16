using System.Collections.Generic;
using static System.Console;

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
        public string Number { get; private set; }
        /// <summary>
        /// 名称历史记录；
        /// </summary>
        private Stack<string> _NameHistory;                                     //定义泛型栈；
        private string _Name;
        /// <summary>
        /// 名称；
        /// </summary>
        public string Name
        {
            get => this._Name;
            set
            {
                this._NameHistory.Push(this._Name);                             //向栈顶推送一个元素；
                this._Name = value;
                WriteLine($"课程名称更改为：《{this._Name}》");
            }
        }
        /// <summary>
        /// 还原名称；
        /// </summary>
        public void RestoreName()
        {
            Write("课程名称");
            if (this._NameHistory.Count > 0)
            {
                this._Name = this._NameHistory.Pop();                           //从栈顶弹出一个元素；
                Write("还原");
            }
            WriteLine($"为：《{this._Name}》");
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">课程号</param>
        /// <param name="name">名称</param>
        /// <param name="credit">学分</param>
        public Course(string number, string name)
        {
            this.Number = number;
            this._Name = name;
            this._NameHistory = new Stack<string>();
        }
    }
}
