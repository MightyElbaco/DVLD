namespace DVLD
{
    partial class frmLocalDrivingLicenseApplications
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
            this.dgvLocalDrivingLicenseApplications = new System.Windows.Forms.DataGridView();
            this.cmsOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShowApplicationDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCancelApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.sechduleTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiScheduleVisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiScheduleWrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiScheduleStreet = new System.Windows.Forms.ToolStripMenuItem();
            this.issueDrivingLicenseFirstTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mtbFilter = new System.Windows.Forms.MaskedTextBox();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddApplication = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingLicenseApplications)).BeginInit();
            this.cmsOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLocalDrivingLicenseApplications
            // 
            this.dgvLocalDrivingLicenseApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalDrivingLicenseApplications.ContextMenuStrip = this.cmsOptions;
            this.dgvLocalDrivingLicenseApplications.Location = new System.Drawing.Point(12, 173);
            this.dgvLocalDrivingLicenseApplications.Name = "dgvLocalDrivingLicenseApplications";
            this.dgvLocalDrivingLicenseApplications.Size = new System.Drawing.Size(941, 266);
            this.dgvLocalDrivingLicenseApplications.TabIndex = 8;
            // 
            // cmsOptions
            // 
            this.cmsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowApplicationDetails,
            this.tsmiEditApplication,
            this.tsmiDeleteApplication,
            this.tsmiCancelApplication,
            this.sechduleTestToolStripMenuItem,
            this.issueDrivingLicenseFirstTimeToolStripMenuItem,
            this.showLicenseToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.cmsOptions.Name = "cmsOptions";
            this.cmsOptions.Size = new System.Drawing.Size(246, 180);
            // 
            // tsmiShowApplicationDetails
            // 
            this.tsmiShowApplicationDetails.Name = "tsmiShowApplicationDetails";
            this.tsmiShowApplicationDetails.Size = new System.Drawing.Size(245, 22);
            this.tsmiShowApplicationDetails.Text = "Show Application Details";
            this.tsmiShowApplicationDetails.Click += new System.EventHandler(this.tsmiShowApplicationDetails_Click);
            // 
            // tsmiEditApplication
            // 
            this.tsmiEditApplication.Name = "tsmiEditApplication";
            this.tsmiEditApplication.Size = new System.Drawing.Size(245, 22);
            this.tsmiEditApplication.Text = "Edit Application";
            this.tsmiEditApplication.Click += new System.EventHandler(this.tsmiEditApplication_Click);
            // 
            // tsmiDeleteApplication
            // 
            this.tsmiDeleteApplication.Name = "tsmiDeleteApplication";
            this.tsmiDeleteApplication.Size = new System.Drawing.Size(245, 22);
            this.tsmiDeleteApplication.Text = "Delete Application";
            this.tsmiDeleteApplication.Click += new System.EventHandler(this.tsmiDeleteApplication_Click);
            // 
            // tsmiCancelApplication
            // 
            this.tsmiCancelApplication.Name = "tsmiCancelApplication";
            this.tsmiCancelApplication.Size = new System.Drawing.Size(245, 22);
            this.tsmiCancelApplication.Text = "Cancel Application";
            this.tsmiCancelApplication.Click += new System.EventHandler(this.tsmiCancelApplication_Click);
            // 
            // sechduleTestToolStripMenuItem
            // 
            this.sechduleTestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiScheduleVisionTest,
            this.tsmiScheduleWrittenTest,
            this.tsmiScheduleStreet});
            this.sechduleTestToolStripMenuItem.Name = "sechduleTestToolStripMenuItem";
            this.sechduleTestToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.sechduleTestToolStripMenuItem.Text = "Sechdule Test";
            // 
            // tsmiScheduleVisionTest
            // 
            this.tsmiScheduleVisionTest.Name = "tsmiScheduleVisionTest";
            this.tsmiScheduleVisionTest.Size = new System.Drawing.Size(187, 22);
            this.tsmiScheduleVisionTest.Text = "Schedule Vision Test";
            this.tsmiScheduleVisionTest.Click += new System.EventHandler(this.tsmiScheduleVisionTest_Click);
            // 
            // tsmiScheduleWrittenTest
            // 
            this.tsmiScheduleWrittenTest.Name = "tsmiScheduleWrittenTest";
            this.tsmiScheduleWrittenTest.Size = new System.Drawing.Size(187, 22);
            this.tsmiScheduleWrittenTest.Text = "Schedule Written Test";
            // 
            // tsmiScheduleStreet
            // 
            this.tsmiScheduleStreet.Name = "tsmiScheduleStreet";
            this.tsmiScheduleStreet.Size = new System.Drawing.Size(187, 22);
            this.tsmiScheduleStreet.Text = "Schedule Street Test";
            // 
            // issueDrivingLicenseFirstTimeToolStripMenuItem
            // 
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Name = "issueDrivingLicenseFirstTimeToolStripMenuItem";
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Text = "Issue Driving License (First Time)";
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.showLicenseToolStripMenuItem.Text = "Show License";
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            // 
            // mtbFilter
            // 
            this.mtbFilter.Location = new System.Drawing.Point(270, 146);
            this.mtbFilter.Name = "mtbFilter";
            this.mtbFilter.Size = new System.Drawing.Size(197, 20);
            this.mtbFilter.TabIndex = 13;
            // 
            // cbFilters
            // 
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Items.AddRange(new object[] {
            "None",
            "L.D.L AppID",
            "Full Name",
            "Status"});
            this.cbFilters.Location = new System.Drawing.Point(65, 146);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(199, 21);
            this.cbFilters.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(9, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Filter By:";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(264, 42);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(477, 36);
            this.lbTitle.TabIndex = 9;
            this.lbTitle.Text = "Local Driving License Applications";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::DVLD.Properties.Resources.reload;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.Location = new System.Drawing.Point(906, 71);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(47, 46);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnAddApplication
            // 
            this.btnAddApplication.BackgroundImage = global::DVLD.Properties.Resources.add;
            this.btnAddApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddApplication.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddApplication.FlatAppearance.BorderSize = 0;
            this.btnAddApplication.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddApplication.Location = new System.Drawing.Point(906, 123);
            this.btnAddApplication.Name = "btnAddApplication";
            this.btnAddApplication.Size = new System.Drawing.Size(47, 44);
            this.btnAddApplication.TabIndex = 10;
            this.btnAddApplication.UseVisualStyleBackColor = true;
            // 
            // frmLocalDrivingLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvLocalDrivingLicenseApplications);
            this.Controls.Add(this.mtbFilter);
            this.Controls.Add(this.cbFilters);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddApplication);
            this.Controls.Add(this.lbTitle);
            this.Name = "frmLocalDrivingLicenseApplications";
            this.Text = "Local Driving License Applications";
            this.Load += new System.EventHandler(this.frmLocalDrivingLicenseApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingLicenseApplications)).EndInit();
            this.cmsOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvLocalDrivingLicenseApplications;
        private System.Windows.Forms.MaskedTextBox mtbFilter;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddApplication;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ContextMenuStrip cmsOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowApplicationDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditApplication;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteApplication;
        private System.Windows.Forms.ToolStripMenuItem tsmiCancelApplication;
        private System.Windows.Forms.ToolStripMenuItem sechduleTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiScheduleVisionTest;
        private System.Windows.Forms.ToolStripMenuItem tsmiScheduleWrittenTest;
        private System.Windows.Forms.ToolStripMenuItem tsmiScheduleStreet;
        private System.Windows.Forms.ToolStripMenuItem issueDrivingLicenseFirstTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
    }
}