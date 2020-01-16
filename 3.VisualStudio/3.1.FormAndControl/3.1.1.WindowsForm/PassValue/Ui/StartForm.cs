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
            this._User = UserService.GetUser("3180707001", "周林好");                       //通过基于单例模式的用户服务，获取全局唯一的用户对象；
            MessageBox.Show
                (string.Format("欢迎登录，{0}。", this._User.Name)
                , "消息");                                                                  
            this._User.Name += "同学";                                                      //修改用户；
        }
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
            MessageBox.Show
                (string.Format("{0}即将关闭。", this.Text)
                , "消息");                                                                 
            MainForm mainForm = new MainForm();                                             //定义主窗体对象；
            mainForm.Show();                                                                //主窗体显示；
        }
    }
}
