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
            this.nud_CourseCredit.Increment = 0.5m;                                                 //设置数值增减框的递增值；
        }
        /// <summary>
        /// 载入按钮点击；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Load_Click(object sender, EventArgs e)
        {
            this._Course = CourseRepository.Find("2060316");
            this.txb_CourseDescription.Text = this._Course.Description;
            this.nud_CourseCredit.Minimum = CourseService.MinCredit;                                //设置数值增减框的最小值；
            this.nud_CourseCredit.Maximum = CourseService.MaxCredit;                                //设置数值增减框的最大值；
            this.nud_CourseCredit.Value = this._Course.Credit;                                      //访问数值增减框的值；
        }
        /// <summary>
        /// 提交按钮点击；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            this._Course.Credit = this.nud_CourseCredit.Value;
            this.txb_CourseDescription.Text = this._Course.Description;
            MessageBox.Show("课程已提交");
        }
    }
}
