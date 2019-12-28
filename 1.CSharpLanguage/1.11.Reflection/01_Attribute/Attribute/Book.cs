
namespace SmartLin.LearningCSharp.Reflection
{
    /// <summary>
    /// 教材；
    /// </summary>
    public class Book
    {
        /// <summary>
        /// 书号；
        /// </summary>
        [StringValidation(13, Description = "书号")]
        public string Isbn
        {
            get;
            private set;
        }
        /// <summary>
        /// 书名；
        /// </summary>
        [StringValidation(20, Description = "书名")]
        public string Name
        {
            get;
            private set;
        }
        /// <summary>
        /// 价格；
        /// </summary>
        [FloatValidation(0f, 100f, Description = "价格")]
        public float Price
        {
            get;
            private set;
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="isbn">书号</param>
        /// <param name="name">书名</param>
        /// <param name="price">价格</param>
        public Book(string isbn, string name, float price)
        {
            this.Isbn = isbn;
            this.Name = name;
            this.Price = price;
        }
    }
}
