namespace DVLD
{
    partial class frmLicenseHistory
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
            this.lbLicenseHistory = new System.Windows.Forms.Label();
            this.ctrlPersonDetails1 = new DVLD.ctrlPersonDetails();
            this.ctrlFilter1 = new DVLD.ctrlFilter();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbRecords = new System.Windows.Forms.Label();
            this.tcLicenseHistory = new System.Windows.Forms.TabControl();
            this.tpLocal = new System.Windows.Forms.TabPage();
            this.tpInternational = new System.Windows.Forms.TabPage();
            this.dgvLocalLicenses = new System.Windows.Forms.DataGridView();
            this.dgvInternationalLicenses = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.tcLicenseHistory.SuspendLayout();
            this.tpLocal.SuspendLayout();
            this.tpInternational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLicenseHistory
            // 
            this.lbLicenseHistory.AutoSize = true;
            this.lbLicenseHistory.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicenseHistory.Location = new System.Drawing.Point(260, 9);
            this.lbLicenseHistory.Name = "lbLicenseHistory";
            this.lbLicenseHistory.Size = new System.Drawing.Size(184, 31);
            this.lbLicenseHistory.TabIndex = 2;
            this.lbLicenseHistory.Text = "License History";
            // 
            // ctrlPersonDetails1
            // 
            this.ctrlPersonDetails1.Location = new System.Drawing.Point(12, 111);
            this.ctrlPersonDetails1.Name = "ctrlPersonDetails1";
            this.ctrlPersonDetails1.Size = new System.Drawing.Size(684, 297);
            this.ctrlPersonDetails1.TabIndex = 3;
            // 
            // ctrlFilter1
            // 
            this.ctrlFilter1.Location = new System.Drawing.Point(12, 67);
            this.ctrlFilter1.Name = "ctrlFilter1";
            this.ctrlFilter1.Size = new System.Drawing.Size(558, 38);
            this.ctrlFilter1.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(624, 697);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 50);
            this.btnClose.TabIndex = 36;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tcLicenseHistory);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 414);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 277);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver Licenses";
            // 
            // lbRecords
            // 
            this.lbRecords.AutoSize = true;
            this.lbRecords.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecords.Location = new System.Drawing.Point(12, 709);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(100, 23);
            this.lbRecords.TabIndex = 38;
            this.lbRecords.Text = "#Records: ";
            // 
            // tcLicenseHistory
            // 
            this.tcLicenseHistory.Controls.Add(this.tpLocal);
            this.tcLicenseHistory.Controls.Add(this.tpInternational);
            this.tcLicenseHistory.Location = new System.Drawing.Point(6, 22);
            this.tcLicenseHistory.Name = "tcLicenseHistory";
            this.tcLicenseHistory.SelectedIndex = 0;
            this.tcLicenseHistory.Size = new System.Drawing.Size(675, 255);
            this.tcLicenseHistory.TabIndex = 0;
            // 
            // tpLocal
            // 
            this.tpLocal.Controls.Add(this.dgvLocalLicenses);
            this.tpLocal.Location = new System.Drawing.Point(4, 25);
            this.tpLocal.Name = "tpLocal";
            this.tpLocal.Padding = new System.Windows.Forms.Padding(3);
            this.tpLocal.Size = new System.Drawing.Size(667, 226);
            this.tpLocal.TabIndex = 0;
            this.tpLocal.Text = "Local";
            this.tpLocal.UseVisualStyleBackColor = true;
            // 
            // tpInternational
            // 
            this.tpInternational.Controls.Add(this.dgvInternationalLicenses);
            this.tpInternational.Location = new System.Drawing.Point(4, 25);
            this.tpInternational.Name = "tpInternational";
            this.tpInternational.Padding = new System.Windows.Forms.Padding(3);
            this.tpInternational.Size = new System.Drawing.Size(667, 226);
            this.tpInternational.TabIndex = 1;
            this.tpInternational.Text = "International";
            this.tpInternational.UseVisualStyleBackColor = true;
            // 
            // dgvLocalLicenses
            // 
            this.dgvLocalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalLicenses.Location = new System.Drawing.Point(5, 6);
            this.dgvLocalLicenses.Name = "dgvLocalLicenses";
            this.dgvLocalLicenses.Size = new System.Drawing.Size(655, 214);
            this.dgvLocalLicenses.TabIndex = 0;
            // 
            // dgvInternationalLicenses
            // 
            this.dgvInternationalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternationalLicenses.Location = new System.Drawing.Point(6, 6);
            this.dgvInternationalLicenses.Name = "dgvInternationalLicenses";
            this.dgvInternationalLicenses.Size = new System.Drawing.Size(655, 214);
            this.dgvInternationalLicenses.TabIndex = 1;
            // 
            // frmLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 749);
            this.Controls.Add(this.lbRecords);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlFilter1);
            this.Controls.Add(this.ctrlPersonDetails1);
            this.Controls.Add(this.lbLicenseHistory);
            this.Name = "frmLicenseHistory";
            this.Text = "frmLicenseHistory";
            this.groupBox1.ResumeLayout(false);
            this.tcLicenseHistory.ResumeLayout(false);
            this.tpLocal.ResumeLayout(false);
            this.tpInternational.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLicenseHistory;
        private ctrlPersonDetails ctrlPersonDetails1;
        private ctrlFilter ctrlFilter1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbRecords;
        private System.Windows.Forms.TabControl tcLicenseHistory;
        private System.Windows.Forms.TabPage tpLocal;
        private System.Windows.Forms.TabPage tpInternational;
        private System.Windows.Forms.DataGridView dgvLocalLicenses;
        private System.Windows.Forms.DataGridView dgvInternationalLicenses;
    }
}