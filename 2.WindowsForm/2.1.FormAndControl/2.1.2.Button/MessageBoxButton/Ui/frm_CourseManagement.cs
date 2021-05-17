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
        }
        /// <summary>
        /// 重置控件；
        /// </summary>
        private void ResetControls()
        {
            this.btn_Reset.Enabled = false;
            this.btn_Modify.Enabled = false;
            this.btn_Submit.Enabled = false;
            this.btn_Abort.Enabled = false;
            this.btn_CurrentCourse.Text = "当前课程";
        }
        /// <summary>
        /// 点击复位按钮；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            this.ResetControls();
        }
        /// <summary>
        /// 点击载入按钮；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Load_Click(object sender, EventArgs e)
        {
            this.btn_CurrentCourse.Text = CourseRepository.Find("2060316").Name;
            this.btn_Reset.Enabled = true;
            this.btn_Modify.Enabled = true;
        }
        /// <summary>
        /// 点击修改按钮；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Modify_Click(object sender, EventArgs e)
        {
            this.btn_Modify.Enabled = false;
            this.btn_Submit.Enabled = true;
            this.btn_Abort.Enabled = true;
        }
        /// <summary>
        /// 点击提交按钮；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            DialogResult messageboxResult =                                                 //定义对话框操作结果，用于接收消息框操作结果；
                MessageBox.Show
                ("您确定要提交吗？"
                , "提示"
                , MessageBoxButtons.YesNo                                                   //消息框按钮；
                , MessageBoxIcon.Question);                                                 //消息框图标；
            if (messageboxResult == DialogResult.Yes)                                       //若消息框操作结果为是；
            {
                MessageBox.Show
                    ("已提交。"
                    , "消息"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.ResetControls();
            }
        }
        /// <summary>
        /// 点击放弃按钮；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Abort_Click(object sender, EventArgs e)
        {
            DialogResult messageboxResult =
                MessageBox.Show
                ("您确定要放弃吗？"
                , "警告"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Warning);
            if (messageboxResult == DialogResult.Yes)
            {
                MessageBox.Show
                    ("已放弃。"
                    , "消息"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                this.ResetControls();
            }
        }
    }
}
