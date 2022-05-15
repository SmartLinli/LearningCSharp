using System;
using System.Windows.Forms;

namespace SmartLin.LearningCSharp.FormAndControl
{
    /// <summary>
    /// 主窗体；
    /// </summary>
    public partial class frm_Main : Form
    {
        /// <summary>
        /// 构造函数；
        /// </summary>
        public frm_Main()
        {
            InitializeComponent();
            this.FormClosed += this.frm_Main_FormClosed;                                //注册窗体关闭事件的处理方法；此类代码不宜在InitializeComponent方法中实现，以免被窗体设计器自动生成的代码覆盖；
        }
        /// <summary>
        /// 窗体载入；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_Main_Load(object sender, EventArgs e)                          //双击窗体空白处，将自动创建函数，并注册窗体载入事件；该注册操作位于设计器代码文件中；
        {
            MessageBox.Show($"即将进入{this.Text}。");
        }
        /// <summary>
        /// 主窗体的窗体关闭；
        /// </summary>
        /// <param name="sender">发送方</param>
        /// <param name="e">窗体关闭事件</param>
        private void frm_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show($"再见。");
            Application.Exit();                                                         //应用程序关闭；所有窗体均将关闭，且不触发窗体关闭事件；
        }
    }
}
