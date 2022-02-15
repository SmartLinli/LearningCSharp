using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
	class Program
    {
        static void Main()
        {
            Undergraduate boy = new Undergraduate("3220707001", "张三", Gender.MALE, "22信管");
            Postgraduate girl = new Postgraduate("2190757001", "李四", Gender.FEMALE, "杨雪梅");
			ExchangeStudent newGuy = new ExchangeStudent("20210531005", "王五", Gender.MALE, "21信管", "江西中医药大学");

            boy.Register();
            girl.Register();
			newGuy.Register();
            Read();
        }
    }
}