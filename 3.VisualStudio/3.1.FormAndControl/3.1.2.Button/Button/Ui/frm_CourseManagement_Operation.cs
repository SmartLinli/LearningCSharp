using System.Windows.Forms;

namespace SmartLin.LearningCSharp.FormAndControl
{
    /// <summary>
    /// 课程管理窗体；
    /// </summary>
    public partial class frm_CourseManagement
    {
        /// <summary>
        /// 刷新课程按钮；
        /// </summary>
        private void RefreshCourseButtons()
        {
            this.btn_Previous.Enabled = CourseService.HasPrevious;                          //设置按钮是否启用；
            this.btn_Next.Enabled = CourseService.HasNext;
            this.btn_CurrentCourse.Text = CourseService.GetCurrentCourse().Name;
        }
        /// <summary>
        /// 重置控件；
        /// </summary>
        private void ResetControls()
        {
            this.btn_Modify.Enabled = true;
            this.btn_Submit.Enabled = false;
            this.btn_Abort.Enabled = false;
        }
        /// <summary>
        /// 获取上一门课程；
        /// </summary>
        private void GetPreviousCourse()
        {
            CourseService.Previous();
            this.RefreshCourseButtons();
        }
        /// <summary>
        /// 获取下一门课程；
        /// </summary>
        private void GetNextCourse()
        {
            CourseService.Next();
            this.RefreshCourseButtons();
        }
        /// <summary>
        /// 修改；
        /// </summary>
        private void Modify()
        {
            this.btn_Modify.Enabled = false;                                                //设置按钮是否启用；
            this.btn_Submit.Enabled = true;
            this.btn_Abort.Enabled = true;
        }
        /// <summary>
        /// 提交；
        /// </summary>
        private void Submit()
        {
            DialogResult messageboxResult =                                                 //定义对话框操作结果，用于接收消息框操作结果；
                MessageBox.Show
                    ("您确定要提交吗？"
                    , "提示"
                    , MessageBoxButtons.YesNo                                               //消息框按钮；
                    , MessageBoxIcon.Question);                                             //消息框图标；
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
        /// 放弃；
        /// </summary>
        private void Abort()
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