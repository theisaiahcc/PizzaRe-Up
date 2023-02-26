using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaRe_up
{
    public partial class Preset : Form
    {

        public List<string> Presets = new List<string>();
        public Preset()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            int index = 4;
            foreach (Control control in grpSpecial.Controls)
            {
                if (control is RadioButton radButton)
                {
                    // If checked, concatenate into ingredient string
                    bool isChecked = radButton.Checked;
                    if (isChecked)
                    {
                        Tag = Presets[index];
                    }
                    index--;
                }

            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (radMeatLover.Checked)
            {
                txtDescription.Text = "Lots of meat";
            }
            if (radHawaiian.Checked)
            {
                txtDescription.Text = "Ham and pineapple";
            }
            if (radMemphisChicken.Checked)
            {
                txtDescription.Text = "Chicken and onions";
            }
            if (radSupreme.Checked)
            {
                txtDescription.Text = "Lots of meat and veggies";
            }
            if (radVegetarian.Checked)
            {
                txtDescription.Text = "Veggies only";
            }
        }

        private void Preset_Load(object sender, EventArgs e)
        {
            Presets.Add("Pepperoni, Sausage, Bacon, Ham"); // meat lovers
            Presets.Add("Ham, Pineapple"); // hawaiian
            Presets.Add("Chicken, Onions"); // memphis chicken
            Presets.Add("Peppers, Mushrooms, Olives, Onions"); // vegetarian
            Presets.Add("Pepperoni, Bacon, Ham, Peppers, Onions, Mushrooms, Olives"); // supreme
        }
    }
}
