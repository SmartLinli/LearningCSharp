using System.Windows.Forms;

namespace SmartLin.LearningCSharp.FormAndControl
{
    /// <summary>
    /// 主窗体；
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// 用户；
        /// </summary>
        private User _User;
        /// <summary>
        /// 构造函数；
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            this.FormClosed += this.MainForm_FormClosed;                                //注册窗体关闭事件的处理方法；
            this._User = UserService.GetUser("3180707001", "周林好");                   //通过基于单例模式的用户服务，获取全局唯一的用户对象；
            MessageBox.Show
                (string.Format("即将进入{0}，{1}。", this.Text, this._User.Name)
                , "消息");
        }
        /// <summary>
        /// 主窗体的窗体关闭；
        /// </summary>
        /// <param name="sender">发送方</param>
        /// <param name="e">窗体关闭事件</param>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show
                (string.Format("再见，{0}。", this._User.Name)
                , "消息");
            Application.Exit();                                                         //应用程序关闭；所有窗体均将关闭，且不触发窗体关闭事件；
        }
    }
}
