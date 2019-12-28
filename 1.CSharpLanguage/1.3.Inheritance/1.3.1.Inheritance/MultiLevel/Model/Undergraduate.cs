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
            : base(number, name, gender)                                                    
        {
            ;
        }
    }
}
