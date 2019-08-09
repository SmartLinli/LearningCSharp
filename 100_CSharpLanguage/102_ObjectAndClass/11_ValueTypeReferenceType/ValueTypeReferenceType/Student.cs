namespace SmartLin.LearningCSharp.ClassAndObject
{
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
		public Student(string number, string name)
		{
			this.Number = number;
			this.Name = name;
		}
	}
}
