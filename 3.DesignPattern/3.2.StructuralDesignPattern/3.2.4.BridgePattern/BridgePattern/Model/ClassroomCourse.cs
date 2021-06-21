using static System.Console;

namespace SmartLin.LearningCSharp.BridgePattern
{
    /// <summary>
    /// 面授课程；
    /// </summary>
    public class ClassroomCourse : AbstractCourse                                               //定义扩充抽象角色；                
    {
        /// <summary>
        /// 主讲人；
        /// </summary>
        public string Lecturer { get; set; }
        /// <summary>
        /// 作业；
        /// </summary>
        public override void Exercise()
        {
            WriteLine($"面授课程《{this.Name}》（主讲人：{this.Lecturer}）作业：");               //实现扩充抽象角色的特有运行；
            this._OperationImplementor.Exercise();                                              //调用实现者的方法，实现指定实现者的特有运行；
        }
        /// <summary>
        /// 考试；
        /// </summary>
        public override void Examine()
        {
            WriteLine($"面授课程《{this.Name}》（主讲人：{this.Lecturer}）考试：");
            this._OperationImplementor.Examine();
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">课程号</param>
        /// <param name="name">名称</param>
        /// <param name="operationImplementor">运行实现者</param>
        public ClassroomCourse(string number, string name, ICourseOperation operationImplementor)
            : base(number, name, operationImplementor)
        {
            ;
        }
    }
}
