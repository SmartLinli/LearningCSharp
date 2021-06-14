using static System.Console;

namespace SmartLin.LearningCSharp.SingletonPattern
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Write(SequentialNumberService.Instance.GetSequentialNumber());
                if (ReadLine() == "x")
                {
                    break;
                }
            }
            ReadLine();
        }
    }
}
