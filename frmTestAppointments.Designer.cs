namespace DVLD
{
    partial class frmTestAppointments
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
            this.lbTestTypeNameAppointment = new System.Windows.Forms.Label();
            this.ctrlDrivingLicenseApplicationInfo1 = new DVLD.ctrlDrivingLicenseApplicationInfo();
            this.ctrlApplicationBasicInformation1 = new DVLD.ctrlApplicationBasicInformation();
            this.ctrlAppointments1 = new DVLD.ctrlAppointments();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTestTypeNameAppointment
            // 
            this.lbTestTypeNameAppointment.AutoSize = true;
            this.lbTestTypeNameAppointment.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTestTypeNameAppointment.Location = new System.Drawing.Point(128, 9);
            this.lbTestTypeNameAppointment.Name = "lbTestTypeNameAppointment";
            this.lbTestTypeNameAppointment.Size = new System.Drawing.Size(338, 31);
            this.lbTestTypeNameAppointment.TabIndex = 0;
            this.lbTestTypeNameAppointment.Text = "Test Type Name Appointment";
            // 
            // ctrlDrivingLicenseApplicationInfo1
            // 
            this.ctrlDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(12, 71);
            this.ctrlDrivingLicenseApplicationInfo1.Name = "ctrlDrivingLicenseApplicationInfo1";
            this.ctrlDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(576, 112);
            this.ctrlDrivingLicenseApplicationInfo1.TabIndex = 1;
            // 
            // ctrlApplicationBasicInformation1
            // 
            this.ctrlApplicationBasicInformation1.Location = new System.Drawing.Point(12, 189);
            this.ctrlApplicationBasicInformation1.Name = "ctrlApplicationBasicInformation1";
            this.ctrlApplicationBasicInformation1.Size = new System.Drawing.Size(576, 187);
            this.ctrlApplicationBasicInformation1.TabIndex = 2;
            // 
            // ctrlAppointments1
            // 
            this.ctrlAppointments1.Location = new System.Drawing.Point(12, 382);
            this.ctrlAppointments1.Name = "ctrlAppointments1";
            this.ctrlAppointments1.Size = new System.Drawing.Size(570, 313);
            this.ctrlAppointments1.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(507, 701);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 36);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 749);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlAppointments1);
            this.Controls.Add(this.ctrlApplicationBasicInformation1);
            this.Controls.Add(this.ctrlDrivingLicenseApplicationInfo1);
            this.Controls.Add(this.lbTestTypeNameAppointment);
            this.Name = "frmTestAppointments";
            this.Text = "frmTestAppointments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTestTypeNameAppointment;
        private ctrlDrivingLicenseApplicationInfo ctrlDrivingLicenseApplicationInfo1;
        private ctrlApplicationBasicInformation ctrlApplicationBasicInformation1;
        private ctrlAppointments ctrlAppointments1;
        private System.Windows.Forms.Button btnClose;
    }
}