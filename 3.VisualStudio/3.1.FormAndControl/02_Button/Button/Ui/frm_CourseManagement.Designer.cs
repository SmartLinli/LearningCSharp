namespace SmartLin.LearningCSharp.FormAndControl
{
    partial class frm_CourseManagement
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
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Modify = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Abort = new System.Windows.Forms.Button();
            this.btn_CurrentCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Previous
            // 
            this.btn_Previous.Location = new System.Drawing.Point(25, 25);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(75, 25);
            this.btn_Previous.TabIndex = 0;
            this.btn_Previous.Text = "上一条";
            this.btn_Previous.UseVisualStyleBackColor = true;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(225, 25);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 25);
            this.btn_Next.TabIndex = 0;
            this.btn_Next.TabStop = false;
            this.btn_Next.Text = "下一条";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Modify
            // 
            this.btn_Modify.Location = new System.Drawing.Point(25, 175);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(75, 25);
            this.btn_Modify.TabIndex = 0;
            this.btn_Modify.Text = "修改(&M)";
            this.btn_Modify.UseVisualStyleBackColor = true;
            this.btn_Modify.Click += new System.EventHandler(this.btn_Modify_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(125, 175);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 25);
            this.btn_Submit.TabIndex = 1;
            this.btn_Submit.Text = "提交";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Abort
            // 
            this.btn_Abort.Location = new System.Drawing.Point(225, 175);
            this.btn_Abort.Name = "btn_Abort";
            this.btn_Abort.Size = new System.Drawing.Size(75, 25);
            this.btn_Abort.TabIndex = 2;
            this.btn_Abort.Text = "放弃";
            this.btn_Abort.UseVisualStyleBackColor = true;
            this.btn_Abort.Click += new System.EventHandler(this.btn_Abort_Click);
            // 
            // btn_CurrentCourse
            // 
            this.btn_CurrentCourse.Location = new System.Drawing.Point(125, 25);
            this.btn_CurrentCourse.Name = "btn_CurrentCourse";
            this.btn_CurrentCourse.Size = new System.Drawing.Size(75, 25);
            this.btn_CurrentCourse.TabIndex = 0;
            this.btn_CurrentCourse.TabStop = false;
            this.btn_CurrentCourse.Text = "当前课程";
            this.btn_CurrentCourse.UseVisualStyleBackColor = true;
            // 
            // frm_CourseManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 225);
            this.Controls.Add(this.btn_CurrentCourse);
            this.Controls.Add(this.btn_Abort);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_Modify);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Previous);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::SmartLin.LearningCSharp.FormAndControl.Properties.Resources.Briefcase_16px;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frm_CourseManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "课程管理";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Modify;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Abort;
        private System.Windows.Forms.Button btn_CurrentCourse;
    }
}

