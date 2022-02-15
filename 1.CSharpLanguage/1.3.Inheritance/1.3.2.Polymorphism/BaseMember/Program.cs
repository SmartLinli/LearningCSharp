using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
    class Program
    {
        static void Main()
        {
			Faculty msYang = new Faculty("2002010", "杨雪梅", Gender.FEMALE, "人文与管理学院");
			Undergraduate boy = new Undergraduate("3220707001", "张三", Gender.MALE, "21信管");
			Postgraduate girl = new Postgraduate("2190757002", "李四", Gender.FEMALE, msYang);
			girl.AssignDirection("数据可视化");
			ExchangeStudent newGuy = new ExchangeStudent("20210531005", "王五", Gender.MALE, "21信管", "江西中医药大学");

			boy.Intro();
			WriteLine();
			girl.Intro();
			WriteLine();
			newGuy.Intro();
			Read();
		}
	}
}