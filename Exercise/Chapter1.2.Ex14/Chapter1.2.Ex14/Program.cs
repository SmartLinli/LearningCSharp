using static System.Console;

namespace Chapter1_2_Ex14
{
    internal class Program
    {
        static void Main()
        {
            CardOwner boy = new CardOwner()
            {
                Number = "3230707001",
                Name = "张三",
                Password = "8888",
                IsPasswordNeeded = true,
                ConsumptionLimit = 50,
                DailyConsumptionLimit = 100
            };
            boy.Recharge(85);
            boy.Subsidise(20);

            boy.Consume(20);
            boy.Consume(60);
            boy.Consume(25);
            boy.Consume(15);
            boy.Consume(20);
            boy.Recharge(200);

            /*此时可以将系统日期调至次日*/
            boy.Consume(80);
            Read();
        }
    }
}
