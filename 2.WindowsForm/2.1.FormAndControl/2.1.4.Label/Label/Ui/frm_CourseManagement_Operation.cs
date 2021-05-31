using System;
using System.Windows.Forms;
using System.Collections.Generic;

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
        /// 错误消息标签字典；
        /// </summary>
        private Dictionary<string, Label> _ErrorMessageLabels;
        /// <summary>
        /// 重置控件；
        /// </summary>
        private void ResetControls()
        {
            this.lbl_CourseNumberError.Text = "";
            this.lbl_CourseNameError.Text = "";
            this.lbl_CourseCreditError.Text = "";
            this.txb_CourseNumber.Tag = true;
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
            this.txb_CourseNumber.Text = this._Course.Number;                           
            this.txb_CourseName.Text = this._Course.Name;
            this.txb_CourseCredit.Text = this._Course.Credit.ToString();
            this.txb_CourseDescription.Text = this._Course.Description;
        }
        /// <summary>
        /// 配置控件；
        /// </summary>
        private void ConfigControls()
        {
            this.btn_Abort.CausesValidation = false;                                    
            this.txb_CourseNumber.AccessibleName = "课程号";                            
            this.txb_CourseNumber.AccessibleDescription = "7";
            this.txb_CourseNumber.KeyPress += this.ValidateInt;
            this.txb_CourseNumber.Validating += this.ValidateTextBoxStringLength;
            this.txb_CourseName.AccessibleName = "课程名称";
            this.txb_CourseName.AccessibleDescription = "10";
            this.txb_CourseName.Validating += this.ValidateTextBoxStringLength;
            this.txb_CourseCredit.AccessibleName = "学分";
            this.txb_CourseCredit.TextChanged += this.ValidateFloat;
            this._ErrorMessageLabels = new Dictionary<string, Label>();
            this._ErrorMessageLabels.Add(this.txb_CourseNumber.AccessibleName, this.lbl_CourseNumberError);
            this._ErrorMessageLabels.Add(this.txb_CourseName.AccessibleName, this.lbl_CourseNameError);
            this._ErrorMessageLabels.Add(this.txb_CourseCredit.AccessibleName, this.lbl_CourseCreditError);
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
            Label errorMessageLabel = this._ErrorMessageLabels[textBoxName];
            if (textBox.Text.Length <= maxLength)
            {
                textBox.Tag = true;
                errorMessageLabel.Text = "";
            }
            else
            {
                errorMessageLabel.Text = $"{textBoxName}当前长度为{currentLength}，超出最大长度{maxLength}";
                textBox.Tag = false;
                textBox.Focus();                                                        
                textBox.SelectAll();                                                    
            }
            this.AfterValidate();
        }
        /// <summary>
        /// 验证整数；
        /// </summary>
        private void ValidateInt(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)                   
            {
                e.Handled = true;                                                       
            }
        }
        /// <summary>
        /// 验证浮点数；
        /// </summary>
        private void ValidateFloat(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string textBoxName = textBox.AccessibleName;
            Label errorMessageLabel = this._ErrorMessageLabels[textBoxName];
            try
            {
                float.Parse(textBox.Text);
                textBox.Tag = true;
                errorMessageLabel.Text = "";
            }
            catch (Exception)
            {
                errorMessageLabel.Text = "输入应为数值";
                textBox.Tag = false;
            }
            this.AfterValidate();
        }
        /// <summary>
        /// 验证后续；
        /// </summary>
        private void AfterValidate()
        {
            this.btn_Submit.Enabled =                                                   
                (bool)this.txb_CourseNumber.Tag                                         
                && (bool)this.txb_CourseName.Tag                                        
                && (bool)this.txb_CourseCredit.Tag;
        }
        /// <summary>
        /// 提交课程；
        /// </summary>
        private void SubmitCourse()
        {
            this._Course.Number = this.txb_CourseNumber.Text;                           //读取文本框文本；
            this._Course.Name = this.txb_CourseName.Text;
            this._Course.Credit = float.Parse(this.txb_CourseCredit.Text);
            this.txb_CourseDescription.Text = this._Course.Description;
        }
    }
}
