using System;
using System.Windows.Forms;

namespace SmartLin.LearningCSharp.FormAndControl
{
    /// <summary>
    /// 启动窗体；
    /// </summary>
    public partial class StartForm : Form
    {
        /// <summary>
        /// 用户；
        /// </summary>
        private User _User;
        /// <summary>
        /// 构造函数
        /// </summary>
        public StartForm()
        {
            InitializeComponent();
            this.Click += this.StartForm_FormClicked;                                       //注册窗体单击事件的处理方法；
            this.FormClosed += this.StartForm_FormClosed;                                   //注册窗体关闭事件的处理方法；
        }
        /// <summary>
        /// 窗体载入；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartForm_Load(object sender, EventArgs e)
        {
            this._User = UserRepository.GetUser("3210707001");                              //通过用户仓储，获取用户对象；
            MessageBox.Show($"欢迎登录，{this._User.Name}。", "消息");
            this._User.Name += "同学";                                                      //修改用户；

        }
        /// <summary>
        /// 点击启动窗体；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartForm_FormClicked(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 启动窗体的窗体关闭；
        /// </summary>
        /// <param name="sender">发送方</param>
        /// <param name="e">窗体关闭事件</param>
        private void StartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show($"{this.Text}即将关闭。", "消息");
            MainForm mainForm = new MainForm(this._User);                                   //定义主窗体对象，并传入参数；
            mainForm.Show();                                                                //主窗体显示；
        }
    }
}
