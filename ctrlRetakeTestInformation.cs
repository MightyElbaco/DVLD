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
    public partial class ctrlRetakeTestInformation : UserControl
    {
        private void LoadReTakeTestApplicationInfo(int LDLAppID)
        {
            clsLocalDrivingLicenseApplication LDLApplication = clsLocalDrivingLicenseApplication.Find(LDLAppID);

            clsApplication Application = clsApplication.Find(LDLApplication.ApplicationID);

            if (Application == null) return;

            clsTestAppointment TestAppointment = clsTestAppointment.Find(LDLAppID, 0);

            if (TestAppointment == null) return;

            this.lbRAppFeesValue.Text = TestAppointment.PaidFees.ToString();
            this.lbRTestAppIDValue.Text = TestAppointment.TestAppointmentID.ToString();
            this.lbTotalFeesValue.Text = (TestAppointment.PaidFees + Application.PaidFees).ToString();
        }
        public ctrlRetakeTestInformation()
        {
            InitializeComponent();
        }

        public ctrlRetakeTestInformation(int LDLAppID)
        {
            InitializeComponent();
            LoadReTakeTestApplicationInfo(LDLAppID);
        }
    }
}
