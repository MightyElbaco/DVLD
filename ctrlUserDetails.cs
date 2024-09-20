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
    public partial class ctrlUserDetails : UserControl
    {
        public void LoadUserDetails(int UserID)
        {
            clsUser User = clsUser.Find(UserID);

            if(User != null)
            {
                //this.ctrlPersonDetails1.LoadPersonDetails(User.PersonID);

                this.lbUsernameValue.Text = User.UserName;
                this.lbUserIDValue.Text = User.UserID.ToString();

                if (User.isActive)
                    this.lbIsActiveValue.Text = "Yes";
                else
                    this.lbIsActiveValue.Text = "No";

                //Load Person Details
                this.ctrlPersonDetails1.LoadPersonInfo(User.PersonID);
            }
        }
        public ctrlUserDetails()
        {
            InitializeComponent();
        }
    }
}
