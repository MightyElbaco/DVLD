using DVLDBusinessLayer;
using Microsoft.VisualBasic;
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
    public partial class frmManageTestTypes : Form
    {
        private DataView dvTestTypes = clsTestType.GetAllTestTypes().DefaultView;

        public frmManageTestTypes()
        {
            InitializeComponent();
        }

        private void FillRefreshdgvTestTypes()
        {
            dgvTestTypes.DataSource = dvTestTypes;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {
            FillRefreshdgvTestTypes();
            dgvTestTypes.Columns[0].Width = 50;
            dgvTestTypes.Columns[1].Width = 250;
            dgvTestTypes.Columns[2].Width = 225;

            dgvTestTypes.AllowDrop = false;

            this.lbNumberOfRecords.Text += (dgvTestTypes.Rows.Count - 1).ToString();
        }

        private void tsmiChangeTestFees_Click(object sender, EventArgs e)
        {
            // Ensure that exactly one row is selected
            if (dgvTestTypes.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select one record.");
                return;
            }

            // Try to parse the selected Test Type ID
            if (!int.TryParse(dgvTestTypes.SelectedRows[0].Cells[0].Value.ToString(), out int TestTypeID))
            {
                MessageBox.Show("Invalid Test Type ID.");
                return;
            }

            // Find the Test Type by ID
            clsTestType TestType = clsTestType.Find(TestTypeID);

            if (TestType == null)
            {
                MessageBox.Show("Test Type not found.");
                return;
            }

            // Prompt the user for the new fees
            string userInput = Interaction.InputBox("Enter the new Test fees:", "Update Test Fees", TestType.TestTypeFees.ToString());

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
            TestType.TestTypeFees = newFees;
            TestType.Save();

            // Notify the user of the success
            MessageBox.Show("Test Type fees updated successfully.");
            FillRefreshdgvTestTypes();
        }
    }
}