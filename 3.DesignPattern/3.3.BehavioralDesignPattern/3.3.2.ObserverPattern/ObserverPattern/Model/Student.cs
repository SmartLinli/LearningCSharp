using static System.Console;

namespace SmartLin.LearningCSharp.ObserverPattern
{
    /// <summary>
    /// 学生；
    /// </summary>
    public partial class Student
    {
        /// <summary>
        /// 学号；
        /// </summary>
        public string Number { get; private set; }
        /// <summary>
        /// 姓名；
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 评教事件；
        /// </summary>
        public event EvaluateEventHandler EvaluateEvent;                                //定义事件；事件即多播委托；事件必须定义在类内部；
        /// <summary>
        /// 触发评教事件；
        /// </summary>
        /// <param name="faculty">教职工</param>
        public void OnEvaluateEvent(Faculty faculty)
        {
            //if (this.EvaluateEvent != null)                                             //若事件非空；
            {
                EvaluateEventArgs e = new EvaluateEventArgs(faculty);                   //创建评教事件参数；
                this.EvaluateEvent?.Invoke(this, e);                                            //触发事件，即调用多播委托中注册的所有事件处理函数；事件必须在类内部触发；
            }
        }
        /// <summary>
        /// 评教
        /// </summary>
        /// <param name="faculty">教职工</param>
        public void Evaluate(Faculty faculty)
        {
            WriteLine($"请输入对{faculty.Name}老师的评教分数：");
            ReadLine();
            this.OnEvaluateEvent(faculty);                                              //调用能触发事件的方法；
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">学号</param>
        /// <param name="name">姓名</param>
        public Student(string number, string name)
        {
            this.Number = number;
            this.Name = name;
        }
    }
}
