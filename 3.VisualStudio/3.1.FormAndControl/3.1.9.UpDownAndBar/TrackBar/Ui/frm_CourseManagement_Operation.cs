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
            this._Course = CourseRepository.Get();
            this.txb_CourseNumber.Text = this._Course.Number;                                   //写入文本框文本； 
            this.txb_CourseName.Text = this._Course.Name;
            this.nud_CourseCredit.Value = this._Course.Credit;
            this.RefreshCourseHourDistribution(this.lbl_CourseHourDistribution);
            this.RefreshCourseTheoreticalHour(this.tkb_TheoreticalHour);
            this.txb_CourseDescription.Text = this._Course.Description;
            this.ckb_IsAvailable.Checked = this._Course.IsAvailable;                            //多选按钮的选中状态与逻辑类型的变量对应；                
            this.ckb_HasExperiment.Checked = this._Course.HasExperiment;
            this.ckb_HasMooc.Checked = this._Course.HasMooc;
            this.AddRangeWithCheckedItem
                (this.clb_FormativeAssessment
                , this._Course.FormativeAssessments
                , FormativeAssessment.All);
            this.rdb_IsProfessional.Checked =                                                   //单选按钮被选中后，同一组框中的其它单选按钮将不会被选中；
                (this.rdb_IsProfessional.Text == this._Course.Type);                            //根据单选按钮的文本与对象属性值是否一致，设置单选按钮是否被选中；
            this.rdb_IsPublic.Checked =
                (this.rdb_IsPublic.Text == this._Course.Type);
            this.rdb_IsCompulsory.Checked =
                (this.rdb_IsCompulsory.Text == this._Course.LearningType);
            this.rdb_IsOptional.Checked =
                (this.rdb_IsOptional.Text == this._Course.LearningType);
            this.lsb_CourseAppraisalType.Items.Clear();                                         //清空列表框的项目集合；
            this.lsb_CourseAppraisalType.Items.AddRange                                         //批量加入列表框的项目集合；
                (CourseAppraisalType.GetTypes());
            this.lsb_CourseAppraisalType.SelectedItem = this._Course.AppraisalType;             //设置列表框的选中项目；
            this.ListBoxLoadSubItems
                (this.lsb_CourseAppraisalType
                , this.lsb_CourseAppraisalForm
                , CourseAppraisalType.GetForms);
            this.lsb_CourseAppraisalForm.SelectedItem = this._Course.AppraisalForm;
        }
        /// <summary>
        /// 验证；
        /// </summary>
        /// <param name="textBox">文本框</param>
        private void Validate(TextBox textBox)
        {
            try
            {
                ValidationService.ValidateControl(this, textBox);                               //利用特性实现验证；
                textBox.Tag = true;                                                             //将验证结果写入文本框的标签；标签可接受object类型的对象；
            }
            catch (ApplicationException)
            {
                textBox.Tag = false;
                textBox.Focus();                                                                //文本框获得焦点；
                textBox.SelectAll();                                                            //文本框选中所有文本；
            }
            this.AfterValidate();
        }
        /// <summary>
        /// 验证；
        /// </summary>
        /// <param name="numericUpDown">数字增减框</param>
        private void Validate(NumericUpDown numericUpDown)
        {
            try
            {
                ValidationService.ValidateControl(this, numericUpDown);                         //利用特性实现验证；
            }
            catch (ApplicationException)
            {
                ;
            }
        }
        /// <summary>
        /// 验证按键；
        /// </summary>
        /// <param name="e">按键事件参数</param>
        private void ValidateKeyPress(KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)                           //若按键并非数字或退格键；
            {
                e.Handled = true;                                                               //不接收按键输入的字符；
            }
        }
        /// <summary>
        /// 验证后续；
        /// </summary>
        private void AfterValidate()
        {
            this.btn_Submit.Enabled =                                                           //若所有已验证文本框均无误，则启用提交按钮；
                (bool)this.txb_CourseNumber.Tag                                                 //获取所有已验证文本框的标签，并转为逻辑值；
                && (bool)this.txb_CourseName.Tag;
        }
        /// <summary>
        /// 刷新课程分配；
        /// </summary>
        /// <param name="control">控件</param>
        private void RefreshCourseHourDistribution(Control control)
        {
            control.Text = string.Format
                ("课时分配：理论课{0}节，实验课{1}节，共{2}节。"
                , this._Course.TheoreticalHour
                , this._Course.ExperimentalHour
                , this._Course.TotalHour);
        }
        /// <summary>
        /// 刷新理论课时；
        /// </summary>
        /// <param name="trackBar">滑动条</param>
        private void RefreshCourseTheoreticalHour(TrackBar trackBar)
        {
            trackBar.Minimum = 0;                                                               //设置滑动条最小值；
            trackBar.Maximum = this._Course.TotalHour;                                          //设置滑动条最大值；
            trackBar.SmallChange = 1;                                                           //设置滑动条滚动1段刻度所改变的值；
            trackBar.TickFrequency = this._Course.TotalHour / 8;                                //设置滑动条刻度数量；
            trackBar.Value = this._Course.TheoreticalHour;                                      //设置滑动条的值；
        }
        /// <summary>
        /// 包含应选中项目的批量添加；
        /// </summary>
        /// <param name="checkedListBox">多选列表框</param>
        /// <param name="selectedItems">应选中项目</param>
        /// <param name="allItems">所有项目</param>
        private void AddRangeWithCheckedItem(CheckedListBox checkedListBox,object[] selectedItems,object[] allItems)
        {
            checkedListBox.Items.Clear();                                                       //清空多选列表框中所有项目，以免重复添加；
            checkedListBox.Items.AddRange(selectedItems);                                       //批量添加应选中项目；
            for (int i = 0; i < checkedListBox.Items.Count; i++)                                //遍历多选列表框中所有项目（当前仅有应选中项目）；
            {
                checkedListBox.SetItemChecked(i, true);                                         //将各项目设为选中；
            }
            HashSet<object>                                                                     //将应选中项目、所有项目转为散列集；
                currentItemsHashSet = new HashSet<object>(selectedItems)
                , allItemsHashSet = new HashSet<object>(allItems);
            allItemsHashSet.ExceptWith(currentItemsHashSet);                                    //通过散列集的差集方法，获取剩余项目；
            object[] restItems = (new List<object>(allItemsHashSet)).ToArray();                 //将包含剩余项目的散列集（通过列表）转为数组；
            checkedListBox.Items.AddRange(restItems);                                           //批量添加剩余项目；
        }
        /// <summary>
        /// 多选列表框选中项目集合转为数组；
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="checkedItemCollection">选中项目集合</param>
        /// <returns>数组</returns>
        private T[] CheckedItemCollectionToArray<T>(CheckedListBox checkedListBox)
        {
            List<T> itemList = new List<T>();
            foreach (var item in checkedListBox.CheckedItems)                                   //遍历多选列表框中所有选中项目；
            {
                itemList.Add((T)item);                                                          //将项目加入列表；
            }
            return itemList.ToArray();                                                          //将列表转为数组；
        }
        /// <summary>
        /// 列表框载入子项目
        /// </summary>
        /// <param name="listBox">列表框</param>
        /// <param name="subListBox">子列表框</param>
        /// <param name="getSubItems">获取子项目</param>
        private void ListBoxLoadSubItems(ListBox listBox, ListBox subListBox, Func<string, string[]> getSubItems)
        {
            string selectedItem = listBox.SelectedItem.ToString();                              //获取列表框的选中项目的字符串；
            subListBox.Items.Clear();                                                           //清空子列表框的项目集合；
            subListBox.Items.AddRange(getSubItems(selectedItem));                               //获取子项目，批量加入子列表框的项目集合；
            subListBox.SelectedIndex = 0;                                                       //选中第1项项目；
        }
        /// <summary>
        /// 提交课程；
        /// </summary>
        private void SubmitCourse()
        {
            this._Course.Number = this.txb_CourseNumber.Text;                                   //读取文本框文本；        
            this._Course.Name = this.txb_CourseName.Text;
            this._Course.Credit = this.nud_CourseCredit.Value;
            this._Course.TheoreticalHour = this.tkb_TheoreticalHour.Value;
            this._Course.IsAvailable = this.ckb_IsAvailable.Checked;
            this._Course.HasExperiment = this.ckb_HasExperiment.Checked;
            this._Course.HasMooc = this.ckb_HasMooc.Checked;
            this._Course.FormativeAssessments = 
                this.CheckedItemCollectionToArray<string>(this.clb_FormativeAssessment);
            foreach (var control in this.gpb_CourseType.Controls)                               //遍历组框中的控件集合；
            {
                RadioButton radioButton=(RadioButton)control;                                   //将控件转为单选按钮；
                if (radioButton.Checked)                                                        //若单选按钮被选中；
                {
                    this._Course.Type = radioButton.Text;                                       //则获取单选按钮的文本；
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
