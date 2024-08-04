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
    public partial class ctrlAddUpdatePerson : UserControl
    {
        public ctrlAddUpdatePerson()
        {
            InitializeComponent();
        }

        protected void rbtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            //if (pictureBox1.Image == global::DVLD.Properties.Resources.person_man_200px && rbtnFemale.Checked == true)
            pictureBox1.Image = global::DVLD.Properties.Resources.person_woman_200px;
        }

        protected void rbtnMale_CheckedChanged(object sender, EventArgs e)
        {
            //if (pictureBox1.Image == global::DVLD.Properties.Resources.person_woman_200px && rbtnMale.Checked == true)
            pictureBox1.Image = global::DVLD.Properties.Resources.person_man_200px;
        }

        private void llbSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog GetImage = new OpenFileDialog();

            if (GetImage.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.ImageLocation = GetImage.FileName;
                this.pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }
    }
}