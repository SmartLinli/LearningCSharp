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
        /// 保存课程类型；
        /// </summary>
        private void SaveCourseType()
        {
            foreach (var control in this.gpb_CourseType.Controls)                       //遍历分组框中的控件集合；
            {
                RadioButton radioButton = control as RadioButton;                       //将控件转为单选按钮；
                if (radioButton.Checked)                                                //若单选按钮被选中；
                {
                    this._Course.Type = radioButton.Text;                               //则获取单选按钮的文本；
                    break;
                }
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
            this.txb_CourseDescription.Text = this._Course.Description;
            this.rdb_IsProfessional.Checked =                                           //单选按钮被选中后，同一分组框中的其它单选按钮将不会被选中；
                (this.rdb_IsProfessional.Text == this._Course.Type);                    //根据单选按钮的文本与对象属性值是否一致，设置单选按钮是否被选中；
            this.rdb_IsPublic.Checked =
                (this.rdb_IsPublic.Text == this._Course.Type);
            this.rdb_IsCompulsory.Checked =
                (this.rdb_IsCompulsory.Text == this._Course.LearningType);
            this.rdb_IsOptional.Checked =
                (this.rdb_IsOptional.Text == this._Course.LearningType);
        }
        /// <summary>
        /// 提交按钮点击；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            this.SaveCourseType();
            this.txb_CourseDescription.Text = this._Course.Description;
            MessageBox.Show("课程已提交");
        }
    }
}
