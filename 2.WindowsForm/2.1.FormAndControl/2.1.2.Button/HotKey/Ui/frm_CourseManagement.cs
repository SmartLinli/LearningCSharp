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
        /// 在课程管理窗体中按下按键；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_CourseManagement_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)                                                              //若按住Ctrl键；
            {
                switch (e.KeyCode)                                                      //进一步判断按键；
                {
                    case Keys.L:                                                        //若按键为Ctrl+L；
                        {
                            this.btn_Load.PerformClick();                               //触发相应按钮的点击事件；
                        }
                        break;
                    case Keys.S:
                        {
                            this.btn_Submit.PerformClick();
                        }
                        break;
                    default:
                        break;
                }
            };
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        public frm_CourseManagement()
        {
            InitializeComponent();
            this.AcceptButton = this.btn_Submit;                                        //设置按下回车键时点击的按钮；该功能仅在焦点处于非按钮控件时生效；若焦点处于其它按钮，则按下回车键只能点击其它按钮；
            this.KeyDown += this.frm_CourseManagement_KeyDown;                          //注册（订阅）课程管理窗体的按下按键事件；
        }
        /// <summary>
        /// 点击载入按钮；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Load_Click(object sender, EventArgs e)
        {
            this._Course = CourseRepository.Find("2060316");
            MessageBox.Show($"已载入《{this._Course.Name}》。");
        }
        /// <summary>
        /// 点击提交按钮；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"已提交《{this._Course.Name}》。");
        }
    }
}
