
namespace SmartLin.LearningCSharp.Array
{
    /// <summary>
    /// 课程；
    /// </summary>
    public class Course
    {
        /// <summary>
        /// 课程号；
        /// </summary>
        public string Number { get; private set; }
		/// <summary>
		/// 名称；
		/// </summary>
		public string Name { get; private set; }
		/// <summary>
		/// 教材；
		/// </summary>
		public Book[] Books { get; set; }                                   //数组作为类的数据成员；
		/// <summary>
		/// 构造函数；
		/// </summary>
		/// <param name="number">课程号</param>
		/// <param name="name">名称</param>
		public Course(string number, string name)
        {
            this.Number = number;
            this.Name = name;
        }
    }
}
