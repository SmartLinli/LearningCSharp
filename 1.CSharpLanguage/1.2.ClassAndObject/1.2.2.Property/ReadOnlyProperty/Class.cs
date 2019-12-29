namespace SmartLin.LearningCSharp.ClassAndObject
{
	/// <summary>
	/// 班级；
	/// </summary>
    public class Class
    {
		/// <summary>
		/// 年级；
		/// </summary>
        public int Year { get; set; }
		/// <summary>
		/// 专业；
		/// </summary>
        public Major Major { get; set; }
		/// <summary>
		/// 名称；
		/// </summary>
		public string Name
		=>	$"{this.Year}级{this.Major.Name}";								//通过表达式体，实现只读属性；
		/// <summary>
		/// 简称；
		/// </summary>
		public string ShortName
		=>	this.Year.ToString().Substring(2, 2) + this.Major.ShortName;	//通过表达式体，实现只读属性；
	}
}
