
namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
	/// <summary>
	/// 性别；
	/// </summary>
	public class Gender
	{
		public static readonly string MALE = "男";
		public static readonly string FEMALE = "女";
	}
	/// <summary>
	/// 学生；
	/// </summary>
	public class Student                                                    
    {
        /// <summary>
        /// 学号；
        /// </summary>
        public string Number                                                
        {
            get;
            private set;
        }
        /// <summary>
        /// 姓名；
        /// </summary>
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// 性别；
        /// </summary>
        public string Gender
        {
            get;                                                            
            set;
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
