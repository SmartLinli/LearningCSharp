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
            this.txb_CourseCredit.TextChanged += txb_CourseCredit_TextChanged; ;                    //订阅文本框文本更改事件；
        }
        /// <summary>
        /// 学分文本框文本更改；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txb_CourseCredit_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(this.txb_CourseCredit.Text);
            }
            catch (Exception)
            {
                MessageBox.Show
                ("学分应为数值！",
                 "错误",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 载入按钮点击；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Load_Click(object sender, EventArgs e)
        {
            this._Course = CourseRepository.Find("2060316");
            this.txb_CourseNumber.Text = this._Course.Number;
            this.txb_CourseName.Text = this._Course.Name;
            this.txb_CourseCredit.Text = this._Course.Credit.ToString();
            this.txb_CourseDescription.Text = this._Course.Description;
        }
        /// <summary>
        /// 提交按钮点击；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            this._Course.Number = this.txb_CourseNumber.Text;
            this._Course.Name = this.txb_CourseName.Text;
            this._Course.Credit = float.Parse(this.txb_CourseCredit.Text);
            this.txb_CourseDescription.Text = this._Course.Description;
            MessageBox.Show("课程已提交");
        }
    }
}
