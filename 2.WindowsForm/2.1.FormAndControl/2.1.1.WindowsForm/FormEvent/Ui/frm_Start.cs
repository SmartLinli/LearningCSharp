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
        /// 构造函数
        /// </summary>
        public frm_Start()
        {
            InitializeComponent();
            this.Click += this.frm_Start_FormClicked;                                       //注册窗体单击事件的处理方法；
            this.FormClosed += this.frm_Start_FormClosed;                                   //注册窗体关闭事件的处理方法；
        }
        /// <summary>
        /// 启动窗体的单击；
        /// </summary>
        /// <param name="sender">发送方</param>
        /// <param name="e">事件参数</param>
        private void frm_Start_FormClicked(object sender, EventArgs e)
        {
            this.Close();                                                                   //窗体关闭；
        }
        /// <summary>
        /// 启动窗体的窗体关闭；
        /// </summary>
        /// <param name="sender">发送方</param>
        /// <param name="e">窗体关闭事件参数</param>
        private void frm_Start_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show($"{this.Text}即将关闭。");
            frm_Main mainForm = new frm_Main();                                             //定义主窗体对象；
            mainForm.Show();                                                                //主窗体显示；
        }
    }
}
