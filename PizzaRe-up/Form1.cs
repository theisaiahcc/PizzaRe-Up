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
          
            string ingredients = "Cheese";
            double price = 0;
            getIngredients(ref ingredients, ref price);

            // get sauce, size, and crust type by calling local functions
            string sauce = getSauce();
            char size = getSize();
            string crust = getCrustType();
            price += getPrice(sauce, size, crust);

            // get name
            if (!validName(txtOrderName.Text))
            {
                MessageBox.Show("Order name cannot be empty.", "Order name required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // get name
                string name = txtOrderName.Text;
                // create pizza object and pass to PizzaContext add function
                Pizza p = new Pizza(ingredients, sauce, price, crust, size, name);
                DbContext.Add(p);
            }
            

            // Adds 1 to price for each ingredient and concatenates ingredients string
            void getIngredients(ref string ingredients, ref double price)
            {
                foreach (Control control in grpIngredients.Controls)
                {
                    if (control is CheckBox checkBox)
                    {
                        // If checked, concatenate into ingredient string
                        bool isChecked = checkBox.Checked;
                        if (isChecked)
                        {
                            ingredients = ingredients + ", " + checkBox.Text;
                            price += 1;
                        }
                    }

                }
            }

            // returns sauce string representing type of sauce
            string getSauce()
            {
                if (radWhiteSauce.Checked)
                {
                    return "white";
                }
                else
                {
                    return "red";
                }
            }

            // returns char representing size
            char getSize()
            {
                if (radSmallSize.Checked)
                {
                    return 's';

                }
                else if (radLargeSize.Checked)
                {
                    return 'l';

                }
                else
                {
                    return 'm';
                }
            }

            // returns crust string representing type of crust
            string getCrustType()
            {
                if (radThin.Checked)
                {
                    return "thin";
                }
                else if (radRegular.Checked)
                {
                    return "regular";

                }
                else
                {
                    return "stuffed";
                }
            }

            // returns price based on selections
            double getPrice(string sauce, char size, string crust)
            {
                double price = 8;
                if (sauce != "red")
                {
                    price += 1;
                }
                if (size == 'm')
                {
                    price += 2;
                }
                else if(size == 'l')
                {
                    price += 4;
                }
                if (crust == "thin")
                {
                    price += 1;
                }
                else if (crust == "stuffed")
                {
                    price += 2;
                }
                return price;
            }

            bool validName(string name)
            {
                if (name != string.Empty && name != "")
                {
                    return true;
                }
                return false;
            }
        }
    }
}