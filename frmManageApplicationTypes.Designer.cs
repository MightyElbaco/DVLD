namespace DVLD
{
    partial class frmManageApplicationTypes
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
            this.dgvApplicationTypes = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbNumberOfRecords = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.cmsOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmsiChangeApplicationFees = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationTypes)).BeginInit();
            this.cmsOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvApplicationTypes
            // 
            this.dgvApplicationTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplicationTypes.ContextMenuStrip = this.cmsOptions;
            this.dgvApplicationTypes.Location = new System.Drawing.Point(12, 165);
            this.dgvApplicationTypes.Name = "dgvApplicationTypes";
            this.dgvApplicationTypes.Size = new System.Drawing.Size(560, 337);
            this.dgvApplicationTypes.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(497, 508);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 50);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbNumberOfRecords
            // 
            this.lbNumberOfRecords.AutoSize = true;
            this.lbNumberOfRecords.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberOfRecords.Location = new System.Drawing.Point(12, 523);
            this.lbNumberOfRecords.Name = "lbNumberOfRecords";
            this.lbNumberOfRecords.Size = new System.Drawing.Size(72, 19);
            this.lbNumberOfRecords.TabIndex = 2;
            this.lbNumberOfRecords.Text = "#Records ";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(115, 82);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(350, 36);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "Manage Application Types";
            // 
            // cmsOptions
            // 
            this.cmsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsiChangeApplicationFees});
            this.cmsOptions.Name = "cmsOptions";
            this.cmsOptions.Size = new System.Drawing.Size(206, 48);
            // 
            // tmsiChangeApplicationFees
            // 
            this.tmsiChangeApplicationFees.Name = "tmsiChangeApplicationFees";
            this.tmsiChangeApplicationFees.Size = new System.Drawing.Size(205, 22);
            this.tmsiChangeApplicationFees.Text = "Change Application Fees";
            this.tmsiChangeApplicationFees.Click += new System.EventHandler(this.tmsiChangeApplicationFees_Click);
            // 
            // frmManageApplicationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbNumberOfRecords);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvApplicationTypes);
            this.Name = "frmManageApplicationTypes";
            this.Load += new System.EventHandler(this.frmManageApplicationTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationTypes)).EndInit();
            this.cmsOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvApplicationTypes;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbNumberOfRecords;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ContextMenuStrip cmsOptions;
        private System.Windows.Forms.ToolStripMenuItem tmsiChangeApplicationFees;
    }
}