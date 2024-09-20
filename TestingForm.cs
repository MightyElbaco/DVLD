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
    public partial class TestingForm : Form
    {
        public TestingForm()
        {
            InitializeComponent();
            this.ctrlPersonDetailsWithFilter1.OnPersonSelected += ctrlPersonDetailsWithFilter1_OnPersonSelected;
        }

        private void ctrlPersonDetailsWithFilter1_OnPersonSelected(int PersonID)
        {
            this.ctrlPersonDetailsWithFilter1.ctrlPersonDetails1.LoadPersonInfo(PersonID);
        }

    }
}