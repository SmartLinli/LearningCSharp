namespace SmartLin.LearningCSharp.ClassAndObject
{
	/// <summary>
	/// 专业；
	/// </summary>
    public class Major
    {
        public string Name { get; private set; }
        public string ShortName { get; private set; }
		public Major(string name, string shortName)
        {
            this.Name = name;
            this.ShortName = shortName;
        }
    }
}
