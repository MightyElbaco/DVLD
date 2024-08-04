using DVLDBusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD
{
    partial class ctrlAddUpdatePerson : UserControl
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
            this.components = new System.ComponentModel.Container();
            this.lbName = new System.Windows.Forms.Label();
            this.tbFirst = new System.Windows.Forms.TextBox();
            this.tbThird = new System.Windows.Forms.TextBox();
            this.tbLast = new System.Windows.Forms.TextBox();
            this.tbSecond = new System.Windows.Forms.TextBox();
            this.tbNationalNo = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbLast = new System.Windows.Forms.Label();
            this.lbThird = new System.Windows.Forms.Label();
            this.lbSecond = new System.Windows.Forms.Label();
            this.lbFirst = new System.Windows.Forms.Label();
            this.lbNationalNO = new System.Windows.Forms.Label();
            this.lbDateOfBirth = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.rtbAddress = new System.Windows.Forms.RichTextBox();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.lbPhone = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.llbSetImage = new System.Windows.Forms.LinkLabel();
            this.lbPersonIDt = new System.Windows.Forms.Label();
            this.lbPersonID = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbCountries = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(6, 56);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(56, 19);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name:";
            // 
            // tbFirst
            // 
            this.tbFirst.Location = new System.Drawing.Point(120, 59);
            this.tbFirst.Name = "tbFirst";
            this.tbFirst.Size = new System.Drawing.Size(100, 20);
            this.tbFirst.TabIndex = 1;
            // 
            // tbThird
            // 
            this.tbThird.Location = new System.Drawing.Point(364, 59);
            this.tbThird.Name = "tbThird";
            this.tbThird.Size = new System.Drawing.Size(100, 20);
            this.tbThird.TabIndex = 2;
            // 
            // tbLast
            // 
            this.tbLast.Location = new System.Drawing.Point(486, 59);
            this.tbLast.Name = "tbLast";
            this.tbLast.Size = new System.Drawing.Size(100, 20);
            this.tbLast.TabIndex = 3;
            // 
            // tbSecond
            // 
            this.tbSecond.Location = new System.Drawing.Point(242, 59);
            this.tbSecond.Name = "tbSecond";
            this.tbSecond.Size = new System.Drawing.Size(100, 20);
            this.tbSecond.TabIndex = 4;
            // 
            // tbNationalNo
            // 
            this.tbNationalNo.Location = new System.Drawing.Point(120, 94);
            this.tbNationalNo.Name = "tbNationalNo";
            this.tbNationalNo.Size = new System.Drawing.Size(100, 20);
            this.tbNationalNo.TabIndex = 6;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(120, 171);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 8;
            // 
            // lbLast
            // 
            this.lbLast.AutoSize = true;
            this.lbLast.Location = new System.Drawing.Point(520, 43);
            this.lbLast.Name = "lbLast";
            this.lbLast.Size = new System.Drawing.Size(27, 13);
            this.lbLast.TabIndex = 9;
            this.lbLast.Text = "Last";
            // 
            // lbThird
            // 
            this.lbThird.AutoSize = true;
            this.lbThird.Location = new System.Drawing.Point(397, 43);
            this.lbThird.Name = "lbThird";
            this.lbThird.Size = new System.Drawing.Size(31, 13);
            this.lbThird.TabIndex = 10;
            this.lbThird.Text = "Third";
            // 
            // lbSecond
            // 
            this.lbSecond.AutoSize = true;
            this.lbSecond.Location = new System.Drawing.Point(271, 43);
            this.lbSecond.Name = "lbSecond";
            this.lbSecond.Size = new System.Drawing.Size(42, 13);
            this.lbSecond.TabIndex = 11;
            this.lbSecond.Text = "Second";
            // 
            // lbFirst
            // 
            this.lbFirst.AutoSize = true;
            this.lbFirst.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbFirst.Location = new System.Drawing.Point(155, 43);
            this.lbFirst.Name = "lbFirst";
            this.lbFirst.Size = new System.Drawing.Size(28, 13);
            this.lbFirst.TabIndex = 12;
            this.lbFirst.Text = "First";
            // 
            // lbNationalNO
            // 
            this.lbNationalNO.AutoSize = true;
            this.lbNationalNO.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNationalNO.Location = new System.Drawing.Point(6, 92);
            this.lbNationalNO.Name = "lbNationalNO";
            this.lbNationalNO.Size = new System.Drawing.Size(96, 19);
            this.lbNationalNO.TabIndex = 13;
            this.lbNationalNO.Text = "NationalNO:";
            // 
            // lbDateOfBirth
            // 
            this.lbDateOfBirth.AutoSize = true;
            this.lbDateOfBirth.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateOfBirth.Location = new System.Drawing.Point(238, 95);
            this.lbDateOfBirth.Name = "lbDateOfBirth";
            this.lbDateOfBirth.Size = new System.Drawing.Size(107, 19);
            this.lbDateOfBirth.TabIndex = 14;
            this.lbDateOfBirth.Text = "Date Of Birth:";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(6, 130);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(66, 19);
            this.lbGender.TabIndex = 16;
            this.lbGender.Text = "Gender:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(6, 168);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(54, 19);
            this.lbEmail.TabIndex = 18;
            this.lbEmail.Text = "Email:";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(6, 208);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(72, 19);
            this.lbAddress.TabIndex = 19;
            this.lbAddress.Text = "Address:";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountry.Location = new System.Drawing.Point(238, 172);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(71, 19);
            this.lbCountry.TabIndex = 20;
            this.lbCountry.Text = "Country:";
            // 
            // rtbAddress
            // 
            this.rtbAddress.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtbAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbAddress.Location = new System.Drawing.Point(120, 201);
            this.rtbAddress.Name = "rtbAddress";
            this.rtbAddress.Size = new System.Drawing.Size(344, 96);
            this.rtbAddress.TabIndex = 21;
            this.rtbAddress.Text = "";
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Checked = true;
            this.rbtnMale.Location = new System.Drawing.Point(120, 132);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(47, 17);
            this.rbtnMale.TabIndex = 25;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            this.rbtnMale.CheckedChanged += new System.EventHandler(this.rbtnMale_CheckedChanged);
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(161, 133);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(59, 17);
            this.rbtnFemale.TabIndex = 26;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            this.rbtnFemale.CheckedChanged += new System.EventHandler(this.rbtnFemale_CheckedChanged);
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(238, 131);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(59, 19);
            this.lbPhone.TabIndex = 27;
            this.lbPhone.Text = "Phone:";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(364, 133);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(100, 20);
            this.tbPhone.TabIndex = 28;
            // 
            // llbSetImage
            // 
            this.llbSetImage.AutoSize = true;
            this.llbSetImage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbSetImage.Location = new System.Drawing.Point(620, 59);
            this.llbSetImage.Name = "llbSetImage";
            this.llbSetImage.Size = new System.Drawing.Size(66, 16);
            this.llbSetImage.TabIndex = 31;
            this.llbSetImage.TabStop = true;
            this.llbSetImage.Text = "Set Image";
            this.llbSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbSetImage_LinkClicked);
            // 
            // lbPersonIDt
            // 
            this.lbPersonIDt.AutoSize = true;
            this.lbPersonIDt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonIDt.Location = new System.Drawing.Point(6, 11);
            this.lbPersonIDt.Name = "lbPersonIDt";
            this.lbPersonIDt.Size = new System.Drawing.Size(80, 19);
            this.lbPersonIDt.TabIndex = 33;
            this.lbPersonIDt.Text = "PersonID:";
            // 
            // lbPersonID
            // 
            this.lbPersonID.AutoSize = true;
            this.lbPersonID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonID.Location = new System.Drawing.Point(116, 11);
            this.lbPersonID.Name = "lbPersonID";
            this.lbPersonID.Size = new System.Drawing.Size(54, 19);
            this.lbPersonID.TabIndex = 34;
            this.lbPersonID.Text = "*****";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(364, 97);
            this.dtpDateOfBirth.MaxDate = new System.DateTime(2006, 7, 27, 18, 59, 8, 603);
            this.dtpDateOfBirth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(100, 20);
            this.dtpDateOfBirth.TabIndex = 35;
            this.dtpDateOfBirth.Value = new System.DateTime(2004, 7, 24, 0, 0, 0, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::DVLD.Properties.Resources.person_man_200px;
            this.pictureBox1.Location = new System.Drawing.Point(486, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbCountries
            // 
            this.cbCountries.FormattingEnabled = true;
            this.cbCountries.Location = new System.Drawing.Point(364, 171);
            this.cbCountries.Name = "cbCountries";
            this.cbCountries.Size = new System.Drawing.Size(100, 21);
            this.cbCountries.TabIndex = 36;
            // 
            // ctrlAddUpdatePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.cbCountries);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.lbPersonID);
            this.Controls.Add(this.lbPersonIDt);
            this.Controls.Add(this.llbSetImage);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.rbtnFemale);
            this.Controls.Add(this.rbtnMale);
            this.Controls.Add(this.rtbAddress);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.lbDateOfBirth);
            this.Controls.Add(this.lbNationalNO);
            this.Controls.Add(this.lbFirst);
            this.Controls.Add(this.lbSecond);
            this.Controls.Add(this.lbThird);
            this.Controls.Add(this.lbLast);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbNationalNo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbSecond);
            this.Controls.Add(this.tbLast);
            this.Controls.Add(this.tbThird);
            this.Controls.Add(this.tbFirst);
            this.Controls.Add(this.lbName);
            this.Name = "ctrlAddUpdatePerson";
            this.Size = new System.Drawing.Size(693, 303);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbName;
        public System.Windows.Forms.TextBox tbFirst;
        public System.Windows.Forms.TextBox tbThird;
        public System.Windows.Forms.TextBox tbLast;
        public System.Windows.Forms.TextBox tbSecond;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox tbNationalNo;
        public System.Windows.Forms.TextBox tbEmail;
        public System.Windows.Forms.Label lbLast;
        public System.Windows.Forms.Label lbThird;
        public System.Windows.Forms.Label lbSecond;
        public System.Windows.Forms.Label lbFirst;
        public System.Windows.Forms.Label lbNationalNO;
        public System.Windows.Forms.Label lbDateOfBirth;
        public System.Windows.Forms.Label lbGender;
        public System.Windows.Forms.Label lbEmail;
        public System.Windows.Forms.Label lbAddress;
        public System.Windows.Forms.Label lbCountry;
        public System.Windows.Forms.RichTextBox rtbAddress;
        public System.Windows.Forms.RadioButton rbtnMale;
        public System.Windows.Forms.RadioButton rbtnFemale;
        public System.Windows.Forms.Label lbPhone;
        public System.Windows.Forms.TextBox tbPhone;
        public System.Windows.Forms.LinkLabel llbSetImage;
        public Label lbPersonIDt;
        public Label lbPersonID;
        public DateTimePicker dtpDateOfBirth;
        public ErrorProvider errorProvider1;
        public ComboBox cbCountries;
    }
}