using static System.Console;

namespace SmartLin.LearningCSharp.ProxyPattern
{
    /// <summary>
    /// 课程；
    /// </summary>
    public class Course : ICourse
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
        /// 更新；
        /// </summary>
        public void Update()
        {
            Write("请输入新课程号：");
            this.Number = ReadLine();
            Write("请输入新名称：");
            this.Name = ReadLine();
            Write("请输入新学分：");
            this.Credit = float.Parse(ReadLine());
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
