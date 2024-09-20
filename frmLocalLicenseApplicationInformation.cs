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
    public partial class frmLocalLicenseApplicationInformation : Form
    {
        public void LoadApplicationDetails(int ApplicationID)
        {
            //Get L.D App info
            clsLocalDrivingLicenseApplication LicenseApplication = clsLocalDrivingLicenseApplication.Find(ApplicationID);

            //Make sure its not null
            if(LicenseApplication == null)
            {
                MessageBox.Show("Error! Couldn't find application data!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Get L.D.L App info
            clsLocalDrivingLicenseApplications_View LDLAppView = clsLocalDrivingLicenseApplications_View.Find(ApplicationID);

            //Load basic Personal Info
            this.lbFullNameValue.Text = LDLAppView.FullName;
            this.lbNationalNOValue.Text = LDLAppView.NationalNO;

            //Load basic Application info
            this.ctrlApplicationBasicInformation1.LoadApplicationBasicInformation(ApplicationID);

            //Load Application Details
            this.lbApplicationIssueDateValue.Text = LDLAppView.ApplicationDate.ToShortDateString();
            this.lbPassedTestsValue.Text = LDLAppView.PassedTestsCount.ToString();
            this.lbDrivingClassValue.Text = LDLAppView.ClassName;
        }

        public frmLocalLicenseApplicationInformation()
        {
            InitializeComponent();
        }

        public frmLocalLicenseApplicationInformation(int ApplicationID)
        {
            InitializeComponent();
            LoadApplicationDetails(ApplicationID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}