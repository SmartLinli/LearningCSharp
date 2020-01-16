
namespace SmartLin.LearningCSharp.Reflection
{
    /// <summary>
    /// 课程；
    /// </summary>
    public class Course
    {
        /// <summary>
        /// 课程号；
        /// </summary>
        [StringValidation(7, Description = "课程号")]                       //应用特性；向特性的构造函数所需参数直接传递参数值，并为特性的其它属性赋值；
        public string Number
        {
            get;
            private set;
        }
        /// <summary>
        /// 名称；
        /// </summary>
        [StringValidation(10, Description = "课程名称")]
        public string Name
        {
            get;
            private set;
        }
        /// <summary>
        /// 学分；
        /// </summary>
        [FloatValidation(1f, 10f, Description = "学分")]
        public float Credit
        {
            get;
            set;
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">课程号</param>
        /// <param name="name">名称</param>
        /// <param name="credit">；</param>
        public Course(string number, string name, float credit)
        {
            this.Number = number;
            this.Name = name;
            this.Credit = credit;
        }
    }
}
