using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
	class Program
    {
        static void Main()
        {
			Student boy = new Student("3230707000", "张三", Gender.MALE)            
			{
				Nationality = Nationality.SHE                                              //调用类的静态字段；
			};
            boy.ShowInfo();
            Read();
        }
    }
}
