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
        /// 课程；
        /// </summary>
        private Course _Course;
        /// <summary>
        /// 构造函数；
        /// </summary>
        public frm_CourseManagement()
        {
            InitializeComponent();
            this.btn_Submit.Enabled = false;                                             //设置按钮是否启用；
        }
        /// <summary>
        /// 点击载入按钮；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Load_Click(object sender, EventArgs e)
        {
            this._Course = CourseRepository.Find("2060316");
            MessageBox.Show($"已载入《{this._Course.Name}》。修改课程信息后请及时提交。");
            this.btn_Submit.Enabled = true;
        }
        /// <summary>
        /// 点击提交按钮；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Submit_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show($"已提交《{this._Course.Name}》。若需再次修改课程信息，请重新载入。");
            this.btn_Submit.Enabled = false;
        }
    }
}
