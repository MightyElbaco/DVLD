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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tsbtnPeople_Click(object sender, EventArgs e)
        {
            Form ManagePeople = new frmManagePeople(); //This will be the child form
            ManagePeople.MdiParent = this; //Set MDI parent
            ManagePeople.Show(); //Show it
        }

        private void tsbtnUsers_Click(object sender, EventArgs e)
        {
            Form ManageUsers = new frmManageUsers(); //This will be the child form
            ManageUsers.MdiParent = this; //Set MDI parent
            ManageUsers.Show(); //Show it
        }
    }
}