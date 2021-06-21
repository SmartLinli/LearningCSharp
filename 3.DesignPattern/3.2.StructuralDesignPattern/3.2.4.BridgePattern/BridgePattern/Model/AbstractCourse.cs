namespace SmartLin.LearningCSharp.BridgePattern
{
    /// <summary>
    /// 课程；
    /// </summary>
    public abstract class AbstractCourse                                                //定义抽象角色；
    {
        /// <summary>
        /// 课程号；
        /// </summary>
        public string Number { get; private set; }
        /// <summary>
        /// 名称；
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// 课程运行实现者；
        /// </summary>
        protected ICourseOperation _OperationImplementor;                               //引用实现者；
        /// <summary>
        /// 作业；
        /// </summary>
        public abstract void Exercise();                                                //定义抽象方法；
        /// <summary>
        /// 考试；
        /// </summary>
        public abstract void Examine();                                                 //定义抽象方法；
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">课程号</param>
        /// <param name="name">名称</param>
        /// <param name="operationImplementor">运行实现者</param>
        public AbstractCourse(string number, string name, ICourseOperation operationImplementor)
        {
            this.Number = number;
            this.Name = name;
            this._OperationImplementor = operationImplementor;
        }
    }
}
