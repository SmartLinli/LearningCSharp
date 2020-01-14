namespace SmartLin.LearningCSharp.ClassAndObject
{
	public class Gender
	{
		public static readonly string MALE = "男";
		public static readonly string FEMALE = "女";
	}
	public partial class Student                                                    //定义部分类；                                                  
    {
		public string Number { get; private set; }
		public string Name { get; private set; }
		public string Gender { get; private set; }
		public Student(string number, string name, string gender)                       
        {
            this.Number = number;
            this.Name = name;
            this.Gender = gender;
        }
    }
}
