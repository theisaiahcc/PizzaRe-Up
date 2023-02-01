using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaRe_up
{
    public partial class Preset : Form
    {
        public Preset()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void radMeatLover_CheckedChanged(object sender, EventArgs e)
        {
            radio_CheckedChanged();
        }

        private void radHawaiian_CheckedChanged(object sender, EventArgs e)
        {
            radio_CheckedChanged();
        }

        private void radMemphisChicken_CheckedChanged(object sender, EventArgs e)
        {
            radio_CheckedChanged();
        }

        private void radVegan_CheckedChanged(object sender, EventArgs e)
        {
            radio_CheckedChanged();
        }

        private void radSupreme_CheckedChanged(object sender, EventArgs e)
        {
            radio_CheckedChanged();
        }

        private void radio_CheckedChanged()
        {
            if(radMeatLover.Checked)
            {
                txtDescription.Text = "Lots of meat";
            }
            if(radHawaiian.Checked)
            {
                txtDescription.Text = "With pineapples";
            }
            if(radMemphisChicken.Checked)
            {
                txtDescription.Text = "With chicken";
            }
            if(radSupreme.Checked)
            {
                txtDescription.Text = "With meat and veggies";
            }
            if(radVegan.Checked)
            {
                txtDescription.Text = "With vegetables";
            }
        }
    }
}
