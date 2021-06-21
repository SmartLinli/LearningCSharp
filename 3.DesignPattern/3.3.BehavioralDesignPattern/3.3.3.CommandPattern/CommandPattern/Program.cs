using static System.Console;

namespace SmartLin.LearningCSharp.CommandPattern
{
    class Program
    {
        static void Main()
        {
            ICommand[] commands =                                           
            {
               new TeachingAffairCommand(new TeachingAffair())              //定义具体命令对象，并引用命令接受者；
               ,new StudentAffairCommand(new StudentAffair())
               ,new FinancialAffairCommand(new FinancialAffair())
            };
            CommandInvoker.AddCommands(commands);
            CommandInvoker.Invoke();                                        //请求执行命令；
            ReadLine();
        }
    }
}
