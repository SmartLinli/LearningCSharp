using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
    class Program
    {
        static void Main()
        {
            Faculty mrLin = new Faculty("2004034", "林立");
            Inspector mrHuang = new Inspector("2011044", "黄至辉");					
													
            mrHuang.Analyse(mrLin);													
            mrHuang.Propose(mrLin);
            Read();
        }
    }
}