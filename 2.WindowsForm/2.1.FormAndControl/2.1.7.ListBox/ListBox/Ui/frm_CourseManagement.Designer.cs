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
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.ckb_IsAvailable = new System.Windows.Forms.CheckBox();
            this.ckb_HasExperiment = new System.Windows.Forms.CheckBox();
            this.ckb_HasMooc = new System.Windows.Forms.CheckBox();
            this.lbl_FormativeAssessment = new System.Windows.Forms.Label();
            this.clb_FormativeAssessment = new System.Windows.Forms.CheckedListBox();
            this.gpb_CourseType = new System.Windows.Forms.GroupBox();
            this.rdb_IsPublic = new System.Windows.Forms.RadioButton();
            this.rdb_IsProfessional = new System.Windows.Forms.RadioButton();
            this.gpb_CourseLearningType = new System.Windows.Forms.GroupBox();
            this.rdb_IsOptional = new System.Windows.Forms.RadioButton();
            this.rdb_IsCompulsory = new System.Windows.Forms.RadioButton();
            this.lbl_CourseAppraisalType = new System.Windows.Forms.Label();
            this.lbl_CourseAppraisalForm = new System.Windows.Forms.Label();
            this.lsb_CourseAppraisalType = new System.Windows.Forms.ListBox();
            this.lsb_CourseAppraisalForm = new System.Windows.Forms.ListBox();
            this.gpb_CourseType.SuspendLayout();
            this.gpb_CourseLearningType.SuspendLayout();
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
            this.txb_CourseDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txb_CourseDescription.Size = new System.Drawing.Size(195, 69);
            this.txb_CourseDescription.TabIndex = 3;
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(67, 269);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(75, 23);
            this.btn_Load.TabIndex = 4;
            this.btn_Load.Text = "载入";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Submit.Location = new System.Drawing.Point(187, 269);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 5;
            this.btn_Submit.Text = "提交";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // ckb_IsAvailable
            // 
            this.ckb_IsAvailable.AutoSize = true;
            this.ckb_IsAvailable.Location = new System.Drawing.Point(293, 19);
            this.ckb_IsAvailable.Name = "ckb_IsAvailable";
            this.ckb_IsAvailable.Size = new System.Drawing.Size(72, 16);
            this.ckb_IsAvailable.TabIndex = 8;
            this.ckb_IsAvailable.Text = "是否启用";
            this.ckb_IsAvailable.UseVisualStyleBackColor = true;
            // 
            // ckb_HasExperiment
            // 
            this.ckb_HasExperiment.AutoSize = true;
            this.ckb_HasExperiment.Location = new System.Drawing.Point(293, 42);
            this.ckb_HasExperiment.Name = "ckb_HasExperiment";
            this.ckb_HasExperiment.Size = new System.Drawing.Size(96, 16);
            this.ckb_HasExperiment.TabIndex = 6;
            this.ckb_HasExperiment.Text = "包含实验教学";
            this.ckb_HasExperiment.UseVisualStyleBackColor = true;
            // 
            // ckb_HasMooc
            // 
            this.ckb_HasMooc.AutoSize = true;
            this.ckb_HasMooc.Location = new System.Drawing.Point(293, 65);
            this.ckb_HasMooc.Name = "ckb_HasMooc";
            this.ckb_HasMooc.Size = new System.Drawing.Size(96, 16);
            this.ckb_HasMooc.TabIndex = 7;
            this.ckb_HasMooc.Text = "包含慕课教学";
            this.ckb_HasMooc.UseVisualStyleBackColor = true;
            // 
            // lbl_FormativeAssessment
            // 
            this.lbl_FormativeAssessment.AutoSize = true;
            this.lbl_FormativeAssessment.Location = new System.Drawing.Point(291, 92);
            this.lbl_FormativeAssessment.Name = "lbl_FormativeAssessment";
            this.lbl_FormativeAssessment.Size = new System.Drawing.Size(77, 12);
            this.lbl_FormativeAssessment.TabIndex = 10;
            this.lbl_FormativeAssessment.Text = "形成性评价：";
            // 
            // clb_FormativeAssessment
            // 
            this.clb_FormativeAssessment.CheckOnClick = true;
            this.clb_FormativeAssessment.FormattingEnabled = true;
            this.clb_FormativeAssessment.Location = new System.Drawing.Point(293, 111);
            this.clb_FormativeAssessment.Name = "clb_FormativeAssessment";
            this.clb_FormativeAssessment.Size = new System.Drawing.Size(120, 116);
            this.clb_FormativeAssessment.TabIndex = 9;
            // 
            // gpb_CourseType
            // 
            this.gpb_CourseType.Controls.Add(this.rdb_IsPublic);
            this.gpb_CourseType.Controls.Add(this.rdb_IsProfessional);
            this.gpb_CourseType.Location = new System.Drawing.Point(443, 17);
            this.gpb_CourseType.Name = "gpb_CourseType";
            this.gpb_CourseType.Size = new System.Drawing.Size(80, 65);
            this.gpb_CourseType.TabIndex = 11;
            this.gpb_CourseType.TabStop = false;
            this.gpb_CourseType.Text = "类型";
            // 
            // rdb_IsPublic
            // 
            this.rdb_IsPublic.AutoSize = true;
            this.rdb_IsPublic.Location = new System.Drawing.Point(10, 44);
            this.rdb_IsPublic.Name = "rdb_IsPublic";
            this.rdb_IsPublic.Size = new System.Drawing.Size(59, 16);
            this.rdb_IsPublic.TabIndex = 1;
            this.rdb_IsPublic.TabStop = true;
            this.rdb_IsPublic.Text = "公共课";
            this.rdb_IsPublic.UseVisualStyleBackColor = true;
            // 
            // rdb_IsProfessional
            // 
            this.rdb_IsProfessional.AutoSize = true;
            this.rdb_IsProfessional.Location = new System.Drawing.Point(10, 21);
            this.rdb_IsProfessional.Name = "rdb_IsProfessional";
            this.rdb_IsProfessional.Size = new System.Drawing.Size(59, 16);
            this.rdb_IsProfessional.TabIndex = 0;
            this.rdb_IsProfessional.TabStop = true;
            this.rdb_IsProfessional.Text = "专业课";
            this.rdb_IsProfessional.UseVisualStyleBackColor = true;
            // 
            // gpb_CourseLearningType
            // 
            this.gpb_CourseLearningType.Controls.Add(this.rdb_IsOptional);
            this.gpb_CourseLearningType.Controls.Add(this.rdb_IsCompulsory);
            this.gpb_CourseLearningType.Location = new System.Drawing.Point(537, 17);
            this.gpb_CourseLearningType.Name = "gpb_CourseLearningType";
            this.gpb_CourseLearningType.Size = new System.Drawing.Size(80, 65);
            this.gpb_CourseLearningType.TabIndex = 12;
            this.gpb_CourseLearningType.TabStop = false;
            this.gpb_CourseLearningType.Text = "修读类型";
            // 
            // rdb_IsOptional
            // 
            this.rdb_IsOptional.AutoSize = true;
            this.rdb_IsOptional.Location = new System.Drawing.Point(10, 43);
            this.rdb_IsOptional.Name = "rdb_IsOptional";
            this.rdb_IsOptional.Size = new System.Drawing.Size(59, 16);
            this.rdb_IsOptional.TabIndex = 1;
            this.rdb_IsOptional.TabStop = true;
            this.rdb_IsOptional.Text = "选修课";
            this.rdb_IsOptional.UseVisualStyleBackColor = true;
            // 
            // rdb_IsCompulsory
            // 
            this.rdb_IsCompulsory.AutoSize = true;
            this.rdb_IsCompulsory.Location = new System.Drawing.Point(10, 21);
            this.rdb_IsCompulsory.Name = "rdb_IsCompulsory";
            this.rdb_IsCompulsory.Size = new System.Drawing.Size(59, 16);
            this.rdb_IsCompulsory.TabIndex = 0;
            this.rdb_IsCompulsory.TabStop = true;
            this.rdb_IsCompulsory.Text = "必修课";
            this.rdb_IsCompulsory.UseVisualStyleBackColor = true;
            // 
            // lbl_CourseAppraisalType
            // 
            this.lbl_CourseAppraisalType.AutoSize = true;
            this.lbl_CourseAppraisalType.Location = new System.Drawing.Point(441, 95);
            this.lbl_CourseAppraisalType.Name = "lbl_CourseAppraisalType";
            this.lbl_CourseAppraisalType.Size = new System.Drawing.Size(65, 12);
            this.lbl_CourseAppraisalType.TabIndex = 13;
            this.lbl_CourseAppraisalType.Text = "考核类型：";
            // 
            // lbl_CourseAppraisalForm
            // 
            this.lbl_CourseAppraisalForm.AutoSize = true;
            this.lbl_CourseAppraisalForm.Location = new System.Drawing.Point(535, 95);
            this.lbl_CourseAppraisalForm.Name = "lbl_CourseAppraisalForm";
            this.lbl_CourseAppraisalForm.Size = new System.Drawing.Size(65, 12);
            this.lbl_CourseAppraisalForm.TabIndex = 14;
            this.lbl_CourseAppraisalForm.Text = "考核形式：";
            // 
            // lsb_CourseAppraisalType
            // 
            this.lsb_CourseAppraisalType.FormattingEnabled = true;
            this.lsb_CourseAppraisalType.ItemHeight = 12;
            this.lsb_CourseAppraisalType.Location = new System.Drawing.Point(443, 115);
            this.lsb_CourseAppraisalType.Name = "lsb_CourseAppraisalType";
            this.lsb_CourseAppraisalType.Size = new System.Drawing.Size(80, 112);
            this.lsb_CourseAppraisalType.TabIndex = 15;
            this.lsb_CourseAppraisalType.SelectedIndexChanged += new System.EventHandler(this.lsb_CourseAppraisalType_SelectedIndexChanged);
            // 
            // lsb_CourseAppraisalForm
            // 
            this.lsb_CourseAppraisalForm.FormattingEnabled = true;
            this.lsb_CourseAppraisalForm.ItemHeight = 12;
            this.lsb_CourseAppraisalForm.Location = new System.Drawing.Point(537, 115);
            this.lsb_CourseAppraisalForm.Name = "lsb_CourseAppraisalForm";
            this.lsb_CourseAppraisalForm.Size = new System.Drawing.Size(80, 112);
            this.lsb_CourseAppraisalForm.TabIndex = 16;
            // 
            // frm_CourseManagement
            // 
            this.AcceptButton = this.btn_Load;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 304);
            this.Controls.Add(this.lsb_CourseAppraisalForm);
            this.Controls.Add(this.lsb_CourseAppraisalType);
            this.Controls.Add(this.lbl_CourseAppraisalForm);
            this.Controls.Add(this.lbl_CourseAppraisalType);
            this.Controls.Add(this.gpb_CourseLearningType);
            this.Controls.Add(this.gpb_CourseType);
            this.Controls.Add(this.lbl_FormativeAssessment);
            this.Controls.Add(this.clb_FormativeAssessment);
            this.Controls.Add(this.ckb_IsAvailable);
            this.Controls.Add(this.ckb_HasMooc);
            this.Controls.Add(this.ckb_HasExperiment);
            this.Controls.Add(this.lbl_CourseCreditError);
            this.Controls.Add(this.lbl_CourseNameError);
            this.Controls.Add(this.lbl_CourseNumberError);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_Load);
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
            this.gpb_CourseType.ResumeLayout(false);
            this.gpb_CourseType.PerformLayout();
            this.gpb_CourseLearningType.ResumeLayout(false);
            this.gpb_CourseLearningType.PerformLayout();
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
        private System.Windows.Forms.TextBox txb_CourseNumber;
        private System.Windows.Forms.TextBox txb_CourseName;
        private System.Windows.Forms.TextBox txb_CourseCredit;
        private System.Windows.Forms.TextBox txb_CourseDescription;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.CheckBox ckb_IsAvailable;
        private System.Windows.Forms.CheckBox ckb_HasExperiment;
        private System.Windows.Forms.CheckBox ckb_HasMooc;
        private System.Windows.Forms.CheckedListBox clb_FormativeAssessment;
        private System.Windows.Forms.Label lbl_FormativeAssessment;
        private System.Windows.Forms.GroupBox gpb_CourseType;
        private System.Windows.Forms.GroupBox gpb_CourseLearningType;
        private System.Windows.Forms.RadioButton rdb_IsPublic;
        private System.Windows.Forms.RadioButton rdb_IsProfessional;
        private System.Windows.Forms.RadioButton rdb_IsOptional;
        private System.Windows.Forms.RadioButton rdb_IsCompulsory;
        private System.Windows.Forms.Label lbl_CourseAppraisalType;
        private System.Windows.Forms.Label lbl_CourseAppraisalForm;
        private System.Windows.Forms.ListBox lsb_CourseAppraisalType;
        private System.Windows.Forms.ListBox lsb_CourseAppraisalForm;
    }
}

