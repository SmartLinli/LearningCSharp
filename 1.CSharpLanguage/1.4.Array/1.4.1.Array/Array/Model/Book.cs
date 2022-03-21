
namespace SmartLin.LearningCSharp.Array
{
    /// <summary>
    /// 教材；
    /// </summary>
    public class Book
    {
        /// <summary>
        /// 国际标准书号；
        /// </summary>
        public string Isbn { get; private set; }
        /// <summary>
        /// 书名；
        /// </summary>
        public string Name { get; private set; }
		/// <summary>
		/// 构造函数；
		/// </summary>
		/// <param name="isbn">国际标准书号</param>
		/// <param name="name">书名</param>
		public Book(string isbn, string name)
        {
            this.Isbn = isbn;
            this.Name = name;
        }
    }
}
