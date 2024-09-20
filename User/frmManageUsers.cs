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
using System.Windows.Forms.VisualStyles;

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

        private void ApplyFilter(string FilterExpression)
        {
            // Apply the filter expression to the DataView
            _sdvUsers.RowFilter = FilterExpression; 
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

            //Set the default filter
            this.cbFilters.SelectedIndex = 0;
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            FillRefreshDataGirdView();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Form NewUser = new frmAddNewUpdateUser();
            NewUser.ShowDialog();
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 1)
            {
                if (int.TryParse(this.dgvUsers.SelectedRows[0].Cells[0].Value.ToString(), out int UserID))
                {
                    Form NewUser = new frmAddNewUpdateUser(UserID);
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

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 1)
            {
                //Confirm the deletion
                DialogResult Result = MessageBox.Show("Are you sure?", "Confirm deletion!", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (Result == DialogResult.OK)
                {
                    if (int.TryParse(this.dgvUsers.SelectedRows[0].Cells[0].Value.ToString(), out int UserID))
                    {
                        clsUser.DeleteUserByID(UserID);
                    }
                }
            }
            else
            {
                MessageBox.Show("Select One Record!");
            }
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            switch (cbFilters.SelectedIndex)
            {
                case 0:
                    {
                        ApplyFilter("");
                        break;
                    }
                case 1:
                    {
                        ApplyFilter($"CONVERT(UserID, System.String) LIKE '{mtbFilter.Text}%'");
                        break;
                    }
                case 2:
                    {
                        ApplyFilter($"CONVERT(PersonID, System.String) LIKE '{mtbFilter.Text}%'");
                        break;
                    }
                case 3:
                    {
                        ApplyFilter($"UserName LIKE '{mtbFilter.Text}%'");
                        break;
                    }
                case 4:
                    {
                        ApplyFilter($"FullName LIKE '{mtbFilter.Text}%'");
                        break;
                    }
            }
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilters.SelectedIndex != 5)
            {
                this.mtbFilter.Enabled = true;
                this.mtbFilter.Visible = true;

                this.cbIsActive.Enabled = false;
                this.cbIsActive.Visible = false;
            }

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
                        //Numbers only mask // UserID
                        mtbFilter.Mask = "0000000000";
                        break;
                    }
                case 2:
                    {
                        //Letters only mask
                        mtbFilter.Mask = "0000000000";
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
                        this.mtbFilter.Enabled = false;
                        this.mtbFilter.Visible = false;

                        this.cbIsActive.Enabled = true;
                        this.cbIsActive.Visible = true;
                        break;
                    }
            }
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbIsActive.SelectedIndex == 0)
            {
                ApplyFilter($"IsActive = 1");
            }
            else
            {
                ApplyFilter($"IsActive = 0");
            }
        }

        private void tsmiShowDetails_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 1)
            {
                if (int.TryParse(this.dgvUsers.SelectedRows[0].Cells[0].Value.ToString(), out int UserID))
                {
                    Form UserDetails = new frmShowUserDetails(UserID);
                    UserDetails.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Select One Record!");
            }
        }

        private void tsmiChangePassword_Click(object sender, EventArgs e)
        {
            if (this.dgvUsers.SelectedRows.Count == 1)
            {
                if (int.TryParse(this.dgvUsers.SelectedRows[0].Cells[0].Value.ToString(), out int UserID))
                {
                    Form ChangePassword = new frmChangePassword(UserID);
                    ChangePassword.MdiParent = this;
                    ChangePassword.Show();
                }
            }
            else
            {
                MessageBox.Show("Select One Record!");
            }
        }
    }
}