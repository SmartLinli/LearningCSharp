using System;
using System.Drawing;
using System.IO;
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
        /// 点击颜色按钮；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Color_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();                                        //定义颜色对话框；
            colorDialog.FullOpen = true;                                                        //完整模式的颜色对话框提供自定义颜色功能；
            if (colorDialog.ShowDialog() == DialogResult.OK)                                    //打开颜色对话框，并判断对话框操作结果是否为点击OK按钮；
            {
                this.rtb_CourseSyllabus.SelectionColor = colorDialog.Color;                     //将富文本框的选中文字颜色设为颜色对话框选定的颜色；
            }
        }
        /// <summary>
        /// 点击字体按钮；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Font_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();                                           //定义字体对话框；
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                this.rtb_CourseSyllabus.SelectionFont = fontDialog.Font;                        //获取字体对话框选定的字体；
            }
        }
        /// <summary>
        /// 点击打开按钮；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OpenRtf_Click(object sender, EventArgs e)
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
                this.rtb_CourseSyllabus.LoadFile(fileName);                                     //富文本框根据指定文件名载入文件；
            }
        }
        /// <summary>
        /// 点击保存按钮；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SaveRtf_Click(object sender, EventArgs e)
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
                this.rtb_CourseSyllabus.SaveFile(fileName);                                     //富文本框根据指定文件名保存文件；
            }
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
            this.rtb_CourseSyllabus.Rtf = this._Course.Syllabus;                                
        }
        /// <summary>
        /// 提交按钮点击；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            this._Course.Syllabus = this.rtb_CourseSyllabus.Rtf;                                
            this.txb_CourseDescription.Text = this._Course.Description;
            MessageBox.Show("课程已提交");
        }
    }
}
