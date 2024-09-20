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
    public partial class frmLocalDrivingLicenseApplications : Form
    {
        private DataView dvLocalDrivingLicenseApplications =
            clsLocalDrivingLicenseApplication.
            GetAllLocalDrivingLicenseApplications().DefaultView;

        private void FilldgvLocalDrivingLicenseApplications()
        {
            this.dgvLocalDrivingLicenseApplications.DataSource = dvLocalDrivingLicenseApplications;
        }

        public frmLocalDrivingLicenseApplications()
        {
            InitializeComponent();
        }

        private void frmLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            FilldgvLocalDrivingLicenseApplications();
        }

        private void tsmiShowApplicationDetails_Click(object sender, EventArgs e)
        {
            if (this.dgvLocalDrivingLicenseApplications.SelectedCells.Count != 1)
            {
                MessageBox.Show("Must select an ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (int.TryParse(dgvLocalDrivingLicenseApplications.SelectedCells[0].Value.ToString(), out int ApplicationID))
                {
                    Form frmApplicationDetails = new frmLocalLicenseApplicationInformation(ApplicationID);
                    frmApplicationDetails.Show();
                }
                else
                {
                    MessageBox.Show("Don't even ask Nigga! I have no idea what happend", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsmiEditApplication_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming Soon!", "News", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsmiDeleteApplication_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Are you sure you want to delete this app?", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (Result == DialogResult.Yes)
            {
                if (int.TryParse(dgvLocalDrivingLicenseApplications.SelectedCells[0].Value.ToString(), out int LDLApplicationID))
                {
                    clsLocalDrivingLicenseApplication LDLApplication = clsLocalDrivingLicenseApplication.Find(LDLApplicationID);

                    LDLApplication.Delete();

                    MessageBox.Show("Application Status has been deleted successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Don't even ask Nigga! I have no idea what happend", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsmiCancelApplication_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Are you sure you want to cancele this app?", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (Result == DialogResult.Yes)
            {
                if (this.dgvLocalDrivingLicenseApplications.SelectedCells.Count != 1)
                {
                    MessageBox.Show("Must select an ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (int.TryParse(dgvLocalDrivingLicenseApplications.SelectedCells[0].Value.ToString(), out int LDLApplicationID))
                    {


                        clsLocalDrivingLicenseApplication LDLApplication = clsLocalDrivingLicenseApplication.Find(LDLApplicationID);
                        clsApplication Application = clsApplication.Find(LDLApplication.ApplicationID);

                        Application.ApplicationStatus = 2;
                        Application.Save();

                        MessageBox.Show("Application Status has been updated successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Don't even ask Nigga! I have no idea what happend", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void tsmiScheduleVisionTest_Click(object sender, EventArgs e)
        {
            if (this.dgvLocalDrivingLicenseApplications.SelectedCells.Count != 1)
            {
                MessageBox.Show("Must select an ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (int.TryParse(dgvLocalDrivingLicenseApplications.SelectedCells[0].Value.ToString(), out int LDLApplicationID))
                {
                    Form SchduleTest = new frmScheduleTest(frmScheduleTest.enTestType.Vistion, LDLApplicationID);

                    if (SchduleTest == null) return;

                    SchduleTest.ShowDialog();
                }
            }
        }
    }
}