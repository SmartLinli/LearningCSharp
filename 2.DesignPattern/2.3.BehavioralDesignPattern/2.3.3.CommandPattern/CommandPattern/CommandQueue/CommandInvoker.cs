using System.Collections.Generic;

namespace SmartLin.LearningCSharp.CommandPattern
{
    /// <summary>
    /// 命令请求者；
    /// </summary>
    public class CommandInvoker                                             //定义命令请求者；
    {
        /// <summary>
        /// 命令队列；
        /// </summary>
        private static Queue<ICommand> _Commands = new Queue<ICommand>();
        /// <summary>
        /// 添加命令；
        /// </summary>
        /// <param name="commands">命令</param>
        public static void AddCommands(ICommand[] commands)
        {
            foreach (var command in commands)
            {
                _Commands.Enqueue(command);
            }
        }
        /// <summary>
        /// 请求；
        /// </summary>
        public static void Invoke()
        {
            while (_Commands.Count > 0)
            {
                ICommand command = _Commands.Dequeue();
                command.Execute();                                          //命令对象执行命令；
            }
        }
    }
}
