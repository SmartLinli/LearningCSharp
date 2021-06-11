using System;
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
        /// 点击载入按钮；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Load_Click(object sender, EventArgs e)
        {
            if (this._Course == null)
            {
                this._Course = CourseRepository.Find("2060316");
                MessageBox.Show($"已载入《{this._Course.Name}》。修改课程信息后请及时提交。");
                return;
            }
            DialogResult messageboxResult =                                                 //定义对话框操作结果，用于接收消息框操作结果；
                MessageBox.Show                                                             //消息框的Show方法除了显示消息框，还能在用户完成对消息框的操作后，返回消息框操作结果；
                ("即将重新载入课程，请确认先前的修改均已提交！",
                 "警告",
                 MessageBoxButtons.YesNo,                                                   //消息框按钮；
                 MessageBoxIcon.Warning);                                                   //消息框图标；
            if (messageboxResult == DialogResult.Yes)                                       //若消息框操作结果为是；
            {
                MessageBox.Show
                    ($"已重新载入《{this._Course.Name}》。",
                     "消息",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// 点击提交按钮；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            DialogResult messageboxResult =                                                 
                MessageBox.Show                                                             
                ("您确定要提交吗？",
                 "提示",
                 MessageBoxButtons.YesNo,                                                   
                 MessageBoxIcon.Question);                                                 
            if (messageboxResult == DialogResult.Yes)                                       
            {
                MessageBox.Show
                    ($"已提交《{this._Course.Name}》",
                    "消息",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}