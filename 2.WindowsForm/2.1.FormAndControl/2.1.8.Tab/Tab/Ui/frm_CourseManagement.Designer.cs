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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbp_CourseBasicInfo = new System.Windows.Forms.TabPage();
            this.tbp_CourseTeachingElement = new System.Windows.Forms.TabPage();
            this.tbp_CourseLearningRequirement = new System.Windows.Forms.TabPage();
            this.gpb_CourseType.SuspendLayout();
            this.gpb_CourseLearningType.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbp_CourseBasicInfo.SuspendLayout();
            this.tbp_CourseTeachingElement.SuspendLayout();
            this.tbp_CourseLearningRequirement.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_CourseNumber
            // 
            this.lbl_CourseNumber.AutoSize = true;
            this.lbl_CourseNumber.Location = new System.Drawing.Point(10, 18);
            this.lbl_CourseNumber.Name = "lbl_CourseNumber";
            this.lbl_CourseNumber.Size = new System.Drawing.Size(41, 12);
            this.lbl_CourseNumber.TabIndex = 0;
            this.lbl_CourseNumber.Text = "编号：";
            // 
            // lbl_CourseName
            // 
            this.lbl_CourseName.AutoSize = true;
            this.lbl_CourseName.Location = new System.Drawing.Point(10, 65);
            this.lbl_CourseName.Name = "lbl_CourseName";
            this.lbl_CourseName.Size = new System.Drawing.Size(41, 12);
            this.lbl_CourseName.TabIndex = 0;
            this.lbl_CourseName.Text = "名称：";
            // 
            // lbl_CourseCredit
            // 
            this.lbl_CourseCredit.AutoSize = true;
            this.lbl_CourseCredit.Location = new System.Drawing.Point(10, 112);
            this.lbl_CourseCredit.Name = "lbl_CourseCredit";
            this.lbl_CourseCredit.Size = new System.Drawing.Size(41, 12);
            this.lbl_CourseCredit.TabIndex = 0;
            this.lbl_CourseCredit.Text = "学分：";
            // 
            // lbl_CourseDescription
            // 
            this.lbl_CourseDescription.AutoSize = true;
            this.lbl_CourseDescription.Location = new System.Drawing.Point(10, 159);
            this.lbl_CourseDescription.Name = "lbl_CourseDescription";
            this.lbl_CourseDescription.Size = new System.Drawing.Size(41, 12);
            this.lbl_CourseDescription.TabIndex = 0;
            this.lbl_CourseDescription.Text = "描述：";
            // 
            // lbl_CourseNumberError
            // 
            this.lbl_CourseNumberError.AutoSize = true;
            this.lbl_CourseNumberError.ForeColor = System.Drawing.Color.Red;
            this.lbl_CourseNumberError.Location = new System.Drawing.Point(55, 43);
            this.lbl_CourseNumberError.Name = "lbl_CourseNumberError";
            this.lbl_CourseNumberError.Size = new System.Drawing.Size(0, 12);
            this.lbl_CourseNumberError.TabIndex = 0;
            // 
            // lbl_CourseNameError
            // 
            this.lbl_CourseNameError.AutoSize = true;
            this.lbl_CourseNameError.ForeColor = System.Drawing.Color.Red;
            this.lbl_CourseNameError.Location = new System.Drawing.Point(55, 90);
            this.lbl_CourseNameError.Name = "lbl_CourseNameError";
            this.lbl_CourseNameError.Size = new System.Drawing.Size(0, 12);
            this.lbl_CourseNameError.TabIndex = 0;
            // 
            // lbl_CourseCreditError
            // 
            this.lbl_CourseCreditError.AutoSize = true;
            this.lbl_CourseCreditError.ForeColor = System.Drawing.Color.Red;
            this.lbl_CourseCreditError.Location = new System.Drawing.Point(55, 137);
            this.lbl_CourseCreditError.Name = "lbl_CourseCreditError";
            this.lbl_CourseCreditError.Size = new System.Drawing.Size(0, 12);
            this.lbl_CourseCreditError.TabIndex = 0;
            // 
            // txb_CourseNumber
            // 
            this.txb_CourseNumber.Location = new System.Drawing.Point(57, 15);
            this.txb_CourseNumber.Name = "txb_CourseNumber";
            this.txb_CourseNumber.Size = new System.Drawing.Size(195, 21);
            this.txb_CourseNumber.TabIndex = 0;
            // 
            // txb_CourseName
            // 
            this.txb_CourseName.Location = new System.Drawing.Point(57, 62);
            this.txb_CourseName.Name = "txb_CourseName";
            this.txb_CourseName.Size = new System.Drawing.Size(195, 21);
            this.txb_CourseName.TabIndex = 1;
            // 
            // txb_CourseCredit
            // 
            this.txb_CourseCredit.Location = new System.Drawing.Point(57, 109);
            this.txb_CourseCredit.Name = "txb_CourseCredit";
            this.txb_CourseCredit.Size = new System.Drawing.Size(195, 21);
            this.txb_CourseCredit.TabIndex = 2;
            // 
            // txb_CourseDescription
            // 
            this.txb_CourseDescription.Location = new System.Drawing.Point(57, 156);
            this.txb_CourseDescription.Multiline = true;
            this.txb_CourseDescription.Name = "txb_CourseDescription";
            this.txb_CourseDescription.ReadOnly = true;
            this.txb_CourseDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txb_CourseDescription.Size = new System.Drawing.Size(195, 69);
            this.txb_CourseDescription.TabIndex = 3;
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(12, 288);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(75, 23);
            this.btn_Load.TabIndex = 4;
            this.btn_Load.Text = "载入";
            this.btn_Load.UseVisualStyleBackColor = true;
            // 
            // btn_Submit
            // 
            this.btn_Submit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Submit.Location = new System.Drawing.Point(229, 288);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 5;
            this.btn_Submit.Text = "提交";
            this.btn_Submit.UseVisualStyleBackColor = true;
            // 
            // ckb_IsAvailable
            // 
            this.ckb_IsAvailable.AutoSize = true;
            this.ckb_IsAvailable.Location = new System.Drawing.Point(56, 14);
            this.ckb_IsAvailable.Name = "ckb_IsAvailable";
            this.ckb_IsAvailable.Size = new System.Drawing.Size(72, 16);
            this.ckb_IsAvailable.TabIndex = 8;
            this.ckb_IsAvailable.Text = "是否启用";
            this.ckb_IsAvailable.UseVisualStyleBackColor = true;
            // 
            // ckb_HasExperiment
            // 
            this.ckb_HasExperiment.AutoSize = true;
            this.ckb_HasExperiment.Location = new System.Drawing.Point(56, 37);
            this.ckb_HasExperiment.Name = "ckb_HasExperiment";
            this.ckb_HasExperiment.Size = new System.Drawing.Size(96, 16);
            this.ckb_HasExperiment.TabIndex = 6;
            this.ckb_HasExperiment.Text = "包含实验教学";
            this.ckb_HasExperiment.UseVisualStyleBackColor = true;
            // 
            // ckb_HasMooc
            // 
            this.ckb_HasMooc.AutoSize = true;
            this.ckb_HasMooc.Location = new System.Drawing.Point(56, 60);
            this.ckb_HasMooc.Name = "ckb_HasMooc";
            this.ckb_HasMooc.Size = new System.Drawing.Size(96, 16);
            this.ckb_HasMooc.TabIndex = 7;
            this.ckb_HasMooc.Text = "包含慕课教学";
            this.ckb_HasMooc.UseVisualStyleBackColor = true;
            // 
            // lbl_FormativeAssessment
            // 
            this.lbl_FormativeAssessment.AutoSize = true;
            this.lbl_FormativeAssessment.Location = new System.Drawing.Point(54, 87);
            this.lbl_FormativeAssessment.Name = "lbl_FormativeAssessment";
            this.lbl_FormativeAssessment.Size = new System.Drawing.Size(77, 12);
            this.lbl_FormativeAssessment.TabIndex = 10;
            this.lbl_FormativeAssessment.Text = "形成性评价：";
            // 
            // clb_FormativeAssessment
            // 
            this.clb_FormativeAssessment.CheckOnClick = true;
            this.clb_FormativeAssessment.FormattingEnabled = true;
            this.clb_FormativeAssessment.Location = new System.Drawing.Point(56, 106);
            this.clb_FormativeAssessment.Name = "clb_FormativeAssessment";
            this.clb_FormativeAssessment.Size = new System.Drawing.Size(120, 116);
            this.clb_FormativeAssessment.TabIndex = 9;
            // 
            // gpb_CourseType
            // 
            this.gpb_CourseType.Controls.Add(this.rdb_IsPublic);
            this.gpb_CourseType.Controls.Add(this.rdb_IsProfessional);
            this.gpb_CourseType.Location = new System.Drawing.Point(58, 12);
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
            this.gpb_CourseLearningType.Location = new System.Drawing.Point(152, 12);
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
            this.lbl_CourseAppraisalType.Location = new System.Drawing.Point(56, 90);
            this.lbl_CourseAppraisalType.Name = "lbl_CourseAppraisalType";
            this.lbl_CourseAppraisalType.Size = new System.Drawing.Size(65, 12);
            this.lbl_CourseAppraisalType.TabIndex = 13;
            this.lbl_CourseAppraisalType.Text = "考核类型：";
            // 
            // lbl_CourseAppraisalForm
            // 
            this.lbl_CourseAppraisalForm.AutoSize = true;
            this.lbl_CourseAppraisalForm.Location = new System.Drawing.Point(150, 90);
            this.lbl_CourseAppraisalForm.Name = "lbl_CourseAppraisalForm";
            this.lbl_CourseAppraisalForm.Size = new System.Drawing.Size(65, 12);
            this.lbl_CourseAppraisalForm.TabIndex = 14;
            this.lbl_CourseAppraisalForm.Text = "考核形式：";
            // 
            // lsb_CourseAppraisalType
            // 
            this.lsb_CourseAppraisalType.FormattingEnabled = true;
            this.lsb_CourseAppraisalType.ItemHeight = 12;
            this.lsb_CourseAppraisalType.Location = new System.Drawing.Point(58, 110);
            this.lsb_CourseAppraisalType.Name = "lsb_CourseAppraisalType";
            this.lsb_CourseAppraisalType.Size = new System.Drawing.Size(80, 112);
            this.lsb_CourseAppraisalType.TabIndex = 15;
            // 
            // lsb_CourseAppraisalForm
            // 
            this.lsb_CourseAppraisalForm.FormattingEnabled = true;
            this.lsb_CourseAppraisalForm.ItemHeight = 12;
            this.lsb_CourseAppraisalForm.Location = new System.Drawing.Point(152, 110);
            this.lsb_CourseAppraisalForm.Name = "lsb_CourseAppraisalForm";
            this.lsb_CourseAppraisalForm.Size = new System.Drawing.Size(80, 112);
            this.lsb_CourseAppraisalForm.TabIndex = 16;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbp_CourseBasicInfo);
            this.tabControl1.Controls.Add(this.tbp_CourseTeachingElement);
            this.tabControl1.Controls.Add(this.tbp_CourseLearningRequirement);
            this.tabControl1.Location = new System.Drawing.Point(12, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(292, 272);
            this.tabControl1.TabIndex = 17;
            // 
            // tbp_CourseBasicInfo
            // 
            this.tbp_CourseBasicInfo.Controls.Add(this.lbl_CourseDescription);
            this.tbp_CourseBasicInfo.Controls.Add(this.lbl_CourseNumber);
            this.tbp_CourseBasicInfo.Controls.Add(this.lbl_CourseName);
            this.tbp_CourseBasicInfo.Controls.Add(this.lbl_CourseCredit);
            this.tbp_CourseBasicInfo.Controls.Add(this.txb_CourseNumber);
            this.tbp_CourseBasicInfo.Controls.Add(this.txb_CourseName);
            this.tbp_CourseBasicInfo.Controls.Add(this.txb_CourseCredit);
            this.tbp_CourseBasicInfo.Controls.Add(this.txb_CourseDescription);
            this.tbp_CourseBasicInfo.Controls.Add(this.lbl_CourseNumberError);
            this.tbp_CourseBasicInfo.Controls.Add(this.lbl_CourseNameError);
            this.tbp_CourseBasicInfo.Controls.Add(this.lbl_CourseCreditError);
            this.tbp_CourseBasicInfo.Location = new System.Drawing.Point(4, 22);
            this.tbp_CourseBasicInfo.Name = "tbp_CourseBasicInfo";
            this.tbp_CourseBasicInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_CourseBasicInfo.Size = new System.Drawing.Size(284, 246);
            this.tbp_CourseBasicInfo.TabIndex = 0;
            this.tbp_CourseBasicInfo.Text = "基本信息";
            this.tbp_CourseBasicInfo.UseVisualStyleBackColor = true;
            // 
            // tbp_CourseTeachingElement
            // 
            this.tbp_CourseTeachingElement.Controls.Add(this.clb_FormativeAssessment);
            this.tbp_CourseTeachingElement.Controls.Add(this.ckb_HasExperiment);
            this.tbp_CourseTeachingElement.Controls.Add(this.ckb_HasMooc);
            this.tbp_CourseTeachingElement.Controls.Add(this.ckb_IsAvailable);
            this.tbp_CourseTeachingElement.Controls.Add(this.lbl_FormativeAssessment);
            this.tbp_CourseTeachingElement.Location = new System.Drawing.Point(4, 22);
            this.tbp_CourseTeachingElement.Name = "tbp_CourseTeachingElement";
            this.tbp_CourseTeachingElement.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_CourseTeachingElement.Size = new System.Drawing.Size(284, 246);
            this.tbp_CourseTeachingElement.TabIndex = 1;
            this.tbp_CourseTeachingElement.Text = "教学要素";
            this.tbp_CourseTeachingElement.UseVisualStyleBackColor = true;
            // 
            // tbp_CourseLearningRequirement
            // 
            this.tbp_CourseLearningRequirement.Controls.Add(this.lsb_CourseAppraisalForm);
            this.tbp_CourseLearningRequirement.Controls.Add(this.gpb_CourseType);
            this.tbp_CourseLearningRequirement.Controls.Add(this.lsb_CourseAppraisalType);
            this.tbp_CourseLearningRequirement.Controls.Add(this.gpb_CourseLearningType);
            this.tbp_CourseLearningRequirement.Controls.Add(this.lbl_CourseAppraisalForm);
            this.tbp_CourseLearningRequirement.Controls.Add(this.lbl_CourseAppraisalType);
            this.tbp_CourseLearningRequirement.Location = new System.Drawing.Point(4, 22);
            this.tbp_CourseLearningRequirement.Name = "tbp_CourseLearningRequirement";
            this.tbp_CourseLearningRequirement.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_CourseLearningRequirement.Size = new System.Drawing.Size(284, 246);
            this.tbp_CourseLearningRequirement.TabIndex = 2;
            this.tbp_CourseLearningRequirement.Text = "学习要求";
            this.tbp_CourseLearningRequirement.UseVisualStyleBackColor = true;
            // 
            // frm_CourseManagement
            // 
            this.AcceptButton = this.btn_Load;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 323);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_Load);
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
            this.tabControl1.ResumeLayout(false);
            this.tbp_CourseBasicInfo.ResumeLayout(false);
            this.tbp_CourseBasicInfo.PerformLayout();
            this.tbp_CourseTeachingElement.ResumeLayout(false);
            this.tbp_CourseTeachingElement.PerformLayout();
            this.tbp_CourseLearningRequirement.ResumeLayout(false);
            this.tbp_CourseLearningRequirement.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbp_CourseBasicInfo;
        private System.Windows.Forms.TabPage tbp_CourseTeachingElement;
        private System.Windows.Forms.TabPage tbp_CourseLearningRequirement;
    }
}

