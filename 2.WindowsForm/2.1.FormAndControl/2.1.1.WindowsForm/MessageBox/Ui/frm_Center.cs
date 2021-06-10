using System.Windows.Forms;

namespace SmartLin.LearningCSharp.FormAndControl
{
    /// <summary>
    /// 启动窗体；
    /// </summary>
    public partial class frm_Center : Form                                       
    {
        private string _UserName => "张三";
        /// <summary>
        /// 构造函数
        /// </summary>
        public frm_Center()
        {
            InitializeComponent();
            MessageBox.Show($"即将进入{this._UserName}的个人中心");
        }
    }
}
