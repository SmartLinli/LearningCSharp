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
            this.PrepareControls();
        }
        /// <summary>
        /// 文本框验证期间；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_Validating(object sender, EventArgs e)
        {
            this.Validate(sender as TextBox);
        }
        /// <summary>
        /// 课程号文本框按键敲击；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txb_CourseNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ValidateKeyPress(e);
        }
        /// <summary>
        /// 学分文本框文本更改；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txb_CourseCredit_TextChanged(object sender, EventArgs e)
        {
            this.ValidateText(this.txb_CourseCredit, this.lbl_CourseCreditError);
        }
        /// <summary>
        /// 必修课单选按钮选中状态更改；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_IsCompulsory_CheckedChanged(object sender, EventArgs e)
        {
            this._Course.LearningType = (sender as RadioButton ).Text;                     //获取单选按钮的文本；
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
                (this.lsb_CourseAppraisalType
                , this.lsb_CourseAppraisalForm
                , CourseAppraisalType.GetForms);
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
