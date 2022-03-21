
namespace SmartLin.LearningCSharp.Inheritance
{
    /// <summary>
    /// 学生；
    /// </summary>
    public class Student                                                    //所有类均派生于System.object类；                                                
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
        /// 转为字符串；
        /// </summary>
        /// <returns>字符串</returns>
        public override string ToString()                                   //重写System.object类的虚方法ToString；
        =>  this.Name;
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
