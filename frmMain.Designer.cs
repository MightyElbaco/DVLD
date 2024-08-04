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
            this.tsbtnApplications = new System.Windows.Forms.ToolStripButton();
            this.tsbtnPeople = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDrivers = new System.Windows.Forms.ToolStripButton();
            this.tsbtnUsers = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAccountSettings = new System.Windows.Forms.ToolStripButton();
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
            this.tsbtnApplications.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnApplications.Image")));
            this.tsbtnApplications.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnApplications.Name = "tsbtnApplications";
            this.tsbtnApplications.Size = new System.Drawing.Size(109, 36);
            this.tsbtnApplications.Text = "Applications";
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
            this.tsbtnAccountSettings.Image = global::DVLD.Properties.Resources.Account_Settings;
            this.tsbtnAccountSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAccountSettings.Name = "tsbtnAccountSettings";
            this.tsbtnAccountSettings.Size = new System.Drawing.Size(133, 36);
            this.tsbtnAccountSettings.Text = "Account Settings";
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
        private System.Windows.Forms.ToolStripButton tsbtnApplications;
        private System.Windows.Forms.ToolStripButton tsbtnPeople;
        private System.Windows.Forms.ToolStripButton tsbtnDrivers;
        private System.Windows.Forms.ToolStripButton tsbtnUsers;
        private System.Windows.Forms.ToolStripButton tsbtnAccountSettings;
    }
}

