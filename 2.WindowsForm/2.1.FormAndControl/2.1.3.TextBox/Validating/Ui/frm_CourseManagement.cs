using System;
using System.Windows.Forms;
using System.ComponentModel;

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
            this.txb_CourseNumber.Validating += txb_CourseNumber_Validating; ;       //订阅文本框验证事件；
        }
        /// <summary>
        /// 课程号文本框验证；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txb_CourseNumber_Validating(object sender, CancelEventArgs e)
        {
            int currentLength = this.txb_CourseNumber.Text.Length;
            int maxLength = Course.MaxLengthOfNumber;
            if (currentLength > maxLength)
            {
                MessageBox.Show
                    ($"课程号当前长度为{currentLength}，超出最大长度{maxLength}"
                    , "错误"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
                this.txb_CourseNumber.Focus();                                      //文本框获得焦点；
                this.txb_CourseNumber.SelectAll();                                  //文本框选中所有文本；
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
