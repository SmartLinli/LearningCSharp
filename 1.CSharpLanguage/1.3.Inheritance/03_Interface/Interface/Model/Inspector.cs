using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
    /// <summary>
    /// 督导；
    /// </summary>
    public class Inspector : Faculty, IDeepEvaluate
    {
        /// <summary>
        /// 分析；
        /// </summary>
        /// <param name="faculty">教职工</param>
        public void Analyse(Faculty faculty)
        {
			WriteLine($"督导对{faculty.Name}老师教学效果的分析：……\n督导：{this.Name}\n");
        }
        /// <summary>
        /// 建议；
        /// </summary>
        /// <param name="faculty">教职工</param>
        public void Propose(Faculty faculty)
        {
            WriteLine($"督导对{faculty.Name}老师今后教学工作的建议：……\n督导：{this.Name}\n");
        }
        /// <summary>
        /// 评教；
        /// </summary>
        /// <param name="faculty">教职工</param>
        public override void Evaluate(Faculty faculty)
        {
			WriteLine
				($"督导对{faculty.Name}老师的评教：\n从大纲、进度、教案、讲稿、教学设计、课堂纪律等方面进行评教……\n"
				+ $"督导：{this.Name}\n");
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">工号</param>
        /// <param name="name">姓名</param>
        /// <param name="gender">性别</param>
        public Inspector(string number, string name, string gender)
            : base(number, name, gender)
        {
            ;
        }
    }
}
