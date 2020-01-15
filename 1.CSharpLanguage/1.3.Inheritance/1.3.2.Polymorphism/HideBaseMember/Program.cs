using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
    class Program
    {
        static void Main()
        {
			Undergraduate boy = new Undergraduate("3190707000", "张三", Gender.MALE, "19信管");
			ExchangeStudent newGuy = new ExchangeStudent("20190531001", "王五", Gender.MALE, "19信管", "江西中医药大学");

			boy.TransferToMajor("20康复");
			newGuy.TransferToMajor("20健管");
			Read();
		}
	}
}