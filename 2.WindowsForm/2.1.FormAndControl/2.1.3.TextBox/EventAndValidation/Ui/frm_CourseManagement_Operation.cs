using System;
using System.Windows.Forms;

namespace SmartLin.LearningCSharp.FormAndControl
{
    /// <summary>
    /// 课程管理窗体；
    /// </summary>
    public partial class frm_CourseManagement
    {
        /// <summary>
        /// 课程；
        /// </summary>
        private Course _Course;
        /// <summary>
        /// 重置控件；
        /// </summary>
        private void ResetControls()
        {
            this.txb_CourseNumber.Tag = true;                                           //将验证结果写入文本框的标签；标签可接受object类型的对象；
            this.txb_CourseName.Tag = true;
            this.txb_CourseCredit.Tag = true;
            this.btn_Submit.Enabled = true;
        }
        /// <summary>
        /// 载入课程；
        /// </summary>
        private void LoadCourse()
        {
            this._Course = CourseRepository.Get();
            this.txb_CourseNumber.Text = this._Course.Number;                           //写入文本框文本；
            this.txb_CourseName.Text = this._Course.Name;
            this.txb_CourseCredit.Text = this._Course.Credit.ToString();
            this.txb_CourseDescription.Text = this._Course.Description;
        }
        /// <summary>
        /// 验证；
        /// </summary>
        /// <param name="textBox">文本框</param>
        private void Validate(TextBox textBox) 
        {
            try
            {
                ValidationService.ValidateControl(this, textBox);                       //利用特性实现验证；
                textBox.Tag = true;                                                     //将验证结果写入文本框的标签；标签可接受object类型的对象；
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show
                    (ex.Message
                    , "错误"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
                textBox.Tag = false;
                textBox.Focus();                                                        //文本框获得焦点；
                textBox.SelectAll();                                                    //文本框选中所有文本；
            }
            this.AfterValidate();
        }
        /// <summary>
        /// 验证按键；
        /// </summary>
        /// <param name="e">按键事件参数</param>
        private void ValidateKeyPress(KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)                   //若按键并非数字或退格键；
            {
                e.Handled = true;                                                       //不接收按键输入的字符；
            }
        }
        /// <summary>
        /// 验证文本；
        /// </summary>
        /// <param name="textBox">文本框</param>
        private void ValidateText(TextBox textBox)
        {
            try
            {
                float.Parse(textBox.Text);
                textBox.Tag = true;
            }
            catch (Exception)
            {
                MessageBox.Show
                     ("输入应为数值"
                     , "错误"
                     , MessageBoxButtons.OK
                     , MessageBoxIcon.Error);
                textBox.Tag = false;
            }
            this.AfterValidate();
        }
        /// <summary>
        /// 验证后续；
        /// </summary>
        private void AfterValidate()
        {
            this.btn_Submit.Enabled =                                               //若所有已验证文本框均已通过验证，则启动提交按钮；
                (bool)this.txb_CourseNumber.Tag                                     //获取所有已验证文本框的标签，并转为逻辑值；
                && (bool)this.txb_CourseName.Tag                                    //对所有逻辑值进行与运算；
                && (bool)this.txb_CourseCredit.Tag;
        }
        /// <summary>
        /// 提交课程；
        /// </summary>
        private void SubmitCourse()
        {
            this._Course.Number = this.txb_CourseNumber.Text;                       //读取文本框文本；
            this._Course.Name = this.txb_CourseName.Text;
            this._Course.Credit = float.Parse(this.txb_CourseCredit.Text);
            this.txb_CourseDescription.Text = this._Course.Description;
        }
    }
}
