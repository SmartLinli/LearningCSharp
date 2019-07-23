﻿namespace SmartLin.LearningCSharp.FormAndControl
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
            this.lbl_CourseNumber = new System.Windows.Forms.Label();
            this.lbl_CourseName = new System.Windows.Forms.Label();
            this.lbl_CourseCredit = new System.Windows.Forms.Label();
            this.lbl_CourseDescription = new System.Windows.Forms.Label();
            this.lbl_CourseNumberError = new System.Windows.Forms.Label();
            this.lbl_CourseNameError = new System.Windows.Forms.Label();
            this.lbl_CourseCreditError = new System.Windows.Forms.Label();
            this.txb_CourseNumber = new System.Windows.Forms.TextBox();
            this.txb_CourseName = new System.Windows.Forms.TextBox();
            this.txb_CourseCredit = new System.Windows.Forms.TextBox();
            this.txb_CourseDescription = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Abort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_CourseNumber
            // 
            this.lbl_CourseNumber.AutoSize = true;
            this.lbl_CourseNumber.Location = new System.Drawing.Point(20, 20);
            this.lbl_CourseNumber.Name = "lbl_CourseNumber";
            this.lbl_CourseNumber.Size = new System.Drawing.Size(41, 12);
            this.lbl_CourseNumber.TabIndex = 0;
            this.lbl_CourseNumber.Text = "编号：";
            // 
            // lbl_CourseName
            // 
            this.lbl_CourseName.AutoSize = true;
            this.lbl_CourseName.Location = new System.Drawing.Point(20, 67);
            this.lbl_CourseName.Name = "lbl_CourseName";
            this.lbl_CourseName.Size = new System.Drawing.Size(41, 12);
            this.lbl_CourseName.TabIndex = 0;
            this.lbl_CourseName.Text = "名称：";
            // 
            // lbl_CourseCredit
            // 
            this.lbl_CourseCredit.AutoSize = true;
            this.lbl_CourseCredit.Location = new System.Drawing.Point(20, 114);
            this.lbl_CourseCredit.Name = "lbl_CourseCredit";
            this.lbl_CourseCredit.Size = new System.Drawing.Size(41, 12);
            this.lbl_CourseCredit.TabIndex = 0;
            this.lbl_CourseCredit.Text = "学分：";
            // 
            // lbl_CourseDescription
            // 
            this.lbl_CourseDescription.AutoSize = true;
            this.lbl_CourseDescription.Location = new System.Drawing.Point(20, 161);
            this.lbl_CourseDescription.Name = "lbl_CourseDescription";
            this.lbl_CourseDescription.Size = new System.Drawing.Size(41, 12);
            this.lbl_CourseDescription.TabIndex = 0;
            this.lbl_CourseDescription.Text = "描述：";
            // 
            // lbl_CourseNumberError
            // 
            this.lbl_CourseNumberError.AutoSize = true;
            this.lbl_CourseNumberError.ForeColor = System.Drawing.Color.Red;
            this.lbl_CourseNumberError.Location = new System.Drawing.Point(65, 45);
            this.lbl_CourseNumberError.Name = "lbl_CourseNumberError";
            this.lbl_CourseNumberError.Size = new System.Drawing.Size(0, 12);
            this.lbl_CourseNumberError.TabIndex = 0;
            // 
            // lbl_CourseNameError
            // 
            this.lbl_CourseNameError.AutoSize = true;
            this.lbl_CourseNameError.ForeColor = System.Drawing.Color.Red;
            this.lbl_CourseNameError.Location = new System.Drawing.Point(65, 92);
            this.lbl_CourseNameError.Name = "lbl_CourseNameError";
            this.lbl_CourseNameError.Size = new System.Drawing.Size(0, 12);
            this.lbl_CourseNameError.TabIndex = 0;
            // 
            // lbl_CourseCreditError
            // 
            this.lbl_CourseCreditError.AutoSize = true;
            this.lbl_CourseCreditError.ForeColor = System.Drawing.Color.Red;
            this.lbl_CourseCreditError.Location = new System.Drawing.Point(65, 139);
            this.lbl_CourseCreditError.Name = "lbl_CourseCreditError";
            this.lbl_CourseCreditError.Size = new System.Drawing.Size(0, 12);
            this.lbl_CourseCreditError.TabIndex = 0;
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
            this.txb_CourseName.Location = new System.Drawing.Point(67, 64);
            this.txb_CourseName.Name = "txb_CourseName";
            this.txb_CourseName.Size = new System.Drawing.Size(195, 21);
            this.txb_CourseName.TabIndex = 1;
            // 
            // txb_CourseCredit
            // 
            this.txb_CourseCredit.Location = new System.Drawing.Point(67, 111);
            this.txb_CourseCredit.Name = "txb_CourseCredit";
            this.txb_CourseCredit.Size = new System.Drawing.Size(195, 21);
            this.txb_CourseCredit.TabIndex = 2;
            // 
            // txb_CourseDescription
            // 
            this.txb_CourseDescription.Location = new System.Drawing.Point(67, 158);
            this.txb_CourseDescription.Multiline = true;
            this.txb_CourseDescription.Name = "txb_CourseDescription";
            this.txb_CourseDescription.ReadOnly = true;
            this.txb_CourseDescription.Size = new System.Drawing.Size(195, 69);
            this.txb_CourseDescription.TabIndex = 3;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(67, 269);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 4;
            this.btn_Submit.Text = "提交";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Abort
            // 
            this.btn_Abort.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Abort.Location = new System.Drawing.Point(187, 269);
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
            this.ClientSize = new System.Drawing.Size(292, 304);
            this.Controls.Add(this.lbl_CourseCreditError);
            this.Controls.Add(this.lbl_CourseNameError);
            this.Controls.Add(this.lbl_CourseNumberError);
            this.Controls.Add(this.btn_Abort);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.txb_CourseDescription);
            this.Controls.Add(this.txb_CourseCredit);
            this.Controls.Add(this.txb_CourseName);
            this.Controls.Add(this.txb_CourseNumber);
            this.Controls.Add(this.lbl_CourseDescription);
            this.Controls.Add(this.lbl_CourseCredit);
            this.Controls.Add(this.lbl_CourseName);
            this.Controls.Add(this.lbl_CourseNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::SmartLin.LearningCSharp.FormAndControl.Properties.Resources.Briefcase_16px;
            this.MaximizeBox = false;
            this.Name = "frm_CourseManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "课程管理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Label lbl_CourseNumber;
        private System.Windows.Forms.Label lbl_CourseName;
        private System.Windows.Forms.Label lbl_CourseCredit;
        private System.Windows.Forms.Label lbl_CourseDescription;
        private System.Windows.Forms.Label lbl_CourseNumberError;
        private System.Windows.Forms.Label lbl_CourseNameError;
        private System.Windows.Forms.Label lbl_CourseCreditError;
        [ValidationMapping("Course", "Number", MessageControlName = "lbl_CourseNumberError")]
        private System.Windows.Forms.TextBox txb_CourseNumber;
        [ValidationMapping("Course", "Name", MessageControlName = "lbl_CourseNameError")]
        private System.Windows.Forms.TextBox txb_CourseName;
        private System.Windows.Forms.TextBox txb_CourseCredit;
        private System.Windows.Forms.TextBox txb_CourseDescription;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Abort;

    }
}

