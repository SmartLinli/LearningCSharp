using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SmartLin.LearningCSharp.FormAndControl
{
    /// <summary>
    /// 课程管理窗体；
    /// </summary>
    public partial class frm_CourseManagement : Form
    {
        /// <summary>
        /// 课程；
        /// </summary>
        private Course _Course;
        /// <summary>
        /// 构造函数；
        /// </summary>
        public frm_CourseManagement()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 载入形成性评价；
        /// </summary>
        private void LoadFormativeAssessments()
        {
            this.clb_FormativeAssessment.Items.Clear();                                             //清空多选列表框中所有项目，以免重复添加；
            this.clb_FormativeAssessment.Items.AddRange(this._Course.FormativeAssessments);         //批量添加应选中项目；
            for (int i = 0; i < this.clb_FormativeAssessment.Items.Count; i++)                      //遍历多选列表框中所有项目（当前仅有应选中项目）；
            {
                this.clb_FormativeAssessment.SetItemChecked(i, true);                               //将各项目设为选中；
            }
            HashSet<string>                                                                         //将应选中项目、所有项目转为散列集；
                currentItemsHashSet = new HashSet<string>(this._Course.FormativeAssessments)
                , allItemsHashSet = new HashSet<string>(CourseService.GetAllFormativeAssessments);
            allItemsHashSet.ExceptWith(currentItemsHashSet);                                        //通过散列集的差集方法，获取剩余项目；
            object[] restItems = (new List<string>(allItemsHashSet)).ToArray();                     //将包含剩余项目的散列集（通过列表）转为数组；
            this.clb_FormativeAssessment.Items.AddRange(restItems);                                 //批量添加剩余项目；
        }
        /// <summary>
        /// 保存形成性评价；
        /// </summary>
        /// <returns></returns>
        private void SaveFormativeAssessments()
        {
            List<string> itemList = new List<string>();
            foreach (var item in this.clb_FormativeAssessment.CheckedItems)                         //遍历多选列表框中所有选中项目；
            {
                itemList.Add(item.ToString());                                                      //将项目加入列表；
            }
            this._Course.FormativeAssessments = itemList.ToArray();                                                              //将列表转为数组；
        }
        /// <summary>
        /// 载入按钮点击；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Load_Click(object sender, EventArgs e)
        {
            this._Course = CourseRepository.Find("2060316");
            this.txb_CourseDescription.Text = this._Course.Description;
            this.LoadFormativeAssessments();
        }
        /// <summary>
        /// 提交按钮点击；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            this.SaveFormativeAssessments();
            this.txb_CourseDescription.Text = this._Course.Description;
            MessageBox.Show("课程已提交");
        }
    }
}
