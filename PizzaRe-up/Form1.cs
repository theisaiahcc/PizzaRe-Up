using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Drawing;

namespace PizzaRe_up
{
    public partial class PizzaAppForm : Form
    {
        public PizzaAppForm()
        {
            InitializeComponent();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            Edit editForm = new Edit();
            editForm.ShowDialog();
        }

        private void btnPreset_Click(object sender, EventArgs e)
        {
            Preset presetForm = new Preset();
            presetForm.ShowDialog();
        }

        private void PizzaAppForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using PizzaContext DbContext = new();
            // come back
            string ingredients = "Cheese";
            double price = 0;
            foreach (Control control in grpIngredients.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    // If checks are concatenated with checkboxes.
                    bool isChecked = checkBox.Checked;
                    if(isChecked)
                    {
                        ingredients = ingredients + ", " + checkBox.Text;
                        price += 1;
                    }
                }

            }
            string sauce = string.Empty;
            if(radWhiteSauce.Checked)
            {
                sauce = "white";
            }
            else
            {
                sauce = "red";
            }

            char size = 'm';
            if(radSmallSize.Checked)
            {
                size = 's';
                price += 8;
            }
            else if(radLargeSize.Checked)
            {
                size = 'l';
                price += 12;
            }
            else
            {
                price += 10;
            }

            string crust = string.Empty;
            if(radThin.Checked)
            {
                crust = "thin";
                price += 1;
            }
            else if(radRegular.Checked)
            {
                crust = "regular";

            }
            else
            {
                crust = "stuffed";
                price += 2;
            }
            
            Pizza p = new Pizza(ingredients, sauce, price, crust, size, "Isaiah");
            DbContext.Pizzas.Add(p);
            DbContext.SaveChanges();

        }
    }
}