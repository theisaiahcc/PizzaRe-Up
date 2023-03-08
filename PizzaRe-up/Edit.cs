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

        private void Edit_Load(object sender, EventArgs e)
        {
            using PizzaContext dbContext = new();
            List<Pizza> allPizzas = dbContext.Pizzas.ToList();

            foreach(Pizza p in allPizzas)
            {
                lstOrders.Items.Add(p.ToString());
            }            
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lstOrders.SelectedItem != null)
            {
                string orderName = lstOrders.SelectedItem.ToString();
                using PizzaContext dbContext = new();
                Pizza pizza = (from p in dbContext.Pizzas
                               where p.CustomerName == orderName.Substring(0, orderName.IndexOf(" "))
                               select p).SingleOrDefault();
                Tag = pizza;
                this.Close();
            }
        }
    }
}
