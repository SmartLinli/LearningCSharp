namespace SmartLin.LearningCSharp.ClassAndObject
{
	public class Class
	{
		public int Year { get; set; }
		public Major Major { get; set; }
		public string Name
		=>	$"{this.Year}级{this.Major.Name}";                                
		public string ShortName
		=>	this.Year.ToString().Substring(2, 2) + this.Major.ShortName;    
	}
}
