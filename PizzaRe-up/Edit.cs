using Microsoft.EntityFrameworkCore;
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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
/*            using PizzaContext dbContext = new();
            List<Pizza> allPizzas = dbContext.Pizzas.ToList();

            lstOrders.Items.Add(allPizzas);*/
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            using PizzaContext dbContext = new();
            List<Pizza> allPizzas = dbContext.Pizzas.ToList();

/*            lstOrders.Items.Add(allPizzas);*/

            foreach(Pizza pizza in allPizzas)
            {
                lstOrders.Items.Add(pizza.ToString());
            }
        }
    }
}
