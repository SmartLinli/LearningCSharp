namespace SmartLin.LearningCSharp.Inheritance
{
    /// <summary>
    /// 本科生；
    /// </summary>
    public class Undergraduate : Student
    {
        /// <summary>
        /// 班级
        /// </summary>
        public string Class { get; set; }
        /// <summary>
        /// 本科生导师；
        /// </summary>
        public Faculty Instructor { get; set; }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="gender">性别</param>
        public Undergraduate(string number, string name, string gender)
            : base(number, name, gender)                                                    //调用基类的构造函数；
        {
            ;
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="gender">性别</param>
        /// <param name="currentClass">班级</param>
        public Undergraduate(string number, string name, string gender, string currentClass)
            : this(number, name, gender)                                                    //调用本类的构造函数；
        {
            this.Class = currentClass;
        }
    }
}
