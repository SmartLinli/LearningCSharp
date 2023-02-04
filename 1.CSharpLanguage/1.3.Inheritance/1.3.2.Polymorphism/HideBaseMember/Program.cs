using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
    class Program
    {
        static void Main()
        {
			Undergraduate boy = new Undergraduate("3230707001", "张三", Gender.MALE, "23信管");
			ExchangeStudent newGuy = new ExchangeStudent("20220531005", "王五", Gender.MALE, "22信管", "江西中医药大学");

			boy.TransferToMajor("22康复");
			newGuy.TransferToMajor("22健管");
			Read();
		}
	}
}