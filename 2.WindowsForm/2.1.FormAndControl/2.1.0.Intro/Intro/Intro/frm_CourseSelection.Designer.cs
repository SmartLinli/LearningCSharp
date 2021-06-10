namespace Intro
{
    partial class frm_CourseSelection
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_CourseName = new System.Windows.Forms.Label();
            this.txb_CourseName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(136, 68);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 0;
            this.btn_Submit.Text = "提交";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lbl_CourseName
            // 
            this.lbl_CourseName.AutoSize = true;
            this.lbl_CourseName.Location = new System.Drawing.Point(29, 28);
            this.lbl_CourseName.Name = "lbl_CourseName";
            this.lbl_CourseName.Size = new System.Drawing.Size(101, 12);
            this.lbl_CourseName.TabIndex = 1;
            this.lbl_CourseName.Text = "请输入课程名称：";
            // 
            // txb_CourseName
            // 
            this.txb_CourseName.Location = new System.Drawing.Point(136, 25);
            this.txb_CourseName.Name = "txb_CourseName";
            this.txb_CourseName.Size = new System.Drawing.Size(134, 21);
            this.txb_CourseName.TabIndex = 2;
            // 
            // frm_CourseSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 117);
            this.Controls.Add(this.txb_CourseName);
            this.Controls.Add(this.lbl_CourseName);
            this.Controls.Add(this.btn_Submit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_CourseSelection";
            this.Text = "课程选修";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_CourseName;
        private System.Windows.Forms.TextBox txb_CourseName;
    }
}

