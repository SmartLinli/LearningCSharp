namespace SmartLin.LearningCSharp.ClassAndObject
{
	public class Class
    {
        public int Year
        {
            get;
            set;
        }
        public Major Major
        {
            get;
            set;
        }
        public string Name
        {
            get
            {
                return this.Year.ToString() + "级" + this.Major.Name;
            }
        }
        public string ShortName
        {
            get
            {
                return this.Year.ToString().Substring(2, 2) + this.Major.ShortName;
            }
        }
    }
}
