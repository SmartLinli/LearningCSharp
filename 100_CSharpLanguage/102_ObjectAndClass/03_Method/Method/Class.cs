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
				return $"{this.Year}级{this.Major.Name}";
			}
		}
        public string ShortName
        {
            get
            {
				return $"{this.Year % 100}{this.Major.ShortName}";
            }
        }
    }
}
