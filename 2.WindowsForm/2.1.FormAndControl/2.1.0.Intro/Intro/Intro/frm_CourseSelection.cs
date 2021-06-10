using System;
using System.Windows.Forms;

namespace Intro
{
    public partial class frm_CourseSelection : Form
    {
        public frm_CourseSelection()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string courseName = this.txb_CourseName.Text;
            MessageBox.Show($"您已成功选修《{courseName}》。");
        }
    }
}
