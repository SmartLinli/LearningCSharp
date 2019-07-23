using System;
using System.Windows.Forms;

namespace SmartLin.LearningCSharp.FormAndControl
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();

        }
        /// <summary>
        /// 学生菜单项点击；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_Student_Click(object sender, EventArgs e)
        {
            frm_StudentManagement studentManagement = new frm_StudentManagement();          //定义窗体；
            studentManagement.MdiParent = this;                                             //窗体的多文档界面父窗体设为主窗体；
            studentManagement.StartPosition = FormStartPosition.CenterScreen;               //窗体的启动位置设为屏幕中央；
            studentManagement.WindowState = FormWindowState.Normal;                         //窗体的窗口模式设为正常；
            studentManagement.Show();                                                       //显示窗体；
        }
        /// <summary>
        /// 课程菜单项点击；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsm_Course_Click(object sender, EventArgs e)
        {
            frm_CourseManagement courseManagement = new frm_CourseManagement();
            courseManagement.MdiParent = this;
            courseManagement.StartPosition = FormStartPosition.CenterScreen;
            courseManagement.WindowState = FormWindowState.Normal;
            courseManagement.Show();
        }
    }
}
