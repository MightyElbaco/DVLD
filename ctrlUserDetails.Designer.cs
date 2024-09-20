namespace DVLD
{
    partial class ctrlUserDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbPersonInfo = new System.Windows.Forms.GroupBox();
            this.lbIsActiveValue = new System.Windows.Forms.Label();
            this.lbIsActive = new System.Windows.Forms.Label();
            this.lbUserIDValue = new System.Windows.Forms.Label();
            this.lbUserID = new System.Windows.Forms.Label();
            this.lbUsernameValue = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.ctrlPersonDetails1 = new DVLD.ctrlPersonDetails();
            this.gbPersonInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPersonInfo
            // 
            this.gbPersonInfo.Controls.Add(this.lbIsActiveValue);
            this.gbPersonInfo.Controls.Add(this.lbIsActive);
            this.gbPersonInfo.Controls.Add(this.lbUserIDValue);
            this.gbPersonInfo.Controls.Add(this.lbUserID);
            this.gbPersonInfo.Controls.Add(this.lbUsernameValue);
            this.gbPersonInfo.Controls.Add(this.lbUsername);
            this.gbPersonInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPersonInfo.Location = new System.Drawing.Point(3, 306);
            this.gbPersonInfo.Name = "gbPersonInfo";
            this.gbPersonInfo.Size = new System.Drawing.Size(684, 76);
            this.gbPersonInfo.TabIndex = 1;
            this.gbPersonInfo.TabStop = false;
            this.gbPersonInfo.Text = "Login Information";
            // 
            // lbIsActiveValue
            // 
            this.lbIsActiveValue.AutoSize = true;
            this.lbIsActiveValue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIsActiveValue.Location = new System.Drawing.Point(591, 36);
            this.lbIsActiveValue.Name = "lbIsActiveValue";
            this.lbIsActiveValue.Size = new System.Drawing.Size(60, 19);
            this.lbIsActiveValue.TabIndex = 9;
            this.lbIsActiveValue.Text = "Yes/No";
            // 
            // lbIsActive
            // 
            this.lbIsActive.AutoSize = true;
            this.lbIsActive.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIsActive.Location = new System.Drawing.Point(507, 36);
            this.lbIsActive.Name = "lbIsActive";
            this.lbIsActive.Size = new System.Drawing.Size(78, 19);
            this.lbIsActive.TabIndex = 8;
            this.lbIsActive.Text = "Is Active?";
            // 
            // lbUserIDValue
            // 
            this.lbUserIDValue.AutoSize = true;
            this.lbUserIDValue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserIDValue.Location = new System.Drawing.Point(76, 36);
            this.lbUserIDValue.Name = "lbUserIDValue";
            this.lbUserIDValue.Size = new System.Drawing.Size(58, 19);
            this.lbUserIDValue.TabIndex = 7;
            this.lbUserIDValue.Text = "UserID";
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserID.Location = new System.Drawing.Point(6, 36);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(64, 19);
            this.lbUserID.TabIndex = 6;
            this.lbUserID.Text = "UserID:";
            // 
            // lbUsernameValue
            // 
            this.lbUsernameValue.AutoSize = true;
            this.lbUsernameValue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsernameValue.Location = new System.Drawing.Point(330, 36);
            this.lbUsernameValue.Name = "lbUsernameValue";
            this.lbUsernameValue.Size = new System.Drawing.Size(78, 19);
            this.lbUsernameValue.TabIndex = 5;
            this.lbUsernameValue.Text = "username";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(247, 36);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(77, 19);
            this.lbUsername.TabIndex = 4;
            this.lbUsername.Text = "Userame:";
            // 
            // ctrlPersonDetails1
            // 
            this.ctrlPersonDetails1.Location = new System.Drawing.Point(3, 3);
            this.ctrlPersonDetails1.Name = "ctrlPersonDetails1";
            this.ctrlPersonDetails1.Size = new System.Drawing.Size(684, 319);
            this.ctrlPersonDetails1.TabIndex = 2;
            // 
            // ctrlUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlPersonDetails1);
            this.Controls.Add(this.gbPersonInfo);
            this.Name = "ctrlUserDetails";
            this.Size = new System.Drawing.Size(690, 383);
            this.gbPersonInfo.ResumeLayout(false);
            this.gbPersonInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.GroupBox gbPersonInfo;
        public System.Windows.Forms.Label lbUsernameValue;
        public System.Windows.Forms.Label lbUsername;
        public System.Windows.Forms.Label lbUserIDValue;
        public System.Windows.Forms.Label lbUserID;
        public System.Windows.Forms.Label lbIsActiveValue;
        public System.Windows.Forms.Label lbIsActive;
        public ctrlPersonDetails ctrlPersonDetails1;
    }
}
