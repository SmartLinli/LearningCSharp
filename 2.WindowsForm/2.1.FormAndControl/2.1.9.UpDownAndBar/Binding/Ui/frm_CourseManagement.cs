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
            this.ResetControls();
            this.LoadCourse();
            this.ConfigControls();
        }
        /// <summary>
        /// 学分数字增减框值更改；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nud_CourseCredit_ValueChanged(object sender, EventArgs e)
        {
            this.BindingWriteValue(sender, "Value");
        }
        /// <summary>
        /// 理论课时滑动条滚动；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tkb_TheoreticalHour_Scroll(object sender, EventArgs e)
        {
            this.BindingWriteValue(sender, "Value");
        }
        /// <summary>
        /// 必修课单选按钮选中状态更改；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_IsCompulsory_CheckedChanged(object sender, EventArgs e)
        {
            this._Course.LearningType = (sender as RadioButton).Text;                     //获取单选按钮的文本；
        }
        /// <summary>
        /// 选修课单选按钮选中状态更改；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_IsOptional_CheckedChanged(object sender, EventArgs e)
        {
            this._Course.LearningType = (sender as RadioButton).Text;
        }
        /// <summary>
        /// 课程考核类型列表框更改选中序号；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lsb_CourseAppraisalType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ListBoxLoadSubItems
                (this.lsb_CourseAppraisalType,
                 this.lsb_CourseAppraisalForm,
                 CourseAppraisalType.GetAllForms);
        }
        /// <summary>
        /// 提交按钮点击；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            this.SubmitCourse();
        }
        /// <summary>
        /// 放弃按钮点击；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Abort_Click(object sender, EventArgs e)
        {
            this.ResetControls();
            this.LoadCourse();
        }
    }
}
