using System;
using System.Windows.Forms;

namespace SmartLin.LearningCSharp.FormAndControl
{
    /// <summary>
    /// 课程管理窗体；
    /// </summary>
    public partial class frm_CourseManagement : Form
    {
        /// <summary>
        /// 构造函数；
        /// </summary>
        public frm_CourseManagement()
        {
            InitializeComponent();
            this.btn_Reset.Enabled = false;                                             //设置按钮是否启用；
        }
        /// <summary>
        /// 点击复位按钮；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            this.btn_Reset.Enabled = false;
            this.btn_CurrentCourse.Text = "当前课程";
        }
        /// <summary>
        /// 点击载入按钮；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Load_Click(object sender, EventArgs e)
        {
            this.btn_CurrentCourse.Text = CourseRepository.Find("2060316").Name;
            this.btn_Reset.Enabled = true;
        }
    }
}
