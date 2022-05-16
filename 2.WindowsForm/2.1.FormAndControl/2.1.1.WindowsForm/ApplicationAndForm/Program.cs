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
            frm_Start startForm = new frm_Start();                          //定义启动窗体对象；
            startForm.Show();                                               //启动窗体显示；窗体将在新线程中启动；
            Application.Run();                                              //调用Application类的Run静态方法启动应用程序；窗体关闭后，应用程序不会结束，需在最后1个窗体关闭时调用Application类的Exit静态方法才能结束应用程序；
        }
    }
}
