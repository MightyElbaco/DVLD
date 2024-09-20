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
    public partial class ctrlApplicationBasicInformation : UserControl
    {
        public void LoadApplicationBasicInformation(int LDLAppID)
        {
            //Get L.D.L AppID
            clsLocalDrivingLicenseApplication LDLApplication = clsLocalDrivingLicenseApplication.Find(LDLAppID);

            //Get App Info
            clsApplication APPLICATION = clsApplication.Find(LDLApplication.ApplicationID);
            //

            //Get L.D.L App info
            clsLocalDrivingLicenseApplications_View LDLAppView = clsLocalDrivingLicenseApplications_View.Find(LDLAppID);
            //

            //ID
            this.lbIDValue.Text = LDLAppID.ToString();
            //

            //Status
            this.lbStatusValue.Text = LDLAppView.Status;
            //

            //Fees
            this.lbFeesValue.Text = APPLICATION.PaidFees.ToString();
            //

            //Type
            clsApplicationType ApplicationType = clsApplicationType.Find(APPLICATION.ApplicationTypeID);
            this.lbTypeValue.Text = ApplicationType.ApplicationTypeTitle;
            //

            //Date
            this.lbDateValue.Text = APPLICATION.ApplicationDate.ToShortDateString();
            //

            //Status Date
            this.lbStatusDateValue.Text = APPLICATION.LastStatusDate.ToShortDateString();
            //

            //Created-By User ID
            this.lbCreatedByValue.Text = APPLICATION.CreatedByUserID.ToString();
            //
        }

        public ctrlApplicationBasicInformation()
        {
            InitializeComponent();
        }

        public ctrlApplicationBasicInformation(int Application)
        {
            InitializeComponent();
            LoadApplicationBasicInformation(Application);
        }

        private void lbVeiwPersonInformation_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(this.lbIDValue.Text, out int LDLAppID))
            {
                MessageBox.Show("Error! I don't know what happend Call me to do the Debugging!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsLocalDrivingLicenseApplication LDLApplication = clsLocalDrivingLicenseApplication.Find(LDLAppID);

            if (LDLApplication == null)
            {
                MessageBox.Show("Error! I don't know what happend Call me to do the Debugging!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsApplication Application = clsApplication.Find(LDLApplication.ApplicationID);

            if (Application == null)
            {
                MessageBox.Show("Error! I don't know what happend Call me to do the Debugging!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form frmApplicantDetails = new frmShowPersonDetails(Application.ApplicantPersonID);
            frmApplicantDetails.ShowDialog();

        }
    }
}