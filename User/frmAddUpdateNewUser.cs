using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD
{
    public partial class frmAddUpdateNewUser : Form
    {
        private clsUser.enMode Mode {  get; set; }

        private void LoadPersonDetails(int PersonID)
        {
            clsPerson Person = clsPerson.Find(PersonID);

            if (Person != null)
            {
                this.ctrlPersonDetails1.lbPersonIDValue.Text = Person.PersonID.ToString();
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
            }
            else
            {
                this.ctrlPersonDetails1 = null;
            }
        }

        private void LoadUserInfo(int UserID)
        {
            clsUser User = clsUser.Find(UserID);

            if(User != null)
            {
                LoadPersonDetails(User.PersonID);

                this.lbUserIDValue.Text = UserID.ToString();
                this.tbUserName.Text = User.UserName;

                if(User.isActive)
                {
                    this.rbtnActive.Checked = true;
                    this.rbtnNotActive.Checked = false;
                }
                else
                {
                    this.rbtnActive.Checked = false;
                    this.rbtnNotActive.Checked = true;
                }

            }
        }

        private void AddNewUserInitialization()
        {
            Mode = clsUser.enMode.AddNew;
            this.lbAddNewUpdateUser.Text = "Add New User";
            this.cbFindBy.SelectedIndex = 0;
        }

        private void UpdateUserInitialization(int UserID)
        {
            Mode = clsUser.enMode.Update;
            this.lbAddNewUpdateUser.Text = "Update User";
            this.cbFindBy.SelectedIndex = 0;
            LoadUserInfo(UserID);

            //Deactivate the password section
            //Make them all unVisible
            this.lbPassword.Visible = false;
            this.lbConfirmPassword.Visible = false;
            this.tbPassword.Visible = false;
            this.tbConfirmPassword.Visible = false;

            //Unenabled them all too
            this.lbPassword.Enabled = false;
            this.lbConfirmPassword.Enabled = false;
            this.tbPassword.Enabled = false;
            this.tbConfirmPassword.Enabled = false;
        }

        public frmAddUpdateNewUser()
        {
            InitializeComponent();
            AddNewUserInitialization();
        }

        public frmAddUpdateNewUser(int UserID)
        {
            InitializeComponent();
            UpdateUserInitialization(UserID);
        }

        private bool ControlHasNoInputErrors(Control container, ErrorProvider errorProvider)
        {
            IEnumerable<System.Windows.Forms.TextBox> textboxes = container.Controls.OfType<System.Windows.Forms.TextBox>();
            foreach (System.Windows.Forms.TextBox textBox in textboxes)
            {
                if (errorProvider.GetError(textBox) == null)
                {
                    return false; // Early exit if an error is found
                }
            }
            return true;
        }

        private void LoadPersonDetails(string NationalNO)
        {
            clsPerson Person = clsPerson.Find(NationalNO); 
        
            if (Person != null)
            {
                this.ctrlPersonDetails1.lbPersonIDValue.Text = Person.PersonID.ToString();
                this.ctrlPersonDetails1.lbFullNameValue.Text = Person.GetFullName();
                this.ctrlPersonDetails1.lbNationalNOValue.Text = NationalNO;
        
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
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.tcUserInfo.SelectedIndex = 1;
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            Form AddNewPerson = new frmAddUpdatePerson();
            AddNewPerson.ShowDialog();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (errorProvider1.GetError(tbFind) != null && !string.IsNullOrEmpty(tbFind.Text))
            {
                if (cbFindBy.SelectedIndex == 0)
                {
                    if(Regex.IsMatch(tbFind.Text, @"^\d*$"))
                    {
                    //Find By PersonID
                    LoadPersonDetails(Convert.ToInt32(tbFind.Text));
                    }
                }
                else
                {
                    if(Regex.IsMatch(tbFind.Text, @"^N\d+$"))
                    {
                    //Find By NationalNO
                    LoadPersonDetails(tbFind.Text);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ControlHasNoInputErrors(this.tcUserInfo, this.errorProvider1))
            {
                bool isActive = false;

                if (rbtnActive.Checked)
                {
                    isActive = true;
                }

                
                if (Mode == clsUser.enMode.AddNew)
                {
                    //Generate a random string to be the hashing salt
                    string HashingSalt = clsGeneralLib.GenerateRandomString(16);

                    //Hash the password for security
                    string PasswordHash = clsGeneralLib.HashPasswordWithSHA256(this.tbPassword.Text, HashingSalt);

                    clsUser NewUser = new clsUser(clsUser.enMode.AddNew,
                        Convert.ToInt32(this.ctrlPersonDetails1.lbPersonIDValue.Text),
                        -1, this.tbUserName.Text, PasswordHash, HashingSalt, isActive);
                    //Save
                    NewUser.Save();
                }
                else
                {
                    //Find the user's Object
                    clsUser User = clsUser.Find(Convert.ToInt32(this.lbUserIDValue.Text));

                    //Apply changes
                    User.UserName = tbUserName.Text;
                    User.isActive = isActive;
                    User.PersonID = Convert.ToInt32(this.ctrlPersonDetails1.lbPersonIDValue.Text);

                    //Save
                    User.Save();
                }
            }
            else
            {
                MessageBox.Show("There are invalid inputs!");
            }

            //Disable all form but close button
            this.tcUserInfo.Enabled = false;
            this.btnSave.Enabled = false;
        }

        private void mtbFind_TextChanged(object sender, EventArgs e)
        {
            if (this.cbFindBy.SelectedIndex == 0)
            {
                if (string.IsNullOrEmpty(tbFind.Text) || !Regex.IsMatch(tbFind.Text, @"^\d*$"))
                {
                    errorProvider1.SetError(tbFind, "Empty or Not PersonID format");
                }
                else
                {
                    errorProvider1.SetError(tbFind, "");
                }
            }
            else
            {
                if (string.IsNullOrEmpty(tbFind.Text) || !Regex.IsMatch(tbFind.Text, @"^N\d+$"))
                {
                    errorProvider1.SetError(tbFind, "Empty or Not NationalNO format");
                }
                else
                {
                    errorProvider1.SetError(tbFind, "");
                }
            }
        }

        private void TextChanged(ref object sender, string ErrorMessage, string Patterns = "")
        {
            System.Windows.Forms.TextBox textbox = (System.Windows.Forms.TextBox)sender;

            if (string.IsNullOrEmpty(textbox.Text) || !Regex.IsMatch(textbox.Text, Patterns))
            {
                errorProvider1.SetError(textbox, ErrorMessage);
                
                textbox.Clear();
                textbox.Focus();
            }
            else
            {
                errorProvider1.SetError(textbox, "");
            }
        }

        private void tbUserID_TextChanged(object sender, EventArgs e)
        {
            TextChanged(ref sender, "Empty or Not UserID format", @"^\d*$");
        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {
            TextChanged(ref sender, "Can't be empty");
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            TextChanged(ref sender, "Can't be empty");
        }

        private void tbConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            TextChanged(ref sender, "Can't be empty");
        }

        private void rbtnActive_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnActive.Checked)
            {
                rbtnNotActive.Checked = false;
            }
        }

        private void rbtnNotActive_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNotActive.Checked)
            {
                rbtnActive.Checked = false;
            }
        }
    }
}