
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
				return this.Year.ToString().Substring(2, 2) + this.Major.ShortName; //string类型重载了+运算符，实现字符串拼接；
			}
        }
    }
}
