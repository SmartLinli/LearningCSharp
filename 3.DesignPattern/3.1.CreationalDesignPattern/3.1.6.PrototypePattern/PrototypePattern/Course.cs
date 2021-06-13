using static System.Console;

namespace SmartLin.LearningCSharp.PrototypePattern
{
    /// <summary>
    /// 课程；
    /// </summary>
    public class Course
    {
        /// <summary>
        /// 课程号；
        /// </summary>
        public string Number { get; set; }
        /// <summary>
        /// 名称；
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 学分；
        /// </summary>
        public float Credit { get; set; }
        /// <summary>
        /// 复制；
        /// </summary>
        /// <returns></returns>
        public Course Clone()
        {
            return (Course)this.MemberwiseClone();                                  //调用object基类的MemberwiseClone方法，实现浅复制；浅复制无法复制引用类型的成员；
        }
        /// <summary>
        /// 显示；
        /// </summary>
        public void Display()
        {
            WriteLine($"课程号：{this.Number,-10}名称：{this.Name}\t学分：{this.Credit}");
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">课程号</param>
        /// <param name="name">名称</param>
        /// <param name="credit">学分</param>
        public Course(string number, string name, float credit)
        {
            this.Number = number;
            this.Name = name;
            this.Credit = credit;
        }
    }
}
