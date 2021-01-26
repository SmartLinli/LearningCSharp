using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
    class Program
    {
        static void Main()
        {
            Student boy = new Student("3210707000", "张三", Gender.MALE)              //派生类的构造函数实际调用基类的构造函数；
			{
                PhoneNumber = "18900001111"
			};
			Student girl = new Student("2190757001", "李四", Gender.FEMALE, "15955559999");
			boy.Intro();                                                             
			boy.SendSms("请及时评教。");
			Read();
		}
	}
}