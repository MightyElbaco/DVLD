namespace DVLD
{
    partial class frmAddUpdatePerson
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbAddNewUpdatePerson = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlAddUpdatePerson1 = new DVLD.ctrlAddUpdatePerson();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbAddNewUpdatePerson
            // 
            this.lbAddNewUpdatePerson.AutoSize = true;
            this.lbAddNewUpdatePerson.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddNewUpdatePerson.Location = new System.Drawing.Point(241, 8);
            this.lbAddNewUpdatePerson.Name = "lbAddNewUpdatePerson";
            this.lbAddNewUpdatePerson.Size = new System.Drawing.Size(209, 31);
            this.lbAddNewUpdatePerson.TabIndex = 1;
            this.lbAddNewUpdatePerson.Text = "Add New Person";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(621, 345);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 42);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(491, 345);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 42);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlAddUpdatePerson2
            // 
            this.ctrlAddUpdatePerson1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ctrlAddUpdatePerson1.Location = new System.Drawing.Point(12, 42);
            this.ctrlAddUpdatePerson1.Name = "ctrlAddUpdatePerson2";
            this.ctrlAddUpdatePerson1.Size = new System.Drawing.Size(690, 300);
            this.ctrlAddUpdatePerson1.TabIndex = 3;
            // 
            // frmAddUpdatePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(715, 391);
            this.Controls.Add(this.ctrlAddUpdatePerson1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbAddNewUpdatePerson);
            this.Name = "frmAddUpdatePerson";
            this.Text = "Add New/Update Person";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        //private ctrlAddUpdatePerson ctrlAddUpdatePerson1;
        private System.Windows.Forms.Label lbAddNewUpdatePerson;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private ctrlAddUpdatePerson ctrlAddUpdatePerson1;
    }
}