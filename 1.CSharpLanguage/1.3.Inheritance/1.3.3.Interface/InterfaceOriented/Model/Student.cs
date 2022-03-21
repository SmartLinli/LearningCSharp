using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
    /// <summary>
    /// 学生；
    /// </summary>
    public class Student : User, IEvaluate								
    {
        /// <summary>
        /// 评教；
        /// </summary>
        /// <param name="faculty">教职工</param>
        public void Evaluate(Faculty faculty)                           
        {
            WriteLine
                ($"学生对{faculty.Name}老师的评教：\n" +
                 $"从师德师风、精神面貌、课件板书、因材施教等方面进行评教……\n" +
                 $"评教人：（匿名）\n");
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
