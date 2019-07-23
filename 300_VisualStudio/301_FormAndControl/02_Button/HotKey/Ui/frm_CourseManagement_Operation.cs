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
            this.btn_Previous.Enabled = CourseService.HasPrevious;                      //设置按钮是否启用；
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
            this.AcceptButton = this.btn_Modify;
            this.CancelButton = null;
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
            this.btn_Modify.Enabled = false;                                            //设置按钮是否启用；
            this.btn_Submit.Enabled = true;
            this.btn_Abort.Enabled = true;
            this.AcceptButton = this.btn_Submit;                                        //设置按下回车键时点击的按钮；该功能仅在焦点处于非按钮控件时生效；若焦点处于其它按钮，则按下回车键只能点击其它按钮；
            this.CancelButton = this.btn_Abort;                                         //设置按下ESC键时点击的按钮；
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
        /// <summary>
        /// 课程管理窗体的按键按下；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_CourseManagement_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)                                                              //若按住Ctrl键；
            {
                switch (e.KeyCode)                                                      //进一步判断按键；
                {
                    case Keys.B:                                                        //若按键为Ctrl+B；
                        {
                            this.btn_Abort.PerformClick();                              //触发相应按钮的点击事件；
                        }
                        break;
                    case Keys.S:
                        {
                            this.btn_Submit.PerformClick();
                        }
                        break;
                    default:
                        break;
                }
            };
        }
        /// <summary>
        /// 处理命令按键；
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)            //重写基类方法；
        {
            switch (keyData)                                                            //判断按键；
            {
                case Keys.Left:
                    {
                        this.btn_Previous.PerformClick();
                        return true;                                                    //完成按键处理；
                    }
                case Keys.Right:
                    {
                        this.btn_Next.PerformClick();
                        return true;
                    }
            }
            return base.ProcessCmdKey(ref msg, keyData);                                //对于其它按键，则调用基类方法；
        }
    }
}