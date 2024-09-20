namespace DVLD
{
    partial class frmShowUserDetails
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

        #endregion

        private ctrlUserDetails ctrlUserDetails1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbUserDetails;

        private void InitializeComponent()
        {
            this.ctrlUserDetails1 = new DVLD.ctrlUserDetails();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbUserDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlUserDetails1
            // 
            this.ctrlUserDetails1.Location = new System.Drawing.Point(12, 64);
            this.ctrlUserDetails1.Name = "ctrlUserDetails1";
            this.ctrlUserDetails1.Size = new System.Drawing.Size(690, 383);
            this.ctrlUserDetails1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(616, 453);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 42);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbUserDetails
            // 
            this.lbUserDetails.AutoSize = true;
            this.lbUserDetails.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserDetails.Location = new System.Drawing.Point(290, 9);
            this.lbUserDetails.Name = "lbUserDetails";
            this.lbUserDetails.Size = new System.Drawing.Size(158, 31);
            this.lbUserDetails.TabIndex = 4;
            this.lbUserDetails.Text = "User Details";
            // 
            // frmShowUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 499);
            this.Controls.Add(this.lbUserDetails);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlUserDetails1);
            this.Name = "frmShowUserDetails";
            this.Text = "frmShowUserDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}