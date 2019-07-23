using System.Windows.Forms;

namespace SmartLin.LearningCSharp.FormAndControl
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        static void Main()
        {
            Application.Run(new StartForm());                               //创建窗体对象，并由Application类的Run静态方法启动窗体；该窗体关闭后，应用程序亦将结束；
        }
    }
}
