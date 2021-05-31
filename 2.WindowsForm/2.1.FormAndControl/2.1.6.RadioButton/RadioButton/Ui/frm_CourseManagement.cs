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
        /// 必修课单选按钮选中状态更改；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdb_IsCompulsory_CheckedChanged(object sender, EventArgs e)            //选中或取消选中均能触发选中状态更改事件；若分组框中的若干单选按钮触发选中状态更改事件，则取消选中的单选按钮先触发事件，而选中的单选按钮后触发事件；
        {
            this._Course.LearningType = (sender as RadioButton).Text;                       //获取单选按钮的文本；
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
