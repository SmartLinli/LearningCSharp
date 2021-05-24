using System.Windows.Forms;

namespace SmartLin.LearningCSharp.FormAndControl
{
    /// <summary>
    /// 启动窗体；
    /// </summary>
    public partial class StartForm : Form                                       //所有窗体均派生于Form类；
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public StartForm()
        {
            InitializeComponent();
            MessageBox.Show(string.Format("即将进入{0}。", this.Text));         //消息框派生于Form类；
        }

    }
}
