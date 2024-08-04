using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DVLD
{
    public partial class frmAddUpdatePerson : Form
    {
        public clsPerson.enMode Mode {  get; set; }

        private void LoadPersonInfo(int PersonID)
        {
            clsPerson Person = clsPerson.Find(PersonID);

            if (Person != null)
            {
                this.ctrlAddUpdatePerson1.lbPersonID.Text = Person.PersonID.ToString();
                this.ctrlAddUpdatePerson1.tbFirst.Text = Person.FirstName;
                this.ctrlAddUpdatePerson1.tbSecond.Text = Person.SecondName;
                this.ctrlAddUpdatePerson1.tbThird.Text = Person.ThirdName;
                this.ctrlAddUpdatePerson1.tbLast.Text = Person.LastName;
                this.ctrlAddUpdatePerson1.tbNationalNo.Text = Person.NationalNO;
                this.ctrlAddUpdatePerson1.tbEmail.Text = Person.Email;
                this.ctrlAddUpdatePerson1.rtbAddress.Text = Person.Address;
                this.ctrlAddUpdatePerson1.cbCountries.SelectedIndex = (Person.NationalityCountryID - 1);// an error was detected here too, cbCountries must be initialized before doing this.

                if (Person.Gender == 'M')
                {
                    this.ctrlAddUpdatePerson1.rbtnMale.Checked = true;
                }
                else
                {
                    this.ctrlAddUpdatePerson1.rbtnFemale.Checked = true;
                }

                this.ctrlAddUpdatePerson1.tbPhone.Text = Person.Phone;
                this.ctrlAddUpdatePerson1.dtpDateOfBirth.Value = Person.DateOfBirth;

                //Check if the is no pre set image
                if (string.IsNullOrEmpty(Person.ImagePath))
                {
                    //If there is non put the default image depending on Gender
                    this.ctrlAddUpdatePerson1.pictureBox1.Image =
                        Person.Gender == 'M' ? clsSettings.DefaultMaleImage : clsSettings.DefaultFemaleImage;
                }
                else //if there image was set get its location
                    this.ctrlAddUpdatePerson1.pictureBox1.ImageLocation = Person.ImagePath;
            }
        }

        private void AddNewPersonInitialization()
        {
            //Initialize cbCountries
            this.ctrlAddUpdatePerson1.cbCountries.DataSource = clsCountry.GetAllCountries();
            this.ctrlAddUpdatePerson1.cbCountries.DisplayMember = "CountryName";
            this.ctrlAddUpdatePerson1.cbCountries.ValueMember = "CountryID";
            this.ctrlAddUpdatePerson1.cbCountries.SelectedIndex = 99;

            //Control title initialization
            this.lbAddNewUpdatePerson.Text = "Add New Person";

            //Initialize the mode
            Mode = clsPerson.enMode.AddNew;
        }

        private void UpdatePersonInitialization(int PersonID)
        {
            //Control title initialization
            this.lbAddNewUpdatePerson.Text = "Update Person";

            //Initialize the mode
            Mode = clsPerson.enMode.Update;

            //Initialize cbCountries
            //Fill cbCountries from DataTable
            this.ctrlAddUpdatePerson1.cbCountries.DataSource = clsCountry.GetAllCountries();
            this.ctrlAddUpdatePerson1.cbCountries.DisplayMember = "CountryName";
            this.ctrlAddUpdatePerson1.cbCountries.ValueMember = "CountryID";

            //Load Person's Info
            LoadPersonInfo(PersonID);
        }

        //Default Constructor (Add New Person)
        public frmAddUpdatePerson()
        {
            InitializeComponent();
            AddNewPersonInitialization();
        }

        //Update Person Constructor
        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();
            UpdatePersonInitialization(PersonID);
        }

        private bool ControlHasNoInputErrors(Control container, ErrorProvider errorProvider)
        {
            IEnumerable<TextBox> textboxes = container.Controls.OfType<TextBox>();
            foreach (TextBox textBox in textboxes)
            {
                if (errorProvider.GetError(textBox) == null)
                {
                    return false; // Early exit if an error is found
                }
            }
            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!ControlHasNoInputErrors(this.ctrlAddUpdatePerson1, this.ctrlAddUpdatePerson1.errorProvider1))
            {
                MessageBox.Show("Error! can't save, there are invalid inputs!");
                return;
            }

            if (this.ctrlAddUpdatePerson1.pictureBox1.Image == clsSettings.DefaultMaleImage || this.ctrlAddUpdatePerson1.pictureBox1.Image == clsSettings.DefaultFemaleImage)
            {
                this.ctrlAddUpdatePerson1.pictureBox1.ImageLocation = null;
            }

            char Gender = 'M';
            if (this.ctrlAddUpdatePerson1.rbtnFemale.Checked)
                {
                    Gender = 'F';
                }

            if (Mode == clsPerson.enMode.AddNew)
                {
                    clsPerson NewPerson = new clsPerson(
                    Mode,
                    -1,
                    this.ctrlAddUpdatePerson1.tbNationalNo.Text,
                    this.ctrlAddUpdatePerson1.tbFirst.Text,
                    this.ctrlAddUpdatePerson1.lbSecond.Text,
                    this.ctrlAddUpdatePerson1.lbThird.Text,
                    this.ctrlAddUpdatePerson1.lbLast.Text,
                    this.ctrlAddUpdatePerson1.dtpDateOfBirth.Value,
                    Gender,
                    this.ctrlAddUpdatePerson1.rtbAddress.Text,
                    this.ctrlAddUpdatePerson1.tbPhone.Text,
                    this.ctrlAddUpdatePerson1.tbEmail.Text,
                    Convert.ToInt16(this.ctrlAddUpdatePerson1.cbCountries.SelectedValue),
                    this.ctrlAddUpdatePerson1.pictureBox1.ImageLocation);
                    
                        NewPerson.Save();

                    this.ctrlAddUpdatePerson1.Enabled = false;
                    this.btnSave.Enabled = false;
                    this.ctrlAddUpdatePerson1.lbPersonID.Text = clsPerson.GetPersonID(NewPerson.NationalNO).ToString();
                }
            else
                {
                    clsPerson Person = clsPerson.Find(Convert.ToInt32(this.ctrlAddUpdatePerson1.lbPersonID.Text));

                    Person.NationalNO = this.ctrlAddUpdatePerson1.tbNationalNo.Text;
                    Person.FirstName = this.ctrlAddUpdatePerson1.tbFirst.Text;
                    Person.SecondName = this.ctrlAddUpdatePerson1.tbSecond.Text;
                    Person.ThirdName = this.ctrlAddUpdatePerson1.tbThird.Text;
                    Person.LastName = this.ctrlAddUpdatePerson1.tbLast.Text;
                    Person.DateOfBirth = this.ctrlAddUpdatePerson1.dtpDateOfBirth.Value;
                    Person.Gender = Gender;
                    Person.Address = this.ctrlAddUpdatePerson1.rtbAddress.Text;
                    Person.Phone = this.ctrlAddUpdatePerson1.tbPhone.Text;
                    Person.Email = this.ctrlAddUpdatePerson1.tbEmail.Text;
                    Person.NationalityCountryID = Convert.ToInt16(this.ctrlAddUpdatePerson1.cbCountries.SelectedValue);
                    Person.ImagePath = this.ctrlAddUpdatePerson1.pictureBox1.ImageLocation;
                    
                    Person.Save();

                    this.ctrlAddUpdatePerson1.Enabled = false;
                    this.btnSave.Enabled = false;
                }
        }
    }
}