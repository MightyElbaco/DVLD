using DVLDBusinessLayer;
using System.Data;
using System.Drawing;

namespace DVLD
{
    partial class frmManagePeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagePeople));
            this.lbManagePeople = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.mtbFilter = new System.Windows.Forms.MaskedTextBox();
            this.cmsOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.btnRefreshdgvPeople = new System.Windows.Forms.Button();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.cmsOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // lbManagePeople
            // 
            this.lbManagePeople.AutoSize = true;
            this.lbManagePeople.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManagePeople.Location = new System.Drawing.Point(350, 41);
            this.lbManagePeople.Name = "lbManagePeople";
            this.lbManagePeople.Size = new System.Drawing.Size(219, 36);
            this.lbManagePeople.TabIndex = 1;
            this.lbManagePeople.Text = "Manage People";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter By:";
            // 
            // cbFilters
            // 
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Location = new System.Drawing.Point(68, 145);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(199, 21);
            this.cbFilters.TabIndex = 4;
            this.cbFilters.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged);
            // 
            // mtbFilter
            // 
            this.mtbFilter.Location = new System.Drawing.Point(273, 145);
            this.mtbFilter.Name = "mtbFilter";
            this.mtbFilter.Size = new System.Drawing.Size(197, 20);
            this.mtbFilter.TabIndex = 5;
            this.mtbFilter.TextChanged += new System.EventHandler(this.mtbFilter_TextChanged);
            // 
            // cmsOptions
            // 
            this.cmsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddNew,
            this.tmsiDelete,
            this.tsmiUpdate,
            this.showDetailsToolStripMenuItem});
            this.cmsOptions.Name = "contextMenuStrip1";
            this.cmsOptions.Size = new System.Drawing.Size(142, 92);
            // 
            // tsmiAddNew
            // 
            this.tsmiAddNew.Name = "tsmiAddNew";
            this.tsmiAddNew.Size = new System.Drawing.Size(141, 22);
            this.tsmiAddNew.Text = "Add New";
            this.tsmiAddNew.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // tmsiDelete
            // 
            this.tmsiDelete.Name = "tmsiDelete";
            this.tmsiDelete.Size = new System.Drawing.Size(141, 22);
            this.tmsiDelete.Text = "Delete";
            this.tmsiDelete.Click += new System.EventHandler(this.tmsiDelete_Click);
            // 
            // tsmiUpdate
            // 
            this.tsmiUpdate.Name = "tsmiUpdate";
            this.tsmiUpdate.Size = new System.Drawing.Size(141, 22);
            this.tsmiUpdate.Text = "Update";
            this.tsmiUpdate.Click += new System.EventHandler(this.tsmiUpdate_Click);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.tmsiShowDetails_Click);
            // 
            // dgvPeople
            // 
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeople.ContextMenuStrip = this.cmsOptions;
            this.dgvPeople.Location = new System.Drawing.Point(15, 172);
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.Size = new System.Drawing.Size(941, 266);
            this.dgvPeople.TabIndex = 0;
            // 
            // btnRefreshdgvPeople
            // 
            this.btnRefreshdgvPeople.BackgroundImage = global::DVLD.Properties.Resources.reload;
            this.btnRefreshdgvPeople.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefreshdgvPeople.Location = new System.Drawing.Point(909, 70);
            this.btnRefreshdgvPeople.Name = "btnRefreshdgvPeople";
            this.btnRefreshdgvPeople.Size = new System.Drawing.Size(47, 46);
            this.btnRefreshdgvPeople.TabIndex = 7;
            this.btnRefreshdgvPeople.UseVisualStyleBackColor = true;
            this.btnRefreshdgvPeople.Click += new System.EventHandler(this.btnRefreshdgvPeople_Click);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.BackgroundImage = global::DVLD.Properties.Resources.chieff_of_staff;
            this.btnAddPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddPerson.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddPerson.FlatAppearance.BorderSize = 0;
            this.btnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddPerson.Location = new System.Drawing.Point(909, 122);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(47, 44);
            this.btnAddPerson.TabIndex = 2;
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // frmManagePeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 450);
            this.Controls.Add(this.btnRefreshdgvPeople);
            this.Controls.Add(this.dgvPeople);
            this.Controls.Add(this.mtbFilter);
            this.Controls.Add(this.cbFilters);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.lbManagePeople);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManagePeople";
            this.Text = "ManagePeople";
            this.Load += new System.EventHandler(this.frmManagePeople_Load);
            this.cmsOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbManagePeople;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.MaskedTextBox mtbFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalityCountryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip cmsOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddNew;
        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.ToolStripMenuItem tmsiDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdate;
        private System.Windows.Forms.Button btnRefreshdgvPeople;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
    }
}