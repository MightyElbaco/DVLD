namespace DVLD
{
    partial class frmChangePassword
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
        /// 

        private ctrlUserDetails ctrlUserDetails1;
        private System.Windows.Forms.Label lbCurrentPassword;
        private System.Windows.Forms.Label lbConfirmPassword;
        private System.Windows.Forms.Label lbNewPassword;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbCurrentPassword;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.TextBox tbConfirmPassword;


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbCurrentPassword = new System.Windows.Forms.Label();
            this.lbConfirmPassword = new System.Windows.Forms.Label();
            this.lbNewPassword = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbCurrentPassword = new System.Windows.Forms.TextBox();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.ctrlUserDetails1 = new DVLD.ctrlUserDetails();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbPasswordInfo = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbPasswordInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCurrentPassword
            // 
            this.lbCurrentPassword.AutoSize = true;
            this.lbCurrentPassword.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentPassword.Location = new System.Drawing.Point(6, 38);
            this.lbCurrentPassword.Name = "lbCurrentPassword";
            this.lbCurrentPassword.Size = new System.Drawing.Size(165, 23);
            this.lbCurrentPassword.TabIndex = 15;
            this.lbCurrentPassword.Text = "Current Password:";
            // 
            // lbConfirmPassword
            // 
            this.lbConfirmPassword.AutoSize = true;
            this.lbConfirmPassword.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmPassword.Location = new System.Drawing.Point(6, 120);
            this.lbConfirmPassword.Name = "lbConfirmPassword";
            this.lbConfirmPassword.Size = new System.Drawing.Size(172, 23);
            this.lbConfirmPassword.TabIndex = 16;
            this.lbConfirmPassword.Text = "Confirm Password:";
            // 
            // lbNewPassword
            // 
            this.lbNewPassword.AutoSize = true;
            this.lbNewPassword.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewPassword.Location = new System.Drawing.Point(31, 79);
            this.lbNewPassword.Name = "lbNewPassword";
            this.lbNewPassword.Size = new System.Drawing.Size(140, 23);
            this.lbNewPassword.TabIndex = 17;
            this.lbNewPassword.Text = "New Password:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(524, 528);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 42);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(616, 528);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 42);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbCurrentPassword
            // 
            this.tbCurrentPassword.Location = new System.Drawing.Point(177, 41);
            this.tbCurrentPassword.Name = "tbCurrentPassword";
            this.tbCurrentPassword.Size = new System.Drawing.Size(181, 29);
            this.tbCurrentPassword.TabIndex = 20;
            this.tbCurrentPassword.Leave += new System.EventHandler(this.tbCurrentPassword_Leave);
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Location = new System.Drawing.Point(177, 82);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(181, 29);
            this.tbNewPassword.TabIndex = 21;
            this.tbNewPassword.Leave += new System.EventHandler(this.tbNewPassword_Leave);
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Location = new System.Drawing.Point(177, 120);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.Size = new System.Drawing.Size(181, 29);
            this.tbConfirmPassword.TabIndex = 22;
            this.tbConfirmPassword.Leave += new System.EventHandler(this.tbConfirmPassword_Leave);
            // 
            // ctrlUserDetails1
            // 
            this.ctrlUserDetails1.Location = new System.Drawing.Point(12, 12);
            this.ctrlUserDetails1.Name = "ctrlUserDetails1";
            this.ctrlUserDetails1.Size = new System.Drawing.Size(690, 383);
            this.ctrlUserDetails1.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // gbPasswordInfo
            // 
            this.gbPasswordInfo.Controls.Add(this.tbConfirmPassword);
            this.gbPasswordInfo.Controls.Add(this.tbNewPassword);
            this.gbPasswordInfo.Controls.Add(this.tbCurrentPassword);
            this.gbPasswordInfo.Controls.Add(this.lbNewPassword);
            this.gbPasswordInfo.Controls.Add(this.lbConfirmPassword);
            this.gbPasswordInfo.Controls.Add(this.lbCurrentPassword);
            this.gbPasswordInfo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPasswordInfo.Location = new System.Drawing.Point(12, 412);
            this.gbPasswordInfo.Name = "gbPasswordInfo";
            this.gbPasswordInfo.Size = new System.Drawing.Size(370, 152);
            this.gbPasswordInfo.TabIndex = 23;
            this.gbPasswordInfo.TabStop = false;
            this.gbPasswordInfo.Text = "Password Info";
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 576);
            this.Controls.Add(this.gbPasswordInfo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlUserDetails1);
            this.Name = "frmChangePassword";
            this.Text = "Change Password";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbPasswordInfo.ResumeLayout(false);
            this.gbPasswordInfo.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox gbPasswordInfo;
    }
}