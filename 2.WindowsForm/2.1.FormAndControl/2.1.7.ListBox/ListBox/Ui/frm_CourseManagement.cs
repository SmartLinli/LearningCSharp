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
        /// 载入课程考核类型；
        /// </summary>
        private void LoadCourseAppraisalType()
        {
            this.lsb_CourseAppraisalType.Items.Clear();                                     //清空列表框的项目集合；
            this.lsb_CourseAppraisalType.Items.AddRange(CourseAppraisalType.GetAllTypes()); //批量加入列表框的项目集合；
            this.lsb_CourseAppraisalType.SelectedItem = this._Course.AppraisalType;         //设置列表框的选中项目；
        }
        /// <summary>
        /// 载入课程考核形式；
        /// </summary>
        private void LoadAppraisalForm()
        {
            string currentCourseAppraisalType =
                this.lsb_CourseAppraisalType.SelectedItem.ToString();                        //获取列表框的选中项目的字符串；
            string[] availableCourseAppraisalForms =
                CourseAppraisalType.GetAllForms(currentCourseAppraisalType);
            this.lsb_CourseAppraisalForm.Items.Clear();                                      //清空子列表框的项目集合；
            this.lsb_CourseAppraisalForm.Items.AddRange(availableCourseAppraisalForms);      //获取子项目，批量加入子列表框的项目集合；
            this.lsb_CourseAppraisalForm.SelectedItem = this._Course.AppraisalForm;          //设置列表框的选中项目；
        }
        /// <summary>
        /// 课程考核类型列表框更改选中序号；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lsb_CourseAppraisalType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadAppraisalForm();
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
            this.LoadCourseAppraisalType();
            this.LoadAppraisalForm();
        }
        /// <summary>
        /// 提交按钮点击；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            this._Course.AppraisalType = lsb_CourseAppraisalType.SelectedItem.ToString();
            this._Course.AppraisalForm = lsb_CourseAppraisalForm.SelectedItem.ToString();
            this.txb_CourseDescription.Text = this._Course.Description;
            MessageBox.Show("课程已提交");
        }
    }
}
