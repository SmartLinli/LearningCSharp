using System;
using System.Drawing;
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
        /// 设置字体样式；
        /// </summary>
        /// <param name="fontStyle">字体样式</param>
        private void SetFontStyle(FontStyle fontStyle)
        {
            Font currentFont = this.rtb_CourseSyllabus.SelectionFont;                           //获取富文本框选中文字的字体；
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
            this.rtb_CourseSyllabus.SelectionFont = currentFont;                                //设置富文本框选中文字的字体；
        }
        /// <summary>
        /// 粗体按钮点击；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Bold_Click(object sender, EventArgs e)
        {
            this.SetFontStyle(FontStyle.Bold);
        }
        /// <summary>
        /// 斜体按钮点击；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Italic_Click(object sender, EventArgs e)
        {
            this.SetFontStyle(FontStyle.Italic);
        }
        /// <summary>
        /// 下划线按钮点击；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Underlined_Click(object sender, EventArgs e)
        {
            this.SetFontStyle(FontStyle.Underline);
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
            this.rtb_CourseSyllabus.Rtf = this._Course.Syllabus;                                //设置富文本框的格式化文本；
        }
        /// <summary>
        /// 提交按钮点击；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            this._Course.Syllabus = this.rtb_CourseSyllabus.Rtf;                                //获取富文本框的格式化文本；
            this.txb_CourseDescription.Text = this._Course.Description;
            MessageBox.Show("课程已提交"); 
        }
    }
}
