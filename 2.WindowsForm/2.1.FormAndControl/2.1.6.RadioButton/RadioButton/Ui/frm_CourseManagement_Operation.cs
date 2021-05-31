using System;
using System.Collections.Generic;
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
            this.ckb_IsAvailable.Checked = this._Course.IsAvailable;                                   
            this.ckb_HasExperiment.Checked = this._Course.HasExperiment;
            this.ckb_HasMooc.Checked = this._Course.HasMooc;
            this.AddRangeWithCheckedItem
                (this.clb_FormativeAssessment,
                 this._Course.FormativeAssessments,
                 CourseService.GetAllFormativeAssessment);
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
        /// 批量添加应选中的项目；
        /// </summary>
        /// <param name="checkedListBox">多选列表框</param>
        /// <param name="selectedItems">应选中项目</param>
        /// <param name="allItems">所有项目</param>
        private void AddRangeWithCheckedItem<T>(CheckedListBox checkedListBox, T[] selectedItems, T[] allItems) where T : class
        {
            checkedListBox.Items.Clear();                                               
            checkedListBox.Items.AddRange(selectedItems);                               
            for (int i = 0; i < checkedListBox.Items.Count; i++)                        
            {
                checkedListBox.SetItemChecked(i, true);                                 
            }
            HashSet<T>                                                                  
                currentItemsHashSet = new HashSet<T>(selectedItems)
                , allItemsHashSet = new HashSet<T>(allItems);
            allItemsHashSet.ExceptWith(currentItemsHashSet);                            
            object[] restItems = (new List<T>(allItemsHashSet)).ToArray();              
            checkedListBox.Items.AddRange(restItems);                                   
        }
        /// <summary>
        /// 多选列表框选中项目转为数组；
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="checkedListBox">多选列表框</param>
        /// <returns>数组</returns>
        private T[] CheckedItemsToArray<T>(CheckedListBox checkedListBox)
        {
            List<T> itemList = new List<T>();
            foreach (var item in checkedListBox.CheckedItems)                           
            {
                itemList.Add((T)item);                                                  
            }
            return itemList.ToArray();                                                  
        }
        /// <summary>
        /// 提交课程；
        /// </summary>
        private void SubmitCourse()
        {
            this._Course.Number = this.txb_CourseNumber.Text;                                   
            this._Course.Name = this.txb_CourseName.Text;
            this._Course.Credit = float.Parse(this.txb_CourseCredit.Text);
            this._Course.IsAvailable = this.ckb_IsAvailable.Checked;
            this._Course.HasExperiment = this.ckb_HasExperiment.Checked;
            this._Course.HasMooc = this.ckb_HasMooc.Checked;
            this._Course.FormativeAssessments =
                this.CheckedItemsToArray<string>(this.clb_FormativeAssessment);
            foreach (var control in this.gpb_CourseType.Controls)                       //遍历分组框中的控件集合；
            {
                RadioButton radioButton = control as RadioButton;                       //将控件转为单选按钮；
                if (radioButton.Checked)                                                //若单选按钮被选中；
                {
                    this._Course.Type = radioButton.Text;                               //则获取单选按钮的文本；
                    break;
                }
            }
            this.txb_CourseDescription.Text = this._Course.Description;
        }
    }
}
