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
            this.nud_CourseCredit.DataBindings.Clear();                                         //清空控件的数据绑定项；
            this.nud_CourseCredit.DataBindings.Add                                              //向控件的数据绑定项添加绑定项，并分别指定控件属性名称、对象、对象属性名称，从而实现双向更改；
                ("Value", this._Course, "Credit");                                              //若该属性更改时，相应更改其它属性，可在该属性中触发PropertyChanged事件（类还需实现INotifyPropertyChanged接口），从而实现其它属性在控件中的同步更改；
            this.lbl_CourseHourDistribution.DataBindings.Clear();
            this.lbl_CourseHourDistribution.DataBindings.Add
                ("Text", this._Course, "CourseHourDistribution");
            this.tkb_TheoreticalHour.DataBindings.Clear();
            this.tkb_TheoreticalHour.DataBindings.Add
                ("Maximum", this._Course, "TotalHour");
            this.tkb_TheoreticalHour.DataBindings.Add
                ("Value", this._Course, "TheoreticalHour");
            this.txb_CourseDescription.Text = this._Course.Description;
            this.ckb_IsAvailable.Checked = this._Course.IsAvailable;                           
            this.ckb_HasExperiment.Checked = this._Course.HasExperiment;
            this.ckb_HasMooc.Checked = this._Course.HasMooc;
            this.AddRangeWithCheckedItem
                (this.clb_FormativeAssessment,
                 this._Course.FormativeAssessments,
                 CourseService.GetAllFormativeAssessment);
            this.rdb_IsProfessional.Checked =                                                  
                (this.rdb_IsProfessional.Text == this._Course.Type);                           
            this.rdb_IsPublic.Checked =
                (this.rdb_IsPublic.Text == this._Course.Type);
            this.rdb_IsCompulsory.Checked =
                (this.rdb_IsCompulsory.Text == this._Course.LearningType);
            this.rdb_IsOptional.Checked =
                (this.rdb_IsOptional.Text == this._Course.LearningType);
            this.lsb_CourseAppraisalType.Items.Clear();                                        
            this.lsb_CourseAppraisalType.Items.AddRange                                        
                (CourseAppraisalType.GetAllTypes());
            this.lsb_CourseAppraisalType.SelectedItem = this._Course.AppraisalType;
            this.ListBoxLoadSubItems
                (this.lsb_CourseAppraisalType,
                 this.lsb_CourseAppraisalForm,
                 CourseAppraisalType.GetAllForms);
            this.lsb_CourseAppraisalForm.SelectedItem = this._Course.AppraisalForm;
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
            this.nud_CourseCredit.Minimum = CourseService.MinCredit;
            this.nud_CourseCredit.Maximum = CourseService.MaxCredit;
            this.nud_CourseCredit.Increment = 0.5m;
            this.tkb_TheoreticalHour.SmallChange = 8;                                   
            this.tkb_TheoreticalHour.TickFrequency = 8;                                 
            this._ErrorMessageLabels = new Dictionary<string, Label>();
            this._ErrorMessageLabels.Add(this.txb_CourseNumber.AccessibleName, this.lbl_CourseNumberError);
            this._ErrorMessageLabels.Add(this.txb_CourseName.AccessibleName, this.lbl_CourseNameError);
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
        /// 验证后续；
        /// </summary>
        private void AfterValidate()
        {
            this.btn_Submit.Enabled =                                                           
                (bool)this.txb_CourseNumber.Tag                                                 
                && (bool)this.txb_CourseName.Tag;
        }
        /// <summary>
        /// 绑定项写回值；
        /// </summary>
        /// <param name="obj">控件</param>
        /// <param name="propertyName">绑定项名称</param>
        private void BindingWriteValue(object obj, string bindingName)
        {
            Control control = obj as Control;
            Binding binding = control.DataBindings[bindingName];                                //获取控件的数据绑定项中的指定绑定项；
            if (binding != null)
            {
                binding.WriteValue();                                                           //绑定项向对象写回值；
            }
        }
        /// <summary>
        /// 向多选列表框批量添加项目，并选中指定的项目；
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
        /// 列表框载入子项目
        /// </summary>
        /// <param name="listBox">列表框</param>
        /// <param name="subListBox">子列表框</param>
        /// <param name="getSubItems">获取子项目</param>
        private void ListBoxLoadSubItems(ListBox listBox, ListBox subListBox, Func<string, string[]> getSubItems)
        {
            string selectedItem = listBox.SelectedItem.ToString();
            subListBox.Items.Clear();
            subListBox.Items.AddRange(getSubItems(selectedItem));
            subListBox.SelectedIndex = 0;
        }
        /// <summary>
        /// 提交课程；
        /// </summary>
        private void SubmitCourse()
        {
            this._Course.Number = this.txb_CourseNumber.Text;                                   
            this._Course.Name = this.txb_CourseName.Text;
            this._Course.IsAvailable = this.ckb_IsAvailable.Checked;
            this._Course.HasExperiment = this.ckb_HasExperiment.Checked;
            this._Course.HasMooc = this.ckb_HasMooc.Checked;
            this._Course.FormativeAssessments = 
                this.CheckedItemsToArray<string>(this.clb_FormativeAssessment);
            foreach (var control in this.gpb_CourseType.Controls)                               
            {
                RadioButton radioButton=(RadioButton)control;                                   
                if (radioButton.Checked)                                                        
                {
                    this._Course.Type = radioButton.Text;                                       
                    break;
                }
            }
            this._Course.AppraisalType = 
                lsb_CourseAppraisalType.SelectedItem.ToString();                    
            this._Course.AppraisalForm = 
                lsb_CourseAppraisalForm.SelectedItem.ToString();            
            this.txb_CourseDescription.Text = this._Course.Description;
        }
    }
}
