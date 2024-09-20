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
using Microsoft.VisualBasic;

namespace DVLD
{
    public partial class frmManageApplicationTypes : Form
    {
        private DataView dvApplicationTypes = clsApplicationType.GetAllApplicationTypes().DefaultView;

        public frmManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void FillRefreshdgvApplicationTypes()
        {
            dgvApplicationTypes.DataSource = dvApplicationTypes;
        }

        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            FillRefreshdgvApplicationTypes();
            dgvApplicationTypes.Columns[0].Width = 50;
            dgvApplicationTypes.Columns[1].Width = 350;
            dgvApplicationTypes.Columns[2].Width = 125;

            dgvApplicationTypes.AllowDrop = false;

            this.lbNumberOfRecords.Text += (dgvApplicationTypes.Rows.Count - 1).ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmsiChangeApplicationFees_Click(object sender, EventArgs e)
        {
            // Ensure that exactly one row is selected
            if (dgvApplicationTypes.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select one record.");
                return;
            }

            // Try to parse the selected Application ID
            if (!int.TryParse(dgvApplicationTypes.SelectedRows[0].Cells[0].Value.ToString(), out int applicationID))
            {
                MessageBox.Show("Invalid Application ID.");
                return;
            }

            // Find the application by ID
            clsApplicationType application = clsApplicationType.Find(applicationID);

            if (application == null)
            {
                MessageBox.Show("Application not found.");
                return;
            }

            // Prompt the user for the new fees
            string userInput = Interaction.InputBox("Enter the new application fees:", "Update Application Fees", application.ApplicationFees.ToString());

            // If the user cancels the input, exit the function
            if (string.IsNullOrEmpty(userInput))
            {
                MessageBox.Show("Invalid input. Can't be empty, Please enter a valid number.");
                return;
            }

            // Try to parse the input as a float
            if (!float.TryParse(userInput, out float newFees))
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
                return;
            }

            // Update the application fees and save the changes
            application.ApplicationFees = newFees;
            application.Save();

            // Notify the user of the success
            MessageBox.Show("Application fees updated successfully.");
            FillRefreshdgvApplicationTypes();
        }
    }
}