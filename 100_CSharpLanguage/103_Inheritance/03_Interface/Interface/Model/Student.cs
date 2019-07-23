using System;

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
            Console.WriteLine
                ("学生对{0}老师的评教：\n从师德师风、精神面貌、课件板书、因材施教、教学效果等方面进行评教……\n评教人：{1}\n"
                , faculty.Name
                , this.Name);
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number"></param>
        /// <param name="name"></param>
        /// <param name="gender"></param>
        public Student(string number, string name, Gender gender)
            : base(number, name, gender)
        {
            ;
        }
    }
}
