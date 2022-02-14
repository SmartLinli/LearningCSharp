namespace SmartLin.LearningCSharp.ClassAndObject
{
    public class Student
    {
		public string Number { get; private set; }
		public string Name { get; private set; }
		public string PhoneNumber { get; set; }
		public Student(string number, string name)                       
		{
			this.Number = number;
			this.Name = name;
		}
    }
}
