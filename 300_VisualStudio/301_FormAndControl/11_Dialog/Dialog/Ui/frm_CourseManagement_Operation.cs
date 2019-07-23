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
            this.nud_CourseCredit.DataBindings.Clear();                                         //清空控件的数据绑定项；
            this.nud_CourseCredit.DataBindings.Add                                              //向控件的数据绑定项添加绑定项，并分别指定控件属性名称、对象、对象属性名称，从而实现双向更改；
                ("Value", this._Course, "Credit");                                              //若该属性更改时，相应更改其它属性，可在该属性中触发PropertyChanged事件（类还需实现INotifyPropertyChanged接口），从而实现其它属性在控件中的同步更改；
            this.lbl_CourseHourDistribution.DataBindings.Clear();
            this.lbl_CourseHourDistribution.DataBindings.Add(
                "Text", this._Course, "CourseHourDistribution");
            this.tkb_TheoreticalHour.DataBindings.Clear();
            this.tkb_TheoreticalHour.DataBindings.Add
                ("Maximum", this._Course, "TotalHour");
            this.tkb_TheoreticalHour.DataBindings.Add
                ("Value", this._Course, "TheoreticalHour");
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
        /// 包含应选中项目的批量添加；
        /// </summary>
        /// <param name="checkedListBox">多选列表框</param>
        /// <param name="selectedItems">应选中项目</param>
        /// <param name="allItems">所有项目</param>
        private void AddRangeWithCheckedItem(CheckedListBox checkedListBox, object[] selectedItems, object[] allItems)
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
            Font currentFont = richTextBox.SelectionFont;                                       //获取富文本框选中文字的字体；
            if (currentFont == null)                                                            //若未选中文字；
            {
                return;
            }
            bool currentFontHasFontStyle =                                                      //通过位运算，判断当前字体是否包含指定的字体风格；
                Convert.ToBoolean((int)(currentFont.Style & fontStyle));                        //字体风格枚举值均为2的整数次方，便于通过位运算进行字体风格的操作；
            if (currentFontHasFontStyle)                                                        //若当前字体已包含指定的字体风格；
            {
                currentFont = new Font(currentFont, currentFont.Style & ~fontStyle);            //去除指定的字体风格；
            }
            else
            {
                currentFont = new Font(currentFont, currentFont.Style | fontStyle);             //加入指定的字体风格；
            }
            richTextBox.SelectionFont = currentFont;                                            //设置富文本框选中文字的字体；
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
            openFileDialog.Title = "打开富文本格式文件";                                        //设置打开文件对话框标题；
            openFileDialog.InitialDirectory =                                                   //设置打开文件对话框初始路径；
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);               //获取“我的文档”的路径；
            openFileDialog.Filter = "富文本格式（*.rtf）|*.rtf";                                //设置打开文件对话框的文件格式过滤器；
            openFileDialog.FileName = string.Format                                             //设置打开文件对话框的初始文件名；
                ("{0}《{1}》教学大纲"
                , this._Course.Number
                , this._Course.Name);
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
            saveFileDialog.FileName = string.Format
                ("{0}《{1}》教学大纲"
                , this._Course.Number
                , this._Course.Name);
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
            this._Course.Number = this.txb_CourseNumber.Text;                                   //读取文本框文本；        
            this._Course.Name = this.txb_CourseName.Text;
            this._Course.IsAvailable = this.ckb_IsAvailable.Checked;
            this._Course.HasExperiment = this.ckb_HasExperiment.Checked;
            this._Course.HasMooc = this.ckb_HasMooc.Checked;
            this._Course.FormativeAssessments =
                this.CheckedItemCollectionToArray<string>(this.clb_FormativeAssessment);
            foreach (var control in this.gpb_CourseType.Controls)                               //遍历组框中的控件集合；
            {
                RadioButton radioButton = (RadioButton)control;                                 //将控件转为单选按钮；
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
