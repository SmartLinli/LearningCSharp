
namespace SmartLin.LearningCSharp.DecoratorPattern
{
    /// <summary>
    /// 学生装饰者；
    /// </summary>
    public abstract class StudentDecorator : Student                            //抽象装饰者定义为抽象类，并继承被装饰者；
    {
        /// <summary>
        /// 学生；
        /// </summary>
        protected Student _Student;                                             //抽象装饰者包含被装饰者；
        /// <summary>
        /// 介绍；
        /// </summary>
        public override void Intro()                                            //重写基类（即被装饰者）的方法；
        {
            this._Student.Intro();                                              //调用装饰者所包含的被装饰者的方法；
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="student">学生</param>
        public StudentDecorator(Student student)
        {
            this._Student = student;                                            //注入被装饰者；
        }        
    }
}
