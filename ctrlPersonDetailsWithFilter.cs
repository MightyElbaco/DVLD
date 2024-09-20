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
    public partial class ctrlPersonDetailsWithFilter : UserControl
    {
        //Define a custom event handler delegate with Parameters
        public event Action<int> OnPersonSelected;

        //Create a protected method to raise the event with a parameter
        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> Handler = OnPersonSelected;

            if(Handler != null)
            {
                OnPersonSelected(PersonID);
            }
        }

        public ctrlPersonDetailsWithFilter()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFilter.Text)) return;

            if (this.cbFilters.SelectedIndex == 0)
            {
                clsPerson Person = clsPerson.Find(Convert.ToInt32(this.tbFilter.Text));
                if(Person != null)
                {
                    PersonSelected(Person.PersonID);
                }
            }
            else
            {
                clsPerson Person = clsPerson.Find(this.tbFilter.Text);
                if (Person != null)
                {
                    PersonSelected(Person.PersonID);
                }
            }
        }
    }
}