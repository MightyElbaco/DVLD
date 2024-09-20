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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tsbtnPeople_Click(object sender, EventArgs e)
        {
            Form ManagePeople = new frmManagePeople(); //This will be the child form
            ManagePeople.MdiParent = this; //Set MDI parent
            ManagePeople.Show(); //Show it
        }

        private void tsbtnUsers_Click(object sender, EventArgs e)
        {
            Form ManageUsers = new frmManageUsers(); //This will be the child form
            ManageUsers.MdiParent = this; //Set MDI parent
            ManageUsers.Show(); //Show it
        }

        private void tmsiChangePassword_Click(object sender, EventArgs e)
        {
            Form ChangePassword = new frmChangePassword(clsGlobal.CurrentUser.UserID);
            ChangePassword.MdiParent = this;
            ChangePassword.Show();
        }

        private void tmsiCurrentUserInfo_Click(object sender, EventArgs e)
        {
            Form CurrentUser = new frmShowUserDetails(clsGlobal.CurrentUser.UserID);
            CurrentUser.MdiParent = this;
            CurrentUser.Show();
        }

        private void tmsiSignOut_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void tmsiManageApplicationTypes_Click(object sender, EventArgs e)
        {
            Form frmAppsTypes = new frmManageApplicationTypes();
            frmAppsTypes.ShowDialog();
        }

        private void tmsiManageTestTypes_Click(object sender, EventArgs e)
        {
            Form frmManageTestTypes = new frmManageTestTypes();
            frmManageTestTypes.ShowDialog();
        }

        private void tmsiLocalLicense_Click(object sender, EventArgs e)
        {
            Form AddNewLocalLicenseApplication = new frmNewLocalDrivingLicenseApplication();
            AddNewLocalLicenseApplication.ShowDialog();
        }

        private void tmsiLocalDrivingLicenseApplications_Click(object sender, EventArgs e)
        {
            Form frmLocalDrivingLicenseApplications = new frmLocalDrivingLicenseApplications();
            frmLocalDrivingLicenseApplications.ShowDialog();
        }
    }
}