namespace SmartLin.LearningCSharp.FacadePattern
{
    /// <summary>
    /// 性别；
    /// </summary>
    public class Gender
    {
        public const string FEMALE = "女";
        public const string MALE = "男";
    }
    /// <summary>
    /// 学生；
    /// </summary>
    public partial class Student
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
        /// 性别；
        /// </summary>
        public string Gender { get; set; }
        /// <summary>
        /// 构造函数；
        /// </summary>
        public Student()
        {
            ;
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="gender">性别</param>
        public Student(string number, string name, string gender)
        {
            this.Number = number;
            this.Name = name;
            this.Gender = gender;
        }
    }
}
