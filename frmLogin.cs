using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace DVLD
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void FillLoginInfo()
        {
            string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";
            string ValueName = "UPLoginInfo";


            try
            {
                // Read the value from the Registry
                string value = Registry.GetValue(KeyPath, ValueName, null) as string;


                if (value != null)
                {
                    string[] result = value.Split(new string[] { "#/#/#" }, StringSplitOptions.None);

                    this.tbUsername.Text = result[0];
                    this.tbPassword.Text = result[1];

                    this.ckbRememberMe.Checked = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
 
        private void SaveLoginInfoToWinReg()
        {
            string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";
            string ValueName = "UPLoginInfo";
            string ValueData = tbUsername.Text + "#/#/#" + tbPassword.Text;

            try
            {
                Registry.SetValue(KeyPath, ValueName, ValueData);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetLoginInfo()
        {
            string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";
            string ValueName = "UPLoginInfo";
            string ValueData = "#/#/#";

            try
            {
                Registry.SetValue(KeyPath, ValueName, ValueData);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsUser User =  clsUser.Find(tbUsername.Text);

            if (User != null)
            {
                if (User.PasswordHash == clsGeneralLib.HashPasswordWithSHA256(tbPassword.Text, User.HashingSalt))
                {
                    if (ckbRememberMe.Checked)
                    {
                        SaveLoginInfoToWinReg();
                    }
                    else
                    {
                        ResetLoginInfo();
                    }

                    //Save Current User
                    clsGlobal.CurrentUser = User;

                    Form Main = new frmMain();
                    Main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("\aInvalid Login Info!");
                }
            }
            else
            {
                MessageBox.Show("\aInvalid Login Info!");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            FillLoginInfo();
        }
    }
}