using System;

namespace SmartLin.LearningCSharp.DecoratorPattern
{
    /// <summary>
    /// 学生干部；
    /// </summary>
    public class StudentCadre : StudentDecorator                             //具体装饰者继承抽象装饰者；
    {
        /// <summary>
        /// 职务；
        /// </summary>
        public string Duty
        {
            get;
            set;
        }
        /// <summary>
        /// 介绍；
        /// </summary>
        public override void Intro()                                        //重写基类（即抽象装饰者）的方法；
        {
            base.Intro();                                                   //调用基类（抽象装饰者）的方法，即装饰者所包含的被装饰者的方法；
            Console.WriteLine("目前我担任{0}。", this.Duty);        
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="student">学生</param>
        public StudentCadre(Student student)
            : base(student)
        {
            ;                                                               //调用基类（抽象装饰者）构造函数，注入被装饰者；
        }
    }
}
