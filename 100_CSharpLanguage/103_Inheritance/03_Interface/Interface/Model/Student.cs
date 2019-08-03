using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
    /// <summary>
    /// 学生；
    /// </summary>
    public abstract class Student : User, IEvaluate                     //定义抽象类，派生于另一个类以及一个（或若干）接口；
    {
        /// <summary>
        /// 学籍；
        /// </summary>
        public string Status
        {
            get;
            protected set;                                              
        }
        /// <summary>
        /// 注册；
        /// </summary>
        public abstract void Register();                                
        /// <summary>
        /// 评教；
        /// </summary>
        /// <param name="faculty">教职工</param>
        public void Evaluate(Faculty faculty)                           //实现接口中的方法；
        {
			WriteLine
				($"学生对{faculty.Name}老师的评教：\n从师德师风、精神面貌、课件板书、因材施教、教学效果等方面进行评教……\n"
				+ $"评教人：{this.Name}\n");
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number"></param>
        /// <param name="name"></param>
        /// <param name="gender"></param>
        public Student(string number, string name, string gender)
            : base(number, name, gender)
        {
            ;
        }
    }
}
