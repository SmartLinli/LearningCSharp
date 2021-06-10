using System.Windows.Forms;

namespace SmartLin.LearningCSharp.FormAndControl
{
    /// <summary>
    /// 启动窗体；
    /// </summary>
    public partial class frm_Center : Form                                       //所有窗体均派生于Form类；
    {
        private string _UserName => "张三";
        /// <summary>
        /// 构造函数
        /// </summary>
        public frm_Center()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = $"{this._UserName}的个人中心";
        }
    }
}
