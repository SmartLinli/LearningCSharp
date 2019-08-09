using System;

namespace SmartLin.LearningCSharp.Inheritance
{
    /// <summary>
    /// 研究生；
    /// </summary>
    public class Postgraduate : Student, IScientificSubject
    {
        /// <summary>
        /// 导师；
        /// </summary>
        public Faculty Supervisor
        {
            get;
            private set;
        }
        /// <summary>
        /// 方向；
        /// </summary>
        public string Direction
        {
            get;
            private set;
        }
        /// <summary>
        /// 课题选题；
        /// </summary>
        public string SubjectTitle                                                          //实现接口中的属性；
        {
            get;
            set;
        }
        /// <summary>
        /// 研究方向；
        /// </summary>
        /// <param name="direction">方向</param>
        public void ResearchDirection(string direction)
        {
            this.Direction = direction;
        }
        /// <summary>
        /// 注册；
        /// </summary>
        public sealed override void Register()                                              //重写基类中的虚方法；密封方法不能被重写；
        {
            this.Status = "已注册";                                                         //只有在派生类中才能访问基类的受保护成员；
            WriteLine
                ("研究生{0}当前学籍为“{1}”"
                , this.Name
                , this.Status);
        }
        /// <summary>
        /// 介绍；
        /// </summary>
        public override void Intro()                                                 
        {
            base.Intro();
            if (this.Supervisor != null)
            {
                Write("，是{0}老师的研究生", this.Supervisor.Name.Substring(0,1));
            }
            else
            {
                Write("，是研究生。");
            }
            Write("，研究方向是{0}。", this.Direction);
        }
        /// <summary>
        /// 申报课题；
        /// </summary>
        public void SubmitSubject()
        {
            WriteLine
                ("研究生独立申报校管课题，选题为《{0}》。"
                , this.SubjectTitle);
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="gender">性别</param>
        public Postgraduate(string number, string name, Gender gender)
            : base(number, name, gender)                                                    
        {
            ;
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="gender">性别</param>
        /// <param name="supervisor">导师</param>
        public Postgraduate(string number, string name, Gender gender, Faculty supervisor)
            : this(number, name, gender)                                                    
        {
            this.Supervisor = supervisor;
        }
    }
}
