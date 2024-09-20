using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword(int UserID)
        {
            InitializeComponent();
            this.ctrlUserDetails1.LoadUserDetails(UserID);
        }

        private bool ControlHasNoInputErrors(Control container, ErrorProvider errorProvider)
        {
            IEnumerable<System.Windows.Forms.TextBox> textboxes = container.Controls.OfType<System.Windows.Forms.TextBox>();
            foreach (System.Windows.Forms.TextBox textBox in textboxes)
            {
                if (errorProvider.GetError(textBox) == null)
                {
                    return false; // Early exit if an error is found
                }
            }
            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbCurrentPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCurrentPassword.Text))
            {
                errorProvider1.SetError(this.tbCurrentPassword, "Can't be empty dummy!");
                this.tbCurrentPassword.Focus();
            }
            else
            {
                errorProvider1.SetError(this.tbCurrentPassword, "");
            }
        }

        private void tbNewPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNewPassword.Text))
            {
                errorProvider1.SetError(this.tbNewPassword, "Can't be empty stupid ass ninja!");
                this.tbNewPassword.Focus();
            }
            else
            {
                errorProvider1.SetError(this.tbNewPassword, "");
            }
        }

        private void tbConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbConfirmPassword.Text) && tbConfirmPassword.Text == tbNewPassword.Text)
            {
                errorProvider1.SetError(this.tbConfirmPassword, "Can't be empty stupid ass ninja! and it must match of course!");
                this.tbConfirmPassword.Clear();
                this.tbConfirmPassword.Focus();
            }
            else
            {
                errorProvider1.SetError(this.tbConfirmPassword, "");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(ControlHasNoInputErrors(gbPasswordInfo, errorProvider1))
            {
                clsUser User = clsUser.Find(this.ctrlUserDetails1.lbUsernameValue.Text);

                if(User != null)
                {
                    User.PasswordHash = clsGeneralLib.HashPasswordWithSHA256(this.tbNewPassword.Text, User.HashingSalt);

                    User.Save();

                    MessageBox.Show("Done Ninja :)");

                    this.ctrlUserDetails1.Enabled = false;
                    this.gbPasswordInfo.Enabled = false;
                    this.btnSave.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Handle the erros ninja!");
            }
        }
    }
}