using System.Drawing;

namespace DVLD
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnApplications = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiDrivingLicenseServices = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiNewDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiLocalLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiInternationalLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiRenewDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiReplaceForLostOrDamagedLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiReleaseDetaindDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiRetakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManageApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiLocalDrivingLicenseApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiInternationalDrivingLicenseApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDetainLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiManageApplicationTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManageTestTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnPeople = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDrivers = new System.Windows.Forms.ToolStripButton();
            this.tsbtnUsers = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAccountSettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiCurrentUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnApplications,
            this.tsbtnPeople,
            this.tsbtnDrivers,
            this.tsbtnUsers,
            this.tsbtnAccountSettings});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(927, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnApplications
            // 
            this.tsbtnApplications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDrivingLicenseServices,
            this.tsmiManageApplications,
            this.tsmiDetainLicenses,
            this.tmsiManageApplicationTypes,
            this.tsmiManageTestTypes});
            this.tsbtnApplications.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnApplications.Image")));
            this.tsbtnApplications.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnApplications.Name = "tsbtnApplications";
            this.tsbtnApplications.Size = new System.Drawing.Size(118, 36);
            this.tsbtnApplications.Text = "Applications";
            // 
            // tsmiDrivingLicenseServices
            // 
            this.tsmiDrivingLicenseServices.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsiNewDrivingLicense,
            this.tmsiRenewDrivingLicense,
            this.tmsiReplaceForLostOrDamagedLicense,
            this.tmsiReleaseDetaindDrivingLicense,
            this.tmsiRetakeTest});
            this.tsmiDrivingLicenseServices.Name = "tsmiDrivingLicenseServices";
            this.tsmiDrivingLicenseServices.Size = new System.Drawing.Size(213, 22);
            this.tsmiDrivingLicenseServices.Text = "Driving Licenses Services";
            // 
            // tmsiNewDrivingLicense
            // 
            this.tmsiNewDrivingLicense.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsiLocalLicense,
            this.tmsiInternationalLicense});
            this.tmsiNewDrivingLicense.Name = "tmsiNewDrivingLicense";
            this.tmsiNewDrivingLicense.Size = new System.Drawing.Size(300, 22);
            this.tmsiNewDrivingLicense.Text = "New Driving License";
            // 
            // tmsiLocalLicense
            // 
            this.tmsiLocalLicense.Name = "tmsiLocalLicense";
            this.tmsiLocalLicense.Size = new System.Drawing.Size(183, 22);
            this.tmsiLocalLicense.Text = "Local License";
            this.tmsiLocalLicense.Click += new System.EventHandler(this.tmsiLocalLicense_Click);
            // 
            // tmsiInternationalLicense
            // 
            this.tmsiInternationalLicense.Name = "tmsiInternationalLicense";
            this.tmsiInternationalLicense.Size = new System.Drawing.Size(183, 22);
            this.tmsiInternationalLicense.Text = "International License";
            // 
            // tmsiRenewDrivingLicense
            // 
            this.tmsiRenewDrivingLicense.Name = "tmsiRenewDrivingLicense";
            this.tmsiRenewDrivingLicense.Size = new System.Drawing.Size(300, 22);
            this.tmsiRenewDrivingLicense.Text = "Renew Driving License";
            // 
            // tmsiReplaceForLostOrDamagedLicense
            // 
            this.tmsiReplaceForLostOrDamagedLicense.Name = "tmsiReplaceForLostOrDamagedLicense";
            this.tmsiReplaceForLostOrDamagedLicense.Size = new System.Drawing.Size(300, 22);
            this.tmsiReplaceForLostOrDamagedLicense.Text = "Replacement For Lost Or Damaged License";
            // 
            // tmsiReleaseDetaindDrivingLicense
            // 
            this.tmsiReleaseDetaindDrivingLicense.Name = "tmsiReleaseDetaindDrivingLicense";
            this.tmsiReleaseDetaindDrivingLicense.Size = new System.Drawing.Size(300, 22);
            this.tmsiReleaseDetaindDrivingLicense.Text = "Release Detaind Driving License";
            // 
            // tmsiRetakeTest
            // 
            this.tmsiRetakeTest.Name = "tmsiRetakeTest";
            this.tmsiRetakeTest.Size = new System.Drawing.Size(300, 22);
            this.tmsiRetakeTest.Text = "Retake Test";
            // 
            // tsmiManageApplications
            // 
            this.tsmiManageApplications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsiLocalDrivingLicenseApplications,
            this.tmsiInternationalDrivingLicenseApplications});
            this.tsmiManageApplications.Name = "tsmiManageApplications";
            this.tsmiManageApplications.Size = new System.Drawing.Size(213, 22);
            this.tsmiManageApplications.Text = "Manage Applictions";
            // 
            // tmsiLocalDrivingLicenseApplications
            // 
            this.tmsiLocalDrivingLicenseApplications.Name = "tmsiLocalDrivingLicenseApplications";
            this.tmsiLocalDrivingLicenseApplications.Size = new System.Drawing.Size(293, 22);
            this.tmsiLocalDrivingLicenseApplications.Text = "Local Driving License Applications";
            this.tmsiLocalDrivingLicenseApplications.Click += new System.EventHandler(this.tmsiLocalDrivingLicenseApplications_Click);
            // 
            // tmsiInternationalDrivingLicenseApplications
            // 
            this.tmsiInternationalDrivingLicenseApplications.Name = "tmsiInternationalDrivingLicenseApplications";
            this.tmsiInternationalDrivingLicenseApplications.Size = new System.Drawing.Size(293, 22);
            this.tmsiInternationalDrivingLicenseApplications.Text = "International Driving License Applications";
            // 
            // tsmiDetainLicenses
            // 
            this.tsmiDetainLicenses.Name = "tsmiDetainLicenses";
            this.tsmiDetainLicenses.Size = new System.Drawing.Size(213, 22);
            this.tsmiDetainLicenses.Text = "Detain Licenses";
            // 
            // tmsiManageApplicationTypes
            // 
            this.tmsiManageApplicationTypes.Name = "tmsiManageApplicationTypes";
            this.tmsiManageApplicationTypes.Size = new System.Drawing.Size(213, 22);
            this.tmsiManageApplicationTypes.Text = "Manage Application Types";
            this.tmsiManageApplicationTypes.Click += new System.EventHandler(this.tmsiManageApplicationTypes_Click);
            // 
            // tsmiManageTestTypes
            // 
            this.tsmiManageTestTypes.Name = "tsmiManageTestTypes";
            this.tsmiManageTestTypes.Size = new System.Drawing.Size(213, 22);
            this.tsmiManageTestTypes.Text = "Manage Test Types";
            this.tsmiManageTestTypes.Click += new System.EventHandler(this.tmsiManageTestTypes_Click);
            // 
            // tsbtnPeople
            // 
            this.tsbtnPeople.Image = global::DVLD.Properties.Resources.human_resources;
            this.tsbtnPeople.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPeople.Name = "tsbtnPeople";
            this.tsbtnPeople.Size = new System.Drawing.Size(79, 36);
            this.tsbtnPeople.Text = "People";
            this.tsbtnPeople.Click += new System.EventHandler(this.tsbtnPeople_Click);
            // 
            // tsbtnDrivers
            // 
            this.tsbtnDrivers.Image = global::DVLD.Properties.Resources.driver;
            this.tsbtnDrivers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDrivers.Name = "tsbtnDrivers";
            this.tsbtnDrivers.Size = new System.Drawing.Size(79, 36);
            this.tsbtnDrivers.Text = "Drivers";
            // 
            // tsbtnUsers
            // 
            this.tsbtnUsers.Image = global::DVLD.Properties.Resources.member;
            this.tsbtnUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUsers.Name = "tsbtnUsers";
            this.tsbtnUsers.Size = new System.Drawing.Size(71, 36);
            this.tsbtnUsers.Text = "Users";
            this.tsbtnUsers.Click += new System.EventHandler(this.tsbtnUsers_Click);
            // 
            // tsbtnAccountSettings
            // 
            this.tsbtnAccountSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCurrentUserInfo,
            this.tmsiChangePassword,
            this.tmsiSignOut});
            this.tsbtnAccountSettings.Image = global::DVLD.Properties.Resources.Account_Settings;
            this.tsbtnAccountSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAccountSettings.Name = "tsbtnAccountSettings";
            this.tsbtnAccountSettings.Size = new System.Drawing.Size(142, 36);
            this.tsbtnAccountSettings.Text = "Account Settings";
            // 
            // tsmiCurrentUserInfo
            // 
            this.tsmiCurrentUserInfo.Name = "tsmiCurrentUserInfo";
            this.tsmiCurrentUserInfo.Size = new System.Drawing.Size(168, 22);
            this.tsmiCurrentUserInfo.Text = "Current User Info";
            this.tsmiCurrentUserInfo.Click += new System.EventHandler(this.tmsiCurrentUserInfo_Click);
            // 
            // tmsiChangePassword
            // 
            this.tmsiChangePassword.Name = "tmsiChangePassword";
            this.tmsiChangePassword.Size = new System.Drawing.Size(168, 22);
            this.tmsiChangePassword.Text = "Change Password";
            this.tmsiChangePassword.Click += new System.EventHandler(this.tmsiChangePassword_Click);
            // 
            // tmsiSignOut
            // 
            this.tmsiSignOut.Name = "tmsiSignOut";
            this.tmsiSignOut.Size = new System.Drawing.Size(168, 22);
            this.tmsiSignOut.Text = "Sign Out";
            this.tmsiSignOut.Click += new System.EventHandler(this.tmsiSignOut_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 486);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Main";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnPeople;
        private System.Windows.Forms.ToolStripButton tsbtnDrivers;
        private System.Windows.Forms.ToolStripButton tsbtnUsers;
        private System.Windows.Forms.ToolStripDropDownButton tsbtnAccountSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiCurrentUserInfo;
        private System.Windows.Forms.ToolStripMenuItem tmsiChangePassword;
        private System.Windows.Forms.ToolStripMenuItem tmsiSignOut;
        private System.Windows.Forms.ToolStripDropDownButton tsbtnApplications;
        private System.Windows.Forms.ToolStripMenuItem tsmiDrivingLicenseServices;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageApplications;
        private System.Windows.Forms.ToolStripMenuItem tsmiDetainLicenses;
        private System.Windows.Forms.ToolStripMenuItem tmsiManageApplicationTypes;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageTestTypes;
        private System.Windows.Forms.ToolStripMenuItem tmsiNewDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem tmsiLocalLicense;
        private System.Windows.Forms.ToolStripMenuItem tmsiInternationalLicense;
        private System.Windows.Forms.ToolStripMenuItem tmsiRenewDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem tmsiReplaceForLostOrDamagedLicense;
        private System.Windows.Forms.ToolStripMenuItem tmsiReleaseDetaindDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem tmsiRetakeTest;
        private System.Windows.Forms.ToolStripMenuItem tmsiLocalDrivingLicenseApplications;
        private System.Windows.Forms.ToolStripMenuItem tmsiInternationalDrivingLicenseApplications;
    }
}

