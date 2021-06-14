using static System.Console;

namespace SmartLin.LearningCSharp.DecoratorPattern
{
    /// <summary>
    /// 交换生；
    /// </summary>
    public class ExchangedStudent : StudentDecorator                            //具体装饰者继承抽象装饰者；
    {
        /// <summary>
        /// 目的学校；
        /// </summary>
        public string DestinationSchool { get; set; }
        /// <summary>
        /// 目的专业；
        /// </summary>
        public string DestinationMajor { get; set; }
        /// <summary>
        /// 介绍；
        /// </summary>
        public override void Intro()                                            //重写基类（即抽象装饰者）的方法；
        {
            base.Intro();                                                       //调用基类（抽象装饰者）的方法，即装饰者所包含的被装饰者的方法；
            WriteLine($"我即将前往{this.DestinationSchool}{this.DestinationMajor}专业，成为交换生。");
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="student"></param>
        public ExchangedStudent(Student student)
            : base(student)
        {
            ;                                                                   //调用基类（抽象装饰者）构造函数，注入被装饰者；
        }
    }
}
