using System;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    public class Class
    {
        public int Year { get; private set; }
		public Major Major { get; private set; }
		public string Name
		=>	$"{this.Year}级{this.Major.Name}";                                
		public string ShortName
		=>	this.Year.ToString().Substring(2, 2) + this.Major.ShortName; 
		public Class(Major major, int year)                                     //定义构造函数（重载1）；
		{
            this.Year = year;
            this.Major = major;
        }
        public Class(Major major)                                               //定义构造函数（重载2）；
			: this(major, DateTime.Now.Year)                                    //构造函数初始化器，用于调用参数匹配的其它构造函数；
		{
            ;
        }
    }
}
