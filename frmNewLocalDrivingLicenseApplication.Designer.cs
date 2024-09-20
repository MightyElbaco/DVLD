namespace DVLD
{
    partial class frmNewLocalDrivingLicenseApplication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tcLocalDrivingLicenseApplicationInfo = new System.Windows.Forms.TabControl();
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.cbFindBy = new System.Windows.Forms.ComboBox();
            this.lbFindBy = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.tpApplicationInfo = new System.Windows.Forms.TabPage();
            this.cbLicenseClasses = new System.Windows.Forms.ComboBox();
            this.lbApplicationFeesValue = new System.Windows.Forms.Label();
            this.lbCreatedByValue = new System.Windows.Forms.Label();
            this.lbApplicationDateValue = new System.Windows.Forms.Label();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.lbDLApplicationIDValue = new System.Windows.Forms.Label();
            this.lbDLApplicationID = new System.Windows.Forms.Label();
            this.lbApplicationFees = new System.Windows.Forms.Label();
            this.lbLicenseClass = new System.Windows.Forms.Label();
            this.lbApplicationDate = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlPersonDetails1 = new DVLD.ctrlPersonDetails();
            this.tcLocalDrivingLicenseApplicationInfo.SuspendLayout();
            this.tpPersonInfo.SuspendLayout();
            this.tpApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(126, 19);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(473, 31);
            this.lbTitle.TabIndex = 5;
            this.lbTitle.Text = "New Local Driving License Application";
            // 
            // tcLocalDrivingLicenseApplicationInfo
            // 
            this.tcLocalDrivingLicenseApplicationInfo.Controls.Add(this.tpPersonInfo);
            this.tcLocalDrivingLicenseApplicationInfo.Controls.Add(this.tpApplicationInfo);
            this.tcLocalDrivingLicenseApplicationInfo.Location = new System.Drawing.Point(13, 78);
            this.tcLocalDrivingLicenseApplicationInfo.Name = "tcLocalDrivingLicenseApplicationInfo";
            this.tcLocalDrivingLicenseApplicationInfo.SelectedIndex = 0;
            this.tcLocalDrivingLicenseApplicationInfo.Size = new System.Drawing.Size(712, 444);
            this.tcLocalDrivingLicenseApplicationInfo.TabIndex = 6;
            // 
            // tpPersonInfo
            // 
            this.tpPersonInfo.Controls.Add(this.ctrlPersonDetails1);
            this.tpPersonInfo.Controls.Add(this.tbFilter);
            this.tpPersonInfo.Controls.Add(this.cbFindBy);
            this.tpPersonInfo.Controls.Add(this.lbFindBy);
            this.tpPersonInfo.Controls.Add(this.btnNext);
            this.tpPersonInfo.Controls.Add(this.btnAddNew);
            this.tpPersonInfo.Controls.Add(this.btnFind);
            this.tpPersonInfo.Location = new System.Drawing.Point(4, 22);
            this.tpPersonInfo.Name = "tpPersonInfo";
            this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonInfo.Size = new System.Drawing.Size(704, 418);
            this.tpPersonInfo.TabIndex = 0;
            this.tpPersonInfo.Text = "Person Information";
            this.tpPersonInfo.UseVisualStyleBackColor = true;
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(289, 23);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(268, 20);
            this.tbFilter.TabIndex = 15;
            this.tbFilter.Leave += new System.EventHandler(this.tbFilter_Leave);
            // 
            // cbFindBy
            // 
            this.cbFindBy.FormattingEnabled = true;
            this.cbFindBy.Items.AddRange(new object[] {
            "PersonID",
            "NationalNO"});
            this.cbFindBy.Location = new System.Drawing.Point(123, 22);
            this.cbFindBy.Name = "cbFindBy";
            this.cbFindBy.Size = new System.Drawing.Size(160, 21);
            this.cbFindBy.TabIndex = 14;
            this.cbFindBy.Text = "PersonID";
            // 
            // lbFindBy
            // 
            this.lbFindBy.AutoSize = true;
            this.lbFindBy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFindBy.Location = new System.Drawing.Point(43, 22);
            this.lbFindBy.Name = "lbFindBy";
            this.lbFindBy.Size = new System.Drawing.Size(74, 21);
            this.lbFindBy.TabIndex = 13;
            this.lbFindBy.Text = "Find By:";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(629, 380);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(69, 32);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackgroundImage = global::DVLD.Properties.Resources.chieff_of_staff;
            this.btnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNew.Location = new System.Drawing.Point(648, 8);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(50, 50);
            this.btnAddNew.TabIndex = 12;
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackgroundImage = global::DVLD.Properties.Resources.find;
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFind.Location = new System.Drawing.Point(572, 14);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(39, 34);
            this.btnFind.TabIndex = 11;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tpApplicationInfo
            // 
            this.tpApplicationInfo.Controls.Add(this.cbLicenseClasses);
            this.tpApplicationInfo.Controls.Add(this.lbApplicationFeesValue);
            this.tpApplicationInfo.Controls.Add(this.lbCreatedByValue);
            this.tpApplicationInfo.Controls.Add(this.lbApplicationDateValue);
            this.tpApplicationInfo.Controls.Add(this.lbCreatedBy);
            this.tpApplicationInfo.Controls.Add(this.lbDLApplicationIDValue);
            this.tpApplicationInfo.Controls.Add(this.lbDLApplicationID);
            this.tpApplicationInfo.Controls.Add(this.lbApplicationFees);
            this.tpApplicationInfo.Controls.Add(this.lbLicenseClass);
            this.tpApplicationInfo.Controls.Add(this.lbApplicationDate);
            this.tpApplicationInfo.Location = new System.Drawing.Point(4, 22);
            this.tpApplicationInfo.Name = "tpApplicationInfo";
            this.tpApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpApplicationInfo.Size = new System.Drawing.Size(704, 418);
            this.tpApplicationInfo.TabIndex = 1;
            this.tpApplicationInfo.Text = "Application Information";
            this.tpApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // cbLicenseClasses
            // 
            this.cbLicenseClasses.FormattingEnabled = true;
            this.cbLicenseClasses.Location = new System.Drawing.Point(230, 133);
            this.cbLicenseClasses.Name = "cbLicenseClasses";
            this.cbLicenseClasses.Size = new System.Drawing.Size(250, 21);
            this.cbLicenseClasses.TabIndex = 28;
            // 
            // lbApplicationFeesValue
            // 
            this.lbApplicationFeesValue.AutoSize = true;
            this.lbApplicationFeesValue.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationFeesValue.Location = new System.Drawing.Point(226, 181);
            this.lbApplicationFeesValue.Name = "lbApplicationFeesValue";
            this.lbApplicationFeesValue.Size = new System.Drawing.Size(32, 23);
            this.lbApplicationFeesValue.TabIndex = 27;
            this.lbApplicationFeesValue.Text = "15";
            this.lbApplicationFeesValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCreatedByValue
            // 
            this.lbCreatedByValue.AutoSize = true;
            this.lbCreatedByValue.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedByValue.Location = new System.Drawing.Point(226, 231);
            this.lbCreatedByValue.Name = "lbCreatedByValue";
            this.lbCreatedByValue.Size = new System.Drawing.Size(80, 23);
            this.lbCreatedByValue.TabIndex = 26;
            this.lbCreatedByValue.Text = "*******";
            this.lbCreatedByValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbApplicationDateValue
            // 
            this.lbApplicationDateValue.AutoSize = true;
            this.lbApplicationDateValue.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationDateValue.Location = new System.Drawing.Point(226, 81);
            this.lbApplicationDateValue.Name = "lbApplicationDateValue";
            this.lbApplicationDateValue.Size = new System.Drawing.Size(80, 23);
            this.lbApplicationDateValue.TabIndex = 25;
            this.lbApplicationDateValue.Text = "*******";
            this.lbApplicationDateValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedBy.Location = new System.Drawing.Point(23, 231);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(108, 23);
            this.lbCreatedBy.TabIndex = 24;
            this.lbCreatedBy.Text = "Created By:";
            // 
            // lbDLApplicationIDValue
            // 
            this.lbDLApplicationIDValue.AutoSize = true;
            this.lbDLApplicationIDValue.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDLApplicationIDValue.Location = new System.Drawing.Point(226, 31);
            this.lbDLApplicationIDValue.Name = "lbDLApplicationIDValue";
            this.lbDLApplicationIDValue.Size = new System.Drawing.Size(80, 23);
            this.lbDLApplicationIDValue.TabIndex = 23;
            this.lbDLApplicationIDValue.Text = "*******";
            this.lbDLApplicationIDValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDLApplicationID
            // 
            this.lbDLApplicationID.AutoSize = true;
            this.lbDLApplicationID.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDLApplicationID.Location = new System.Drawing.Point(23, 31);
            this.lbDLApplicationID.Name = "lbDLApplicationID";
            this.lbDLApplicationID.Size = new System.Drawing.Size(174, 23);
            this.lbDLApplicationID.TabIndex = 22;
            this.lbDLApplicationID.Text = "D.L Application ID:";
            // 
            // lbApplicationFees
            // 
            this.lbApplicationFees.AutoSize = true;
            this.lbApplicationFees.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationFees.Location = new System.Drawing.Point(22, 181);
            this.lbApplicationFees.Name = "lbApplicationFees";
            this.lbApplicationFees.Size = new System.Drawing.Size(156, 23);
            this.lbApplicationFees.TabIndex = 16;
            this.lbApplicationFees.Text = "Application Fees:";
            // 
            // lbLicenseClass
            // 
            this.lbLicenseClass.AutoSize = true;
            this.lbLicenseClass.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicenseClass.Location = new System.Drawing.Point(23, 131);
            this.lbLicenseClass.Name = "lbLicenseClass";
            this.lbLicenseClass.Size = new System.Drawing.Size(129, 23);
            this.lbLicenseClass.TabIndex = 15;
            this.lbLicenseClass.Text = "License Class:";
            // 
            // lbApplicationDate
            // 
            this.lbApplicationDate.AutoSize = true;
            this.lbApplicationDate.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationDate.Location = new System.Drawing.Point(22, 81);
            this.lbApplicationDate.Name = "lbApplicationDate";
            this.lbApplicationDate.Size = new System.Drawing.Size(157, 23);
            this.lbApplicationDate.TabIndex = 14;
            this.lbApplicationDate.Text = "Application Date:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(650, 528);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 50);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(569, 528);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 50);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlPersonDetails1
            // 
            this.ctrlPersonDetails1.Location = new System.Drawing.Point(14, 56);
            this.ctrlPersonDetails1.Name = "ctrlPersonDetails1";
            this.ctrlPersonDetails1.Size = new System.Drawing.Size(684, 318);
            this.ctrlPersonDetails1.TabIndex = 17;
            // 
            // frmNewLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 581);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tcLocalDrivingLicenseApplicationInfo);
            this.Controls.Add(this.lbTitle);
            this.Name = "frmNewLocalDrivingLicenseApplication";
            this.Text = "New Local Driving License Application";
            this.Load += new System.EventHandler(this.frmNewLocalDrivingLicenseApplication_Load);
            this.tcLocalDrivingLicenseApplicationInfo.ResumeLayout(false);
            this.tpPersonInfo.ResumeLayout(false);
            this.tpPersonInfo.PerformLayout();
            this.tpApplicationInfo.ResumeLayout(false);
            this.tpApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TabControl tcLocalDrivingLicenseApplicationInfo;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private System.Windows.Forms.TabPage tpApplicationInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lbDLApplicationIDValue;
        private System.Windows.Forms.Label lbDLApplicationID;
        private System.Windows.Forms.Label lbApplicationFees;
        private System.Windows.Forms.Label lbLicenseClass;
        private System.Windows.Forms.Label lbApplicationDate;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.ComboBox cbLicenseClasses;
        private System.Windows.Forms.Label lbApplicationFeesValue;
        private System.Windows.Forms.Label lbCreatedByValue;
        private System.Windows.Forms.Label lbApplicationDateValue;
        private System.Windows.Forms.Label lbFindBy;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox cbFindBy;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DVLD.ctrlPersonDetails ctrlPersonDetails1;
    }
}