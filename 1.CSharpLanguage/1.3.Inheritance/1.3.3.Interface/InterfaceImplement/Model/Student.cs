using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
    /// <summary>
    /// 学生；
    /// </summary>
    public class Student : User, IEvaluate                              //定义类，派生于另一个类，并实现一个接口；
	{
        /// <summary>
        /// 评教；
        /// </summary>
        /// <param name="faculty">教职工</param>
        public void Evaluate(Faculty faculty)                           //实现接口中的方法；
        {
			WriteLine
				($"学生对{faculty.Name}老师的评教：\n从师德师风、精神面貌、课件板书、因材施教等方面进行评教……\n"
				+ $"评教人：{this.Name}\n");
        }
		/// <summary>
		/// 构造函数； 
		/// </summary>
		/// <param name="number">学号</param>
		/// <param name="name">姓名</param>
		public Student(string number, string name)
            : base(number, name)
        {
            ;
        }
    }
}
