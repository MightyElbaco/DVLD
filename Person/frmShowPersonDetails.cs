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
    public partial class frmShowPersonDetails : Form
    {
        private void LoadPersonDetails(int PersonID)
        {
            clsPerson Person = clsPerson.Find(PersonID);

            if(Person != null)
            {
                this.ctrlPersonDetails1.lbPersonIDValue.Text = PersonID.ToString();
                this.ctrlPersonDetails1.lbFullNameValue.Text = Person.GetFullName();
                this.ctrlPersonDetails1.lbNationalNOValue.Text = Person.NationalNO;

                clsCountry Country = clsCountry.Find(Person.NationalityCountryID);
                this.ctrlPersonDetails1.lbCountryValue.Text = Country.CountryName;

                this.ctrlPersonDetails1.lbEmail.Text = Person.Email;
                this.ctrlPersonDetails1.lbEmail.Text = Person.Phone;
                this.ctrlPersonDetails1.lbDateOfBirthValue.Text = Person.DateOfBirth.ToString();

                if (Person.Gender == 'M')
                    this.ctrlPersonDetails1.lbGenderValue.Text = "Male";
                else
                    this.ctrlPersonDetails1.lbGenderValue.Text = "Female";

                this.ctrlPersonDetails1.lbAddressValue.Text = Person.Address;

                this.ctrlPersonDetails1.pictureBox1.ImageLocation = Person.ImagePath;
            }
        }

        public frmShowPersonDetails(int PersonID)
        {
            InitializeComponent();
            LoadPersonDetails(PersonID );
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
