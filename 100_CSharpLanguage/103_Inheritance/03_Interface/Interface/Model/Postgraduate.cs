using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
    /// <summary>
    /// 研究生；
    /// </summary>
    public class Postgraduate : Student, IScientificSubject
    {
        /// <summary>
        /// 课题选题；
        /// </summary>
        public string SubjectTitle { get; set; }                                        //实现接口中的属性；
        /// <summary>
        /// 申报课题；
        /// </summary>
        public void SubmitSubject()                                                     //实现接口中的方法；
		{
			WriteLine($"研究生{this.Name}申报校管课题，选题为《{this.SubjectTitle}》。");
        }									
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="gender">性别</param>
        public Postgraduate(string number, string name, string gender)
            : base(number, name, gender)                                                    
        {
            ;
        }
    }
}
