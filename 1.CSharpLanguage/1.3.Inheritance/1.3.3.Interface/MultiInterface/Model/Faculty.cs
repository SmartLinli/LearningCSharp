using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
    /// <summary>
    /// 教职工；
    /// </summary>
    public class Faculty : User, IEvaluate, IScientificSubject                              //定义类，派生于另一个类以及一个（或若干）接口；
    {
        /// <summary>
        /// 课题选题；
        /// </summary>
        public string SubjectTitle { get; set; }                                            //实现接口中的属性；
        /// <summary>
        /// 申报课题；
        /// </summary>
        public void SubmitSubject()                                                         //实现接口中的方法；
		{
			WriteLine($"教师{this.Name}申报厅级或以上级别课题，选题为《{this.SubjectTitle}》。");
        }
		/// <summary>
		/// 评教；
		/// </summary>
		/// <param name="faculty">被评教的教职工</param>
		public virtual void Evaluate(Faculty faculty)                                       //实现接口中的方法；
        {
            WriteLine
                ($"同行对{faculty.Name}老师的评教：\n" +
                 $"从大纲、进度、教案、讲稿、教学设计、课堂纪律等方面进行评教……\n" +
                 $"评教人：{this.Name}\n");
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">工号</param>
        /// <param name="name">姓名</param>
        public Faculty(string number, string name)
            : base(number, name)
        {
            ;
        }
    }
}
