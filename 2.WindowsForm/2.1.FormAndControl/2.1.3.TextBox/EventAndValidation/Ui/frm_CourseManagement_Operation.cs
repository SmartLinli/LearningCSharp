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
        /// 重置验证结果；
        /// </summary>
        private void ResetValidationResult()
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
            this._Course = CourseRepository.Find("2060316");
            this.txb_CourseNumber.Text = this._Course.Number;                           //写入文本框文本；
            this.txb_CourseName.Text = this._Course.Name;
            this.txb_CourseCredit.Text = this._Course.Credit.ToString();
            this.txb_CourseDescription.Text = this._Course.Description;
        }
        /// <summary>
        /// 配置控件；
        /// </summary>
        private void ConfigConttrols()
        {
            this.btn_Abort.CausesValidation = false;                                    //该按钮不引起验证；    
            this.txb_CourseNumber.AccessibleName = "课程号";                            //设置控件名称；可用于存放描述；
            this.txb_CourseNumber.AccessibleDescription = "7";                          //设置控件说明；可用于存放最大字符串长度；
            this.txb_CourseNumber.KeyPress += this.ValidateInt;                         //订阅文本框按键敲击事件；
            this.txb_CourseNumber.Validating += this.ValidateTextBoxStringLength;       //订阅文本框验证期间事件；
            this.txb_CourseName.AccessibleName = "课程名称";
            this.txb_CourseName.AccessibleDescription = "10";
            this.txb_CourseName.Validating += this.ValidateTextBoxStringLength;
            this.txb_CourseCredit.TextChanged += this.ValidateFloat;                    //订阅文本框文本更改事件；
        }
        /// <summary>
        /// 验证文本框字符串长度；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidateTextBoxStringLength(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string textBoxName = textBox.AccessibleName;
            int currentLength = textBox.Text.Length;
            int maxLength = int.Parse(textBox.AccessibleDescription);
            if (textBox.Text.Length <= maxLength)
            {
                textBox.Tag = true;                                                     //将验证结果写入文本框的标签；标签可接受object类型的对象；
            }
            else
            {
                MessageBox.Show
                    ($"{textBoxName}当前长度为{currentLength}，超出最大长度{maxLength}"
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
        /// 验证整数；
        /// </summary>
        private void ValidateInt(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)                   //若按键并非数字或退格键；
            {
                e.Handled = true;                                                       //不接收按键输入的字符；
            }
        }
        /// <summary>
        /// 验证浮点数；
        /// </summary>
        private void ValidateFloat(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
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
