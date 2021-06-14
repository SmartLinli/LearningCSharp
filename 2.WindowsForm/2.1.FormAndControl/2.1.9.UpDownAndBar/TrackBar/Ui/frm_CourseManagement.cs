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
        }
        /// <summary>
        /// 理论课时滑动条滚动；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tkb_TheoreticalHour_Scroll(object sender, EventArgs e)
        {
            this._Course.TheoreticalHour = this.tkb_TheoreticalHour.Value;
            this.lbl_CourseHourDistribution.Text = this._Course.CourseHourDistribution;
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
            this.lbl_CourseHourDistribution.Text = this._Course.CourseHourDistribution;
            this.tkb_TheoreticalHour.Minimum = 0;                                       //设置滑动条最小值；
            this.tkb_TheoreticalHour.Maximum = this._Course.TotalHour;                  //设置滑动条最大值；
            this.tkb_TheoreticalHour.SmallChange = 1;                                   //设置滑动条滚动1段刻度所改变的值；
            this.tkb_TheoreticalHour.TickFrequency = this._Course.TotalHour / 8;        //设置滑动条刻度数量；
            this.tkb_TheoreticalHour.Value = this._Course.TheoreticalHour;              //设置滑动条的值；
        }
        /// <summary>
        /// 提交按钮点击；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            this._Course.TheoreticalHour = this.tkb_TheoreticalHour.Value;
            this.txb_CourseDescription.Text = this._Course.Description;
            MessageBox.Show("课程已提交");
        }
    }
}
