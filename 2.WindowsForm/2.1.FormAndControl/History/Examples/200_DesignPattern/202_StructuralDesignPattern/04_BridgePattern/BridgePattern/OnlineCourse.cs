using System;

namespace SmartLin.LearningCSharp.BridgePattern
{
    /// <summary>
    /// 在线课程；
    /// </summary>
    public class OnlineCourse : AbstractCourse                                              //定义修正抽象角色；
    {
        /// <summary>
        /// 来源；
        /// </summary>
        public string Source
        {
            get;
            set;
        }
        /// <summary>
        /// 作业；
        /// </summary>
        public override void Exercise()
        {
            Console.WriteLine
                ("在线课程《{0}》（来源：{1}）作业：", this.Name, this.Source);             //实现修正抽象角色的特有运行；
            this._OperationImplementor.Exercise();                                          //调用实现者的方法，实现指定实现者的特有运行；
        }
        /// <summary>
        /// 考试；
        /// </summary>
        public override void Examine()
        {
            Console.WriteLine
                ("在线课程《{0}》（来源：{1}）考试：", this.Name, this.Source);
            this._OperationImplementor.Examine();
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">课程号</param>
        /// <param name="name">名称</param>
        /// <param name="operationImplementor">运行实现者</param>
        public OnlineCourse(string number, string name, ICourseOperation operationImplementor)
            : base(number, name, operationImplementor)
        {
            ;
        }
    }
}
