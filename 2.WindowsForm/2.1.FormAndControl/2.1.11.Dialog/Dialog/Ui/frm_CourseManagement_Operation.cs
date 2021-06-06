using System;
using System.Collections.Generic;
using System.Drawing;
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
            this.nud_CourseCredit.DataBindings.Clear();                                         
            this.nud_CourseCredit.DataBindings.Add                                              
                ("Value", this._Course, "Credit");                                              
            this.lbl_CourseHourDistribution.DataBindings.Clear();
            this.lbl_CourseHourDistribution.DataBindings.Add(
                "Text", this._Course, "CourseHourDistribution");
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
            Binding binding = control.DataBindings[bindingName];
            if (binding != null)
            {
                binding.WriteValue();
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
        /// 重绘工具栏
        /// </summary>
        /// <param name="toolStrip">工具栏</param>
        /// <param name="e">绘制事件参数</param>
        private void RepaintToolStrip(ToolStrip toolStrip, PaintEventArgs e)
        {
            int newHeight = 0;                                                                  //定义重绘区域的新高度，其高度比工具栏少1～2像素，以便消除工具栏底部边框；
            switch (toolStrip.RenderMode)
            {
                case ToolStripRenderMode.Custom: return;
                case ToolStripRenderMode.ManagerRenderMode:                                     //若工具栏渲染模式为默认或专业；
                case ToolStripRenderMode.Professional:
                    {
                        newHeight = toolStrip.Height - 1;                                       //新高度比工具栏少1像素；
                    }
                    break;
                case ToolStripRenderMode.System:                                                //若工具栏渲染模式为系统；
                    {
                        newHeight = toolStrip.Height - 2;                                       //新高度比工具栏少2像素；
                    }
                    break;
                default:
                    break;
            }
            Rectangle rectangle = new Rectangle(0, 0, toolStrip.Width, newHeight - 2);          //定义矩形，并使用新高度；
            e.Graphics.SetClip(rectangle);                                                      //将矩形设为绘制图形的剪辑区域；
        }
        /// <summary>
        /// 设置字体风格；
        /// </summary>
        /// <param name="richTextBox">富文本框</param>
        public void SetFontStyle(RichTextBox richTextBox, FontStyle fontStyle)
        {
            Font currentFont = richTextBox.SelectionFont;                                       
            if (currentFont == null)                                                            
            {
                return;
            }
            bool currentFontHasFontStyle =                                                      
                Convert.ToBoolean((int)(currentFont.Style & fontStyle));                        
            if (currentFontHasFontStyle)                                                        
            {
                currentFont = new Font(currentFont, currentFont.Style & ~fontStyle);            
            }
            else
            {
                currentFont = new Font(currentFont, currentFont.Style | fontStyle);             
            }
            richTextBox.SelectionFont = currentFont;                                            
        }
        /// <summary>
        /// 设置字体颜色；
        /// </summary>
        /// <param name="richTextBox">富文本框</param>
        private void SetFontColor(RichTextBox richTextBox)
        {
            ColorDialog colorDialog = new ColorDialog();                                        //定义颜色对话框；
            colorDialog.FullOpen = true;                                                        //完整模式的颜色对话框提供自定义颜色功能；
            if (colorDialog.ShowDialog() == DialogResult.OK)                                    //打开颜色对话框，并判断对话框操作结果是否为点击OK按钮；
            {
                richTextBox.SelectionColor = colorDialog.Color;                                 //将富文本框的选中文字颜色设为颜色对话框选定的颜色；
            }
        }
        /// <summary>
        /// 设置字体；
        /// </summary>
        /// <param name="richTextBox">富文本框</param>
        private void SetFont(RichTextBox richTextBox)
        {
            FontDialog fontDialog = new FontDialog();                                           //定义字体对话框；
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SelectionFont = fontDialog.Font;                                    //获取字体对话框选定的字体；
            }
        }
        /// <summary>
        /// 打开富文本格式文件；
        /// </summary>
        /// <param name="richTextBox">富文本框</param>
        private void OpenRtfFile(RichTextBox richTextBox)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();                               //定义打开文件对话框；
            openFileDialog.Title = "打开富文本文件";                                             //设置打开文件对话框标题；
            openFileDialog.InitialDirectory =                                                   //设置打开文件对话框初始路径；
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);               //获取“我的文档”的路径；
            openFileDialog.Filter = "富文本格式（*.rtf）|*.rtf";                                 //设置打开文件对话框的文件格式过滤器；
            openFileDialog.FileName =                                                           //设置打开文件对话框的初始文件名；
                $"{this._Course.Number}《{this._Course.Name}》教学大纲";
            openFileDialog.DefaultExt = "rtf";                                                  //设置打开文件对话框的默认扩展名；
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;                                      //获取打开文件对话框选定的文件名；
                richTextBox.LoadFile(fileName);                                                 //富文本框根据指定文件名载入文件；
            }
        }
        /// <summary>
        /// 保存富文本格式文件；
        /// </summary>
        /// <param name="richTextBox">富文本框</param>
        private void SaveRtfFile(RichTextBox richTextBox)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "保存富文本格式文件";
            saveFileDialog.InitialDirectory =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog.Filter = "富文本格式（*.rtf）|*.rtf";
            saveFileDialog.FileName = $"{this._Course.Number}《{this._Course.Name}》教学大纲";
            saveFileDialog.DefaultExt = "rtf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                richTextBox.SaveFile(fileName);                                                 //富文本框根据指定文件名保存文件；
            }
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
                RadioButton radioButton = (RadioButton)control;                                 
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
