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
    public partial class frmManageUsers : Form
    {
        private DataTable _AllUsersTable;

        private DataTable _sdtUsers;

        private DataView _sdvUsers;

        private class FilterItem
        {
            public string DisplayName { get; set; }
        }

        public frmManageUsers()
        {
            InitializeComponent();
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
            _sdvUsers.RowFilter = filterExpression;
        }

        private void FillRefreshDataGirdView()
        {
            // Get the DataTable from the data source
            _AllUsersTable = clsUser.GetAllUsers();

            // Create a DataView for the specified DataTable
            _sdvUsers = _AllUsersTable.DefaultView;

            // _sdvPeople
            this._sdvUsers.AllowEdit = true;
            this._sdvUsers.AllowNew = true;
            this._sdvUsers.AllowDelete = true;

            //Data Grid View Data Source
            this.dgvUsers.DataSource = _sdvUsers;
            this.dgvUsers.Columns["UserID"].Width = 100;
            this.dgvUsers.Columns["PersonID"].Width = 100;
            this.dgvUsers.Columns["FullName"].Width = 300;
            this.dgvUsers.Columns["UserName"].Width = 250;
            this.dgvUsers.Columns["IsActive"].Width = 150;
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            FillRefreshDataGirdView();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Form NewUser = new frmAddUpdateNewUser();
            NewUser.ShowDialog();
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            if(dgvUsers.SelectedRows.Count == 1)
            {
                if (int.TryParse(this.dgvUsers.SelectedRows[0].Cells[0].Value.ToString(), out int UserID))
                {
                    Form NewUser = new frmAddUpdateNewUser(UserID);
                    NewUser.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Select One Record!");
            }
        }

        private void btnRefreshdgvUsers_Click(object sender, EventArgs e)
        {
            FillRefreshDataGirdView();
        }
    }
}