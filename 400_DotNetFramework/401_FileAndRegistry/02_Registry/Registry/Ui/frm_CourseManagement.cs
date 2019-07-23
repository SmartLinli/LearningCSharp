using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SmartLin.LearningCSharp.FileAndRegistry
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
        /// 学分数字增减框值更改；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nud_CourseCredit_ValueChanged(object sender, EventArgs e)
        {
            this.Validate(sender as NumericUpDown);
            this.BindingWriteValue(sender, "Value");              
        }
        /// <summary>
        /// 当前学分设为默认值按钮点击；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SetCourseCreditDefault_Click(object sender, EventArgs e)
        {
            this.SetCourseCreditDefault(this.nud_CourseCredit.Value);
        }
        /// <summary>
        /// 为当前学分获取默认值按钮点击；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_GetCourseCreditDefault_Click(object sender, EventArgs e)
        {
            this.nud_CourseCredit.Value = this.GetCourseCreditDefault();
        }
        /// <summary>
        /// 理论课时滑动条滚动；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tkb_TheoreticalHour_Scroll(object sender, EventArgs e)
        {
            this._Course.TheoreticalHour = this.tkb_TheoreticalHour.Value;
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
                (this.lsb_CourseAppraisalType
                , this.lsb_CourseAppraisalForm
                , CourseAppraisalType.GetForms);
        }
        /// <summary>
        /// 点击打开（课程描述）按钮；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OpenTxt_Click(object sender, EventArgs e)
        {
            this.OpenTxtFile(this.txb_CourseDescription);
        }
        /// <summary>
        /// 点击保存（课程描述）按钮；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SaveTxt_Click(object sender, EventArgs e)
        {
            this.SaveTxtFile(this.txb_CourseDescription);
        }
        /// <summary>
        /// 工具栏绘制；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">绘制事件参数</param>
        private void ToolStrip_Paint(object sender, PaintEventArgs e)
        {
            this.RepaintToolStrip(sender as ToolStrip, e);                            
        }
        /// <summary>
        /// 粗体按钮点击；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_Bold_Click(object sender, EventArgs e)
        {
            this.SetFontStyle(this.rtb_CourseSyllabus, FontStyle.Bold);
        }
        /// <summary>
        /// 斜体按钮点击；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_Italic_Click(object sender, EventArgs e)
        {
            this.SetFontStyle(this.rtb_CourseSyllabus, FontStyle.Italic);
        }
        /// <summary>
        /// 下划线按钮点击；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_Underlined_Click(object sender, EventArgs e)
        {
            this.SetFontStyle(this.rtb_CourseSyllabus, FontStyle.Underline);
        }
        /// <summary>
        /// 点击颜色按钮；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_Color_Click(object sender, EventArgs e)
        {
            this.SetFontColor(this.rtb_CourseSyllabus);
        }
        /// <summary>
        /// 点击字体按钮；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_Font_Click(object sender, EventArgs e)
        {
            this.SetFont(this.rtb_CourseSyllabus);
        }
        /// <summary>
        /// 点击打开按钮；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OpenRtf_Click(object sender, EventArgs e)
        {
            this.OpenRtfFile(this.rtb_CourseSyllabus);
        }
        /// <summary>
        /// 点击保存按钮；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SaveRtf_Click(object sender, EventArgs e)
        {
            this.SaveRtfFile(this.rtb_CourseSyllabus);
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
