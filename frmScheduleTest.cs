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
    public partial class frmScheduleTest : Form
    {
        public enum enTestType {Vistion = 1, Written = 2, Practical = 3}

        private void InitializelbScheduleTestNameAppointment(enTestType TestType)
        {
            switch(TestType)
            {
                case enTestType.Vistion:
                    {
                        this.lbScheduleTestNameAppointment.Text = "Schadule Vistion Test Appointment";
                    }
                    break;
                case enTestType.Written:
                    {
                        this.lbScheduleTestNameAppointment.Text = "Schadule Written Test Appointment";
                    }
                    break;
                case enTestType.Practical:
                    {
                        this.lbScheduleTestNameAppointment.Text = "Schadule Practical Test Appointment";
                    }
                    break;
            }
        }
        private void LoadLDLApplicationInformation(int LDLAppID)
        {
            clsLocalDrivingLicenseApplications_View LDLApp_View = clsLocalDrivingLicenseApplications_View.Find(LDLAppID);

            this.lbIDValue.Text = LDLAppID.ToString();
            this.lbDrivingLicenseClassValue.Text = LDLApp_View.ClassName;
            this.lbNameValue.Text = LDLApp_View.FullName;
            
            clsLocalDrivingLicenseApplication LDLApplication = clsLocalDrivingLicenseApplication.Find(LDLAppID);
            clsApplication Application = clsApplication.Find(LDLApplication.ApplicationID);
            clsApplicationType ApplicationType = clsApplicationType.Find(Application.ApplicationTypeID);
            this.lbFeesValue.Text = ApplicationType.ApplicationFees.ToString();

            this.ctrlRetakeTestInformation1 = new ctrlRetakeTestInformation(LDLAppID);

            clsTestAppointment TestAppointment = clsTestAppointment.Find(LDLAppID, 0);
            this.lbTrailsValue.Text = TestAppointment.Trails.ToString();
        }

        public frmScheduleTest()
        {
            InitializeComponent();
        }

        public frmScheduleTest(enTestType TestType, int LDLAppID)
        {
            InitializeComponent();
            InitializelbScheduleTestNameAppointment(TestType);
            LoadLDLApplicationInformation(LDLAppID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}