using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmManagePeople : Form
    {
        private DataTable _AllPeopleTable;
        
        private DataTable _sdtPeople;

        private DataView _sdvPeople;

        public frmManagePeople()
        {
            InitializeComponent();
        }

        //Intern Class for cbFilters Items
        private class FilterItem
        {
            public string DisplayName { get; set; }
        }

        private void InitializecmFilters()
        {
            // Create a list of FilterItem objects
            var filters = new List<FilterItem>
                {
                    new FilterItem { DisplayName = "None"},
                    new FilterItem { DisplayName = "PersonID"},
                    new FilterItem { DisplayName = "First Name" },
                    new FilterItem { DisplayName = "Second Name" },
                    new FilterItem { DisplayName = "Third Name" },
                    new FilterItem { DisplayName = "Last Name" },
                    new FilterItem { DisplayName = "NationalNO" },
                    new FilterItem { DisplayName = "Nationality (CountryID)" },
                    new FilterItem { DisplayName = "Gender" },
                    new FilterItem { DisplayName = "Phone" },
                    new FilterItem { DisplayName = "Email" }
                };

            // Bind the ComboBox to the list of FilterItem
            cbFilters.DataSource = filters;
            cbFilters.DisplayMember = "DisplayName";  // The property to display

            // Optionally set a default selection
            if (cbFilters.Items.Count > 0)
            {
                cbFilters.SelectedIndex = 0; // Select the first item by default
            }
        }

        private void ApplyFilter(string filterExpression)
        {
            // Apply the filter expression to the DataView
            _sdvPeople.RowFilter = filterExpression;
        }

        private void FillRefreshDataGirdView()
        {
            // Get the DataTable from the data source
            _AllPeopleTable = clsPerson.GetAllPeople();

            // Create a DataView with only the desired columns
            _sdtPeople = _AllPeopleTable.DefaultView.ToTable(false, "PersonID", "NationalNo",
            "FirstName", "LastName", "Gender", "DateOfBirth", "NationalityCountryID", "Phone", "Email");

            // Create a DataView for the specified DataTable
            _sdvPeople = _sdtPeople.DefaultView;

            // _sdvPeople
            this._sdvPeople.AllowEdit = true;
            this._sdvPeople.AllowNew = true;
            this._sdvPeople.AllowDelete = true;

            //Data Grid View Data Source
            this.dgvPeople.DataSource = _sdvPeople;
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            Form AddNewPerson = new frmAddUpdatePerson();
            AddNewPerson.ShowDialog();
        }

        private void mtbFilter_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mtbFilter.Text))
            {
                ApplyFilter("");
                return;
            }

            switch (cbFilters.SelectedIndex)
            {
                case 0:
                    {
                        ApplyFilter("");
                        break;
                    }
                case 1:
                    {
                        ApplyFilter($"CONVERT(PersonID, System.String) LIKE '{mtbFilter.Text}%'");
                        break;
                    }
                case 2:
                    {
                        ApplyFilter($"FirstName LIKE '{mtbFilter.Text}%'");
                        break;
                    }
                case 3:
                    {
                        ApplyFilter($"SecondName LIKE '{mtbFilter.Text}%'");
                        break;
                    }
                case 4:
                    {
                        ApplyFilter($"ThirdName LIKE '{mtbFilter.Text}%'");
                        break;
                    }
                case 5:
                    {
                        ApplyFilter($"LastName LIKE '{mtbFilter.Text}%'");
                        break;
                    }
                case 6:
                    {
                        ApplyFilter($"NationalNO LIKE '{mtbFilter.Text}%'");
                        break;
                    }
                case 7:
                    {
                        ApplyFilter($"COVERT(CountryID, System.String) = '{mtbFilter.Text}%'");
                        break;
                    }
                case 8:
                    {
                        ApplyFilter($"Gender = '{mtbFilter.Text}' ");
                        break;
                    }
                case 9:
                    {
                        ApplyFilter($"Phone LIKE '{mtbFilter.Text}%'");
                        break;
                    }
                case 10:
                    {
                        ApplyFilter($"Email LIKE '{mtbFilter.Text}%'");
                        { }
                        break;
                    }
            }
        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            FillRefreshDataGirdView();
            InitializecmFilters();
        }

        private void tsmiUpdate_Click(object sender, EventArgs e)
        {
            //Check if there are selected rows
            if (this.dgvPeople.SelectedRows.Count > 0)
            {
                if (int.TryParse(this.dgvPeople.SelectedRows[0].Cells[0].Value.ToString(), out int PersonID))
                {
                    Form UpdatePerson = new frmAddUpdatePerson(PersonID);
                    UpdatePerson.ShowDialog();
                }
            }
        }

        private void tmsiDelete_Click(object sender, EventArgs e)
        {
            //Check if there are selected rows
            if (this.dgvPeople.SelectedRows.Count == 1)
            {
                if (int.TryParse(this.dgvPeople.SelectedRows[0].Cells[0].Value.ToString(), out int PersonID))
                {
                    //Confirm the deletion
                    DialogResult Result = MessageBox.Show("Are you sure?", "Confirm deletion!", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (Result == DialogResult.OK)
                    {
                        clsPerson.DeletePersonByID(PersonID);
                        MessageBox.Show("Person was deleted successfully :)");
                    }
                }
                else
                    MessageBox.Show("Error: Person wasn't deleted, Make sure to select one record!");
            }
        }

        private void btnRefreshdgvPeople_Click(object sender, EventArgs e)
        {
            FillRefreshDataGirdView();
        }

        private void tmsiShowDetails_Click(object sender, EventArgs e)
        {
            //Check if there are selected rows
            if (this.dgvPeople.SelectedRows.Count > 0)
            {
                if (int.TryParse(this.dgvPeople.SelectedRows[0].Cells[0].Value.ToString(), out int PersonID))
                {
                    Form PersonDetails = new frmShowPersonDetails(PersonID);
                    PersonDetails.ShowDialog();
                }
            }
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbFilters.SelectedIndex)
            {
                case 0:
                    {
                        //No mask
                        mtbFilter.Mask = "";
                        break;
                    }
                case 1:
                    {
                        //Numbers only mask
                        mtbFilter.Mask = "0000000000";
                        break;
                    }
                case 2:
                    {
                        //Letters only mask
                        mtbFilter.Mask = "LLLLLLLLLLLLLLLLLLLL";
                        break;
                    }
                case 3:
                    {
                        //Letters only mask
                        mtbFilter.Mask = "LLLLLLLLLLLLLLLLLLLL";
                        break;
                    }
                case 4:
                    {
                        //Letters only mask
                        mtbFilter.Mask = "LLLLLLLLLLLLLLLLLLLL";
                        break;
                    }
                case 5:
                    {
                        //Letters only mask
                        mtbFilter.Mask = "LLLLLLLLLLLLLLLLLLLL";
                        break;
                    }
                case 6:
                    {
                        //NationalNO format mask
                        mtbFilter.Mask = "A0000000000";
                        break;
                    }
                case 7:
                    {
                        //CountryID format mask
                        mtbFilter.Mask = "000";
                        break;
                    }
                case 8:
                    {
                        //Gender format mask
                        mtbFilter.Mask = "A";
                        break;
                    }
                case 9:
                    {
                        mtbFilter.Mask = "00000000000000000000";
                        break;
                    }
                case 10:
                    {
                        //No mask I don't know how to do it for email format rn
                        mtbFilter.Mask = "";
                        break;
                    }
            }
        }
    }
}