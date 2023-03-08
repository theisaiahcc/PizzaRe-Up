using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

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
            if(editForm.Tag != null)
            {
                Pizza pizza = editForm.Tag as Pizza;
                LoadPizzaObject(pizza);
            }
        }

        private void btnPreset_Click(object sender, EventArgs e)
        {
            Preset presetForm = new Preset();
            presetForm.ShowDialog();
            // Gets ingredients string from preset form if there's one
            if (presetForm.Tag != null)
            {
                string ingredients = presetForm.Tag as string;
                LoadPizzaIngredients(ingredients);
            }
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
                MessageBox.Show("Your order has been completed");
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
                    return 'S';

                }
                else if (radLargeSize.Checked)
                {
                    return 'L';

                }
                else
                {
                    return 'M';
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
                else if (size == 'l')
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

        // creates pizza object from ingredients and calls load pizza object on that object
        private void LoadPizzaIngredients(string ingredients)
        {
            Pizza pizza = new Pizza(ingredients);
            LoadPizzaObject(pizza);
        }

        // Makes selections based on pizza objects ingredients
        private void LoadPizzaObject(Pizza pizza)
        {
            
            selectIngredients(pizza.Ingredients);
            selectSauceCrustSize(pizza.Sauce, pizza.Crust, pizza.Size);
            fillCustomerName(pizza.CustomerName);

            // selects the toppings
            void selectIngredients(string ingredients)
            {
                foreach (Control control in grpIngredients.Controls)
                {
                    if (control is CheckBox checkBox)
                    {
                        checkBox.Checked = false;
                        if (ingredients.Contains(checkBox.Text))
                        {
                            checkBox.Checked = true;
                        }
                    }

                }
            }
            // selects sauce, crust, and size
            void selectSauceCrustSize(string sauce, string crust, char size)
            {
                // select sauce
                if (sauce != "red")
                {
                    radWhiteSauce.Checked = true;
                }
                else
                {
                    radRedSauce.Checked = true;
                }

                // select crust
                if (crust == "thin")
                {
                    radThin.Checked = true;
                }
                else if (crust == "regular")
                {
                    radRegular.Checked = true;
                }
                else
                {
                    radStuffed.Checked = true;
                }

                // select size
                if (size == 'S')
                {
                    radSmallSize.Checked = true;
                }
                else if (size == 'M')
                {
                    radMediumSize.Checked = true;
                }
                else
                {
                    radLargeSize.Checked = true;
                }
            }
            // fills the Order name text box with given name
            void fillCustomerName(string name)
            {
                txtOrderName.Text = name;
            }
        }
    }
}