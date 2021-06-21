using System.Collections.Generic;
using static System.Console;

namespace SmartLin.LearningCSharp.CompositePattern
{
    /// <summary>
    /// 学生干部；
    /// </summary>
    public class StudentCadre : Student                                                 //定义组合，用于保存子节点（包括叶节点）；
    {
        /// <summary>
        /// 部门；
        /// </summary>
        public string Department { get; set; }
        /// <summary>
        /// 职责；
        /// </summary>
        public string Duty { get; set; }
        /// <summary>
        /// 下属；
        /// </summary>
        private List<Student> _Subordinate = new List<Student>();                       //保存子节点（包括叶节点）；
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="subordinate">下属</param>
        public void Add(Student subordinate)
        {
            this._Subordinate.Add(subordinate);
        }
        /// <summary>
        /// 介绍
        /// </summary>
        /// <param name="level">层级</param>
        public override void Intro(int level)
        {
            WriteLine
                (new string('-', level - 1)
                + $"{this.Department}{this.Duty}{this.Name}");
            foreach (var subordinate in this._Subordinate)                              //遍历子节点（包括叶节点）；
            {
                subordinate.Intro(level + 1);
            }
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">学号</param>
        /// <param name="name">姓名</param>
        public StudentCadre(string number, string name)
            : base(number, name)
        {
            ;
        }
    }
}
