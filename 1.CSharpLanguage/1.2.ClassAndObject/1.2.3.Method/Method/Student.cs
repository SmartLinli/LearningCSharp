using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
	public class Student
	{
		public string Name { get; set; }
		public string Class { get; set; }                            
		private bool HasClass                                               
		=>	this.Class != null;
        public void Intro()                                                 //定义公有方法；
        =>	WriteLine														//通过表达式体，定义只有单语句的方法；
				($"我叫{this.Name}"
				+ $"{(this.HasClass ? "，来自" + this.Class : "")}。");
    }
}
