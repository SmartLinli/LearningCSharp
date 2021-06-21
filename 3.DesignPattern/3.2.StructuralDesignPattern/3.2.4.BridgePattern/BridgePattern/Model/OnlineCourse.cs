using static System.Console;

namespace SmartLin.LearningCSharp.BridgePattern
{
    /// <summary>
    /// 在线课程；
    /// </summary>
    public class OnlineCourse : AbstractCourse                                              //定义扩充抽象角色；
    {
        /// <summary>
        /// 来源；
        /// </summary>
        public string Source { get; set; }
        /// <summary>
        /// 作业；
        /// </summary>
        public override void Exercise()
        {
            WriteLine($"在线课程《{this.Name}》（来源：{this.Source}）作业：");               //实现扩充抽象角色的特有运行；
            this._OperationImplementor.Exercise();                                          //调用实现者的方法，实现指定实现者的特有运行；
        }
        /// <summary>
        /// 考试；
        /// </summary>
        public override void Examine()
        {
            WriteLine($"在线课程《{this.Name}》（来源：{this.Source}）考试：");
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