namespace SmartLin.LearningCSharp.CommandPattern
{
    /// <summary>
    /// 学工处命令；
    /// </summary>
    public class StudentAffairCommand : ICommand                                //定义具体命令，用于执行学工处命令；
    {
        /// <summary>
        /// 学工处；
        /// </summary>
        private StudentAffair _StudentAffair;                                   //引用学工处对象；
        /// <summary>
        /// 执行；
        /// </summary>
        public void Execute()
        {
            this._StudentAffair.OverallScore();                                 //执行实际命令；
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="studentAffair">学工处</param>
        public StudentAffairCommand(StudentAffair studentAffair)
        {
            this._StudentAffair = studentAffair;
        }
    }
}
