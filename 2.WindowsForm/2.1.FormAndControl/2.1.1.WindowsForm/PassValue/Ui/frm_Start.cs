using System;
using System.Windows.Forms;

namespace SmartLin.LearningCSharp.FormAndControl
{
    /// <summary>
    /// 启动窗体；
    /// </summary>
    public partial class frm_Start : Form
    {
        /// <summary>
        /// 用户；
        /// </summary>
        private User _User;
        /// <summary>
        /// 构造函数
        /// </summary>
        public frm_Start()
        {
            InitializeComponent();
            this.Click += this.frm_Start_FormClicked;                                       //注册窗体单击事件的处理方法；
            this.FormClosed += this.frm_Start_FormClosed;                                   //注册窗体关闭事件的处理方法；
        }
        /// <summary>
        /// 窗体载入；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_Start_Load(object sender, EventArgs e)
        {
            this._User = UserRepository.Find("3210707001");                                 //通过用户仓储，获取用户对象；
            MessageBox.Show($"欢迎登录，{this._User.Name}。");
        }
        /// <summary>
        /// 点击启动窗体；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_Start_FormClicked(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 启动窗体的窗体关闭；
        /// </summary>
        /// <param name="sender">发送方</param>
        /// <param name="e">窗体关闭事件</param>
        private void frm_Start_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show($"{this.Text}即将关闭。");
            frm_Main mainForm = new frm_Main(this._User);                                   //定义主窗体对象，并传入参数；
            mainForm.Show();                                                                //主窗体显示；
        }
    }
}
