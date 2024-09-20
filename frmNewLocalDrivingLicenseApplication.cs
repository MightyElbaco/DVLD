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
using System.Text.RegularExpressions;
using System.Runtime.InteropServices.WindowsRuntime;

namespace DVLD
{
    public partial class frmNewLocalDrivingLicenseApplication : Form
    {
        public frmNewLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (int.TryParse(this.ctrlPersonDetails1.lbPersonIDValue.Text, out int PersonID))
            {
                if(!clsLocalDrivingLicenseApplication.IsPersonApplicable(PersonID, Convert.ToInt16(this.cbLicenseClasses.SelectedValue)))
                {
                    MessageBox.Show("Can't apply again with in the same class currently!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Must Choose a Person!");
                return;
            }

            //Add new Application
            clsApplication NewApplication = new clsApplication(clsApplication.enMode.AddNew, -1, Convert.ToInt32(this.ctrlPersonDetails1.lbPersonIDValue.Text),
                  Convert.ToDateTime(this.lbApplicationDateValue.Text.Trim()), 1, 1, DateTime.Now, Convert.ToSingle(this.lbApplicationFeesValue.Text), clsGlobal.CurrentUser.UserID);
            //Save new Application
            NewApplication.Save();

            //Add New Local License
            clsLocalDrivingLicenseApplication NewLocalLicense = new clsLocalDrivingLicenseApplication(clsLocalDrivingLicenseApplication.enMode.AddNew, -1, NewApplication.ApplicationID, Convert.ToInt32(this.cbLicenseClasses.SelectedValue));
            //Save new Local License
            NewLocalLicense.Save();

            //Assign lbLDLIDValue
            this.lbDLApplicationIDValue.Text = NewLocalLicense.ApplicationID.ToString();

            MessageBox.Show("Saved succesfully");

            //Disable fieldes
            this.tcLocalDrivingLicenseApplicationInfo.Enabled = false;
            this.btnSave.Enabled = false;
            
        }

        private void tbFilter_Leave(object sender, EventArgs e)
        {
                switch (this.cbFindBy.SelectedIndex)
                {
                    case 0:
                        {
                            if (!Regex.IsMatch(this.tbFilter.Text, @"^\d*$"))
                            {
                                this.tbFilter.Focus();
                                this.tbFilter.Clear();
                                errorProvider1.SetError(this.tbFilter, "Not PersonID Format!");
                            }
                            else
                            {
                                errorProvider1.SetError(this.tbFilter, "");
                            }
                        }
                        break;

                    case 1:
                        {
                            if (!Regex.IsMatch(this.tbFilter.Text, @"^N\d+$"))
                            {
                                this.tbFilter.Focus(); // Set focus first
                                this.tbFilter.Clear();
                                errorProvider1.SetError(this.tbFilter, "Not NationalNO Format!");
                            }
                            else
                            {
                                errorProvider1.SetError(this.tbFilter, "");
                            }
                        }
                        break;
                }
            }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if(this.cbFindBy.SelectedIndex == 0)
            {
                clsPerson Person = clsPerson.Find(Convert.ToInt32(this.tbFilter.Text.Trim()));

                if(Person != null)
                {
                    this.ctrlPersonDetails1.LoadPersonInfo(Person.PersonID);
                }
                else
                {
                    this.ctrlPersonDetails1 = new ctrlPersonDetails();
                }
            }
            else
            {
                clsPerson Person = clsPerson.Find(this.tbFilter.Text.Trim());

                if (Person != null)
                {
                    this.ctrlPersonDetails1.LoadPersonInfo(Person.PersonID);
                }
                else
                {
                    this.ctrlPersonDetails1 = new ctrlPersonDetails();
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.tcLocalDrivingLicenseApplicationInfo.SelectedIndex++;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Form AddNew = new frmAddNewUpdateUser();
            AddNew.ShowDialog();
        }

        private void frmNewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            //Load License Classes
            this.cbLicenseClasses.DataSource = clsLicenseClass.GetAllLicenseClasses().DefaultView;

            this.cbLicenseClasses.DisplayMember = "ClassName";
            this.cbLicenseClasses.ValueMember = "LicenseClassID";

            //Initilize Created Date & Created By User ID
            this.lbApplicationDateValue.Text = DateTime.Now.ToString();
            this.lbCreatedByValue.Text = clsGlobal.CurrentUser.UserID.ToString();
        }
    }
}