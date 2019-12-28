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

        /// <summary>
        /// 准备控件；
        /// </summary>
        private void PrepareControls()
        {
            this.btn_Abort.CausesValidation = false;                                    //该按钮不引起验证；                         
            this.txb_CourseNumber.Validating += this.TextBox_Validating;                //订阅文本框验证期间事件；
            this.txb_CourseName.Validating += this.TextBox_Validating;
            this.txb_CourseNumber.KeyPress += this.txb_CourseNumber_KeyPress;           //订阅文本框按键敲击事件；
            this.txb_CourseCredit.TextChanged += this.txb_CourseCredit_TextChanged;     //订阅文本框文本更改事件；
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txb_CourseNumber = new System.Windows.Forms.TextBox();
            this.txb_CourseName = new System.Windows.Forms.TextBox();
            this.txb_CourseCredit = new System.Windows.Forms.TextBox();
            this.txb_CourseDescription = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Abort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_CourseNumber
            // 
            this.txb_CourseNumber.Location = new System.Drawing.Point(67, 17);
            this.txb_CourseNumber.Name = "txb_CourseNumber";
            this.txb_CourseNumber.Size = new System.Drawing.Size(195, 21);
            this.txb_CourseNumber.TabIndex = 0;
            // 
            // txb_CourseName
            // 
            this.txb_CourseName.Location = new System.Drawing.Point(67, 57);
            this.txb_CourseName.Name = "txb_CourseName";
            this.txb_CourseName.Size = new System.Drawing.Size(195, 21);
            this.txb_CourseName.TabIndex = 1;
            // 
            // txb_CourseCredit
            // 
            this.txb_CourseCredit.Location = new System.Drawing.Point(67, 97);
            this.txb_CourseCredit.Name = "txb_CourseCredit";
            this.txb_CourseCredit.Size = new System.Drawing.Size(195, 21);
            this.txb_CourseCredit.TabIndex = 2;
            // 
            // txb_CourseDescription
            // 
            this.txb_CourseDescription.Location = new System.Drawing.Point(67, 137);
            this.txb_CourseDescription.Multiline = true;
            this.txb_CourseDescription.Name = "txb_CourseDescription";
            this.txb_CourseDescription.Size = new System.Drawing.Size(195, 69);
            this.txb_CourseDescription.TabIndex = 3;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(67, 229);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 4;
            this.btn_Submit.Text = "提交";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Abort
            // 
            this.btn_Abort.Location = new System.Drawing.Point(187, 229);
            this.btn_Abort.Name = "btn_Abort";
            this.btn_Abort.Size = new System.Drawing.Size(75, 23);
            this.btn_Abort.TabIndex = 5;
            this.btn_Abort.Text = "放弃";
            this.btn_Abort.UseVisualStyleBackColor = true;
            this.btn_Abort.Click += new System.EventHandler(this.btn_Abort_Click);
            // 
            // frm_CourseManagement
            // 
            this.AcceptButton = this.btn_Submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Abort;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btn_Abort);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.txb_CourseDescription);
            this.Controls.Add(this.txb_CourseCredit);
            this.Controls.Add(this.txb_CourseName);
            this.Controls.Add(this.txb_CourseNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = Properties.Resources.Briefcase_16px;
            this.MaximizeBox = false;
            this.Name = "frm_CourseManagement";
            this.txb_CourseDescription.ReadOnly = true; 
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "课程管理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        [ValidationMapping("Course", "Number")]
        private System.Windows.Forms.TextBox txb_CourseNumber;
        [ValidationMapping("Course", "Name")]
        private System.Windows.Forms.TextBox txb_CourseName;
        private System.Windows.Forms.TextBox txb_CourseCredit;
        private System.Windows.Forms.TextBox txb_CourseDescription;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Abort;


    }
}

