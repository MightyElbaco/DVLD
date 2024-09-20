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
    public partial class ctrlPersonDetails : UserControl
    {
        public void LoadPersonInfo(int PersonID)
        {
            clsPerson Person = clsPerson.Find(PersonID);

            if (Person != null)
            {
                this.lbPersonIDValue.Text = PersonID.ToString();
                this.lbFullNameValue.Text = Person.GetFullName();
                this.lbNationalNOValue.Text = Person.NationalNO;

                clsCountry Country = clsCountry.Find(Person.NationalityCountryID);
                this.lbCountryValue.Text = Country.CountryName;

                this.lbEmailValue.Text = Person.Email;
                this.lbPhoneValue.Text = Person.Phone;
                this.lbDateOfBirthValue.Text = Person.DateOfBirth.ToString();

                if (Person.Gender == 'M')
                    this.lbGenderValue.Text = "Male";
                else
                    this.lbGenderValue.Text = "Female";

                this.rtbAddress.Text = Person.Address;
                this.rtbAddress.Enabled = false;
            }
        }

        public ctrlPersonDetails()
        {
            InitializeComponent();
        }
    }
}