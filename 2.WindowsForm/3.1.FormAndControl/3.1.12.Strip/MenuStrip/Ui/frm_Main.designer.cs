using System.Windows.Forms;

namespace SmartLin.LearningCSharp.FormAndControl
{
    partial class frm_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ms_MainMenu = new System.Windows.Forms.MenuStrip();
            this.tsm_EducationUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Department = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Major = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Class = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_EducationObject = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Course = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Student = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Classroom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_TeachingOperating = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Examination = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Evaluation = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_MainMenu
            // 
            this.ms_MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_EducationUnit,
            this.tsm_EducationObject,
            this.tsm_TeachingOperating});
            this.ms_MainMenu.Location = new System.Drawing.Point(0, 0);
            this.ms_MainMenu.Name = "ms_MainMenu";
            this.ms_MainMenu.Size = new System.Drawing.Size(714, 24);
            this.ms_MainMenu.TabIndex = 0;
            this.ms_MainMenu.Text = "主菜单";
            // 
            // tsm_EducationUnit
            // 
            this.tsm_EducationUnit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Department,
            this.tsm_Major,
            this.tsm_Class});
            this.tsm_EducationUnit.Name = "tsm_EducationUnit";
            this.tsm_EducationUnit.Size = new System.Drawing.Size(65, 20);
            this.tsm_EducationUnit.Text = "教学单位";
            // 
            // tsm_Department
            // 
            this.tsm_Department.Name = "tsm_Department";
            this.tsm_Department.Size = new System.Drawing.Size(94, 22);
            this.tsm_Department.Text = "院系";
            // 
            // tsm_Major
            // 
            this.tsm_Major.Name = "tsm_Major";
            this.tsm_Major.Size = new System.Drawing.Size(94, 22);
            this.tsm_Major.Text = "专业";
            // 
            // tsm_Class
            // 
            this.tsm_Class.Name = "tsm_Class";
            this.tsm_Class.Size = new System.Drawing.Size(94, 22);
            this.tsm_Class.Text = "班级";
            // 
            // tsm_EducationObject
            // 
            this.tsm_EducationObject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Course,
            this.tsm_Student,
            this.tsm_Classroom});
            this.tsm_EducationObject.Name = "tsm_EducationObject";
            this.tsm_EducationObject.Size = new System.Drawing.Size(65, 20);
            this.tsm_EducationObject.Text = "教学对象";
            // 
            // tsm_Course
            // 
            this.tsm_Course.Name = "tsm_Course";
            this.tsm_Course.Size = new System.Drawing.Size(152, 22);
            this.tsm_Course.Text = "课程";
            this.tsm_Course.Click += new System.EventHandler(this.tsm_Course_Click);
            // 
            // tsm_Student
            // 
            this.tsm_Student.Name = "tsm_Student";
            this.tsm_Student.Size = new System.Drawing.Size(152, 22);
            this.tsm_Student.Text = "学生";
            this.tsm_Student.Click += new System.EventHandler(this.tsm_Student_Click);
            // 
            // tsm_Classroom
            // 
            this.tsm_Classroom.Name = "tsm_Classroom";
            this.tsm_Classroom.Size = new System.Drawing.Size(152, 22);
            this.tsm_Classroom.Text = "教室";
            // 
            // tsm_TeachingOperating
            // 
            this.tsm_TeachingOperating.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Examination,
            this.tsm_Evaluation});
            this.tsm_TeachingOperating.Name = "tsm_TeachingOperating";
            this.tsm_TeachingOperating.Size = new System.Drawing.Size(65, 20);
            this.tsm_TeachingOperating.Text = "教学运行";
            // 
            // tsm_Examination
            // 
            this.tsm_Examination.Name = "tsm_Examination";
            this.tsm_Examination.Size = new System.Drawing.Size(94, 22);
            this.tsm_Examination.Text = "考务";
            // 
            // tsm_Evaluation
            // 
            this.tsm_Evaluation.Name = "tsm_Evaluation";
            this.tsm_Evaluation.Size = new System.Drawing.Size(94, 22);
            this.tsm_Evaluation.Text = "评教";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 441);
            this.Controls.Add(this.ms_MainMenu);
            this.MainMenuStrip = this.ms_MainMenu;
            this.Name = "frm_Main";
            this.Text = "主界面";
            this.ms_MainMenu.ResumeLayout(false);
            this.ms_MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_MainMenu;
        private System.Windows.Forms.ToolStripMenuItem tsm_EducationUnit;
        private System.Windows.Forms.ToolStripMenuItem tsm_Department;
        private System.Windows.Forms.ToolStripMenuItem tsm_Major;
        private System.Windows.Forms.ToolStripMenuItem tsm_Class;
        private System.Windows.Forms.ToolStripMenuItem tsm_TeachingOperating;
        private System.Windows.Forms.ToolStripMenuItem tsm_EducationObject;
        private System.Windows.Forms.ToolStripMenuItem tsm_Course;
        private System.Windows.Forms.ToolStripMenuItem tsm_Student;
        private System.Windows.Forms.ToolStripMenuItem tsm_Classroom;
        private System.Windows.Forms.ToolStripMenuItem tsm_Examination;
        private System.Windows.Forms.ToolStripMenuItem tsm_Evaluation;
    }
}

