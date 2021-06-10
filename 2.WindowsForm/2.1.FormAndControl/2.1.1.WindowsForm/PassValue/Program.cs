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
            frm_Start startForm = new frm_Start();                          
            startForm.Show();                                               
            Application.Run();                                              
        }
    }
}
